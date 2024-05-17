using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

using MySql.Data.MySqlClient;
using System.Data.Common;
using MySqlX.XDevAPI;

using SmartHint_NET.Conect;
using SmartHint_NET.Cadastro.View;
using SmartHint_NET.Cadastro.Model;
using MySqlX.XDevAPI.Relational;
using Mysqlx.Resultset;
using System.Globalization;



namespace SmartHint_NET
{

    public partial class frmClientes : Form
    {
        int aba { get; set; }

        DataTable table { get; set; }

        ConectMySql conectMy = new ConectMySql();

        FormatCad formatCad = new FormatCad();

        public frmClientes()
        {
            InitializeComponent();
            ConectMySql conectMy = new ConectMySql();
            conectMy.conectaBanco();

            table = conectMy.busca("SELECT NOME_RAZAO AS 'Nome/Razão Social', EMAIL AS 'E-Mail', TEL AS 'Telefône', DATA_CAD AS 'Data de cadastro', IF(BLOQ=0, 'NÃO', 'SIM')  AS 'Bloqueio' FROM CLIENTES;");

            dataGridView1.DataSource = tratGrid(1);

            //MessageBox.Show(dataGridView1.RowCount.ToString());

            this.dateCriad.Value = this.dateCriad.Value.Date != System.DateTime.Now.Date ? new System.DateTime() : this.dateCriad.Value.Date;
            //this.dateNasc.Value = System.DateTime.MinValue;
            this.dateCriad.MaxDate = DateTime.Now;
            this.dateCriad.Format = DateTimePickerFormat.Custom;

            this.dateCriad.CustomFormat = " ";
            this.groupBoxFiltro.Visible = false;

        }

        private void buttonFiltro_Click(object sender, EventArgs e)
        {
            if (this.groupBoxFiltro.Visible)
            {
                this.groupBoxFiltro.Visible = false;
            }
            else
            {
                this.groupBoxFiltro.Visible = true;
            }
        }

        private void buttonLimp_Click(object sender, EventArgs e)
        {
            formatCad.limparOb(this.textBoxEmail);
            formatCad.limparOb(this.textBoxTel);
            this.comboBoxBloq.Text = "";
            this.dateCriad.CustomFormat = " ";
            this.textBoxNomeRaz.Text = "";
        }

        private void buttonLimpNome_Click(object sender, EventArgs e)
        {
            this.textBoxNomeRaz.Text = "";
        }

        private void buttonLimEmail_Click(object sender, EventArgs e)
        {
            formatCad.limparOb(textBoxEmail);
        }

        private void buttonLimTel_Click(object sender, EventArgs e)
        {
            formatCad.limparOb(textBoxTel);
        }

        private void buttonLimData_Click(object sender, EventArgs e)
        {
            this.dateCriad.CustomFormat = " ";
        }

        private void mascTel(object sender, EventArgs e)
        {
            formatCad.mascTel(sender);
        }

        public void validEmail(Object sender, EventArgs e)
        {
            formatCad.emailValid(sender);
        }

        private void buttonAplic_Click(object sender, EventArgs e)
        {

            conectMy.conectaBanco();
            table = conectMy.busca("SELECT NOME_RAZAO AS 'Nome/Razão Social', EMAIL AS 'E-Mail', TEL AS 'Telefône', DATA_CAD AS 'Data de cadastro', IF(BLOQ=0, 'NÃO', 'SIM')  AS 'Bloqueio' FROM CLIENTES " +
                "WHERE 1=1 " +
                (!string.IsNullOrEmpty(this.textBoxNomeRaz.Text) ? $"AND NOME_RAZAO LIKE '%{this.textBoxNomeRaz.Text}%' " : "") +
                (!string.IsNullOrEmpty(this.textBoxEmail.Text) ? $"AND EMAIL = '{this.textBoxEmail.Text}' " : "") +
                (!string.IsNullOrEmpty(this.textBoxTel.Text) ? $"AND TEL = '{this.textBoxTel.Text}' " : "") +
                (!this.dateCriad.Text.Equals(" ") ? $"AND DATA_CAD = '{this.dateCriad.Text}' " : "") +
                (!string.IsNullOrEmpty(this.comboBoxBloq.Text) ? $"AND BLOQ = '{(this.comboBoxBloq.Text == "Sim" ? "1" : "0")}'" : "") +
                ";");

            dataGridView1.DataSource = tratGrid(1);
        }

        private void buttonAddCli_Click(object sender, EventArgs e)
        {
            CadCli cadCli = new CadCli("", "", this);
            cadCli.Visible = true;
        }

        private void buttonLimBloq_Click(object sender, EventArgs e)
        {
            this.comboBoxBloq.Text = "";
        }

        private void formatData(object sender, EventArgs e)
        {
            this.dateCriad.Format = DateTimePickerFormat.Custom;

            this.dateCriad.CustomFormat = "dd/MM/yyyy";
        }

        private void abaAv(Object sender, EventArgs e)
        {
            dataGridView1.DataSource = tratGrid(aba <= (table.Rows.Count / 20) ? aba + 1 : aba);
        }

        private void abaAt(Object sender, EventArgs e)
        {
            dataGridView1.DataSource = tratGrid(aba > 1 ? aba - 1 : aba);
        }

        private DataTable tratGrid(int add)
        {
            aba = add;
            int lin = 20;
            this.labelLinhas.Text = $"({lin * aba - 19} a {aba * lin}) {aba} de {(table.Rows.Count / 20) + (table.Rows.Count - (table.Rows.Count / 20) > 1 ? 1 : 0)} (total {table.Rows.Count}).";

            try
            {
                String[] teste1 = new String[5];

                DataTable newTable = new DataTable();

                newTable = table.Clone();

                for (int x = (lin * aba) - 20; x < lin * aba && x < table.Rows.Count; x++)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Object teste = table.Rows[x][i];
                        teste1[i] = teste.ToString();
                    }
                    newTable.Rows.Add(teste1);
                }

                return newTable;
            }
            catch
            {
                return table;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var grid = dataGridView1 as DataGridView;
                CadCli cadCli = new CadCli("s", grid.CurrentRow.Cells[1].Value.ToString(), this);
                cadCli.Visible = true;

                _ = "";

            }
            catch (Exception)
            {
                this.Visible = true;

                MessageBox.Show("Não é possivel encontrar esse cadastro.");
            }
        }

        private void alterado(Object obj, EventArgs e)
        {
            tratGrid(1);
        }
    }
}
