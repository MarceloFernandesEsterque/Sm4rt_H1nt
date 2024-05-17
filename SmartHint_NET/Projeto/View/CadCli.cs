using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf;
using Google.Protobuf.WellKnownTypes;
using Microsoft.SqlServer.Server;

//using Microsoft.Toolkit.Uwp.Notifications;
using SmartHint_NET.Cadastro.Model;
using SmartHint_NET.Cadastro.Controle;
using System.Xml;
using MySqlX.XDevAPI.Relational;
using SmartHint_NET.Conect;

namespace SmartHint_NET.Cadastro.View
{
    public partial class CadCli : Form
    {
        Control prG;
        FormatCad formatCad = new FormatCad();
        ConectMySql conectMy = new ConectMySql();
        public CadCli(string id, string busca, Control pr)
        {
            InitializeComponent();
            this.dateCad.Value = this.dateCad.Value.Date != System.DateTime.Now.Date ? new System.DateTime() : this.dateCad.Value.Date;
            //this.dateNasc.Value = System.DateTime.MinValue;
            this.dateNasc.MaxDate = DateTime.Now;
            this.dateNasc.Format = DateTimePickerFormat.Custom;

            this.dateNasc.CustomFormat = " ";
            this.groupBoxPes.Visible = false;
            formatCad.fCad(this);

            prG = pr;
            prG.Visible = false;

            if (id.Equals("s"))
            {
                this.buttonAddCli.Visible = false;
                this.textBoxEmail.Enabled = false;
                this.textBoxCpfCnpj.Enabled = false;

                al(busca);
                
            }
            else
            {
                buttonGuarda.Visible = false;
            }
        }

        private void al(string busca)
        {
            conectMy.conectaBanco();
            DataTable table = conectMy.busca($"SELECT NOME_RAZAO, EMAIL, TEL, DATA_CAD, TIPO, CPF_CNPJ, INSCRICAO, ISENTO, GENERO, DATA_NASC, BLOQ, SENHA FROM CLIENTES WHERE EMAIL = '{busca}';");

            string[] teste1 = new string[12];

            for (int x = 0; x < 12; x++) {
                Object teste = table.Rows[0][x];
                teste1[x] = teste.ToString();
            }

            this.Text = "Editar";

            this.textBoxNomRaz.Text = teste1[0];
            this.textBoxEmail.Text = teste1[1];
            this.textBoxTel.Text = teste1[2];
            this.dateCad.Text = teste1[3];
            this.comboBoxTipoP.Text = teste1[4];
            this.textBoxCpfCnpj.Text = teste1[5];
            this.textBoxInsEst.Text = teste1[6];
            this.checkBoxIsent.Checked = bool.Parse(teste1[7]);
            this.comboBoxGen.Text = teste1[8];
            this.dateNasc.CustomFormat = "dd/MM/yyyy";
            this.dateNasc.Text = teste1[9];
            this.checkBoxSitua.Checked = bool.Parse(teste1[10]);
            this.textBoxConfSenha.Text = teste1[11];
            this.textBoxSenha.Text = teste1[11];
        }

        public void mascT(Object sender, EventArgs e)
        {

            formatCad.mascTel(sender);
        }

        public void mascC(Object sender, EventArgs e)
        {

            formatCad.mascCpf(sender);
        }

        public void validEmail(Object sender, EventArgs e)
        {
            formatCad.emailValid(sender);
        }

        public void mascInsc(Object sender, EventArgs e)
        {
            formatCad.mascInsc(sender);
        }

        public void isent(Object sender, EventArgs e)
        {
            this.textBoxInsEst.Enabled = !this.checkBoxIsent.Checked;
            if (this.checkBoxIsent.Checked)
            {
                this.textBoxInsEst.Text = "";
                this.textBoxInsEst.BackColor = Color.White;
            }
        }

        public void senhaValid(Object sender, EventArgs e)
        {
            if(this.textBoxSenha.Text != "" && this.textBoxConfSenha.Text != "")
            {
                formatCad.senhaValid(this);
            }
        }

        

        private void alterDate(Object sender, EventArgs e)
        {
            this.dateNasc.Format = DateTimePickerFormat.Custom;

            this.dateNasc.CustomFormat = "dd/MM/yyyy";
        }

        public void tipoPessoa(object sender, EventArgs e)
        {
            if (this.comboBoxTipoP.Text.Equals("Física"))
            {
                this.groupBoxPes.Visible = true;
            }
            else
            {
                this.dateNasc.CustomFormat = " ";
                this.comboBoxGen.Text = "";
                this.groupBoxPes.Visible = false;
            }
        }

        private void buttonVolta_Click(object sender, EventArgs e)
        {
            prG.Visible = true;
            this.Close();
        }

        private void edit(Object sender, EventArgs e)
        {
            Cadastra cad = new Cadastra();

            if (cad.cadastra(this))
            {
                prG.Visible = true;
                this.Close();
            }
        }

        private void buttonAddCli_Click(object sender, EventArgs e)
        {
            Cadastra cad = new Cadastra();

            if (cad.cadastra(this))
            {
                prG.Visible = true;
                this.Close();
            }
        }

        private void CadCli_FormClosing(object sender, FormClosingEventArgs e)
        {
            prG.Visible = true;
        }
    }
}
