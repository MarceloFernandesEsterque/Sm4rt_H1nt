using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Crud;
using Org.BouncyCastle.Crypto.Agreement.Kdf;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using SmartHint_NET.Conect;
using System.Data;
using Google.Protobuf.WellKnownTypes;

namespace SmartHint_NET.Cadastro.Controle
{
    internal class Cadastra
    {
        public bool cadastra(Control i) {
            
            string dateNasc = "";
            bool ok = true;
            CheckBox checkboxIs = i.Controls["checkBoxIsent"] as CheckBox;
            CheckBox checkboxBl = i.Controls["groupBoxSitua"].Controls["checkBoxSitua"] as CheckBox;

            string insEst = string.IsNullOrEmpty(i.Controls["textBoxInsEst"].Text) || Convert.ToInt32(checkboxIs.Checked) == 1 ? "0" : i.Controls["textBoxInsEst"].Text;

            ConectMySql conectMy = new ConectMySql();
            conectMy.conectaBanco();

            foreach (Control c in i.Controls)
            {
                ok = true;

                if (c.GetType().Name.ToString().Equals("TextBox"))
                {
                    if(c.Text == "" && !checkboxIs.Checked)
                    {
                        string lb = "label" + c.Name.Replace("textBox", "").ToString();
                        MessageBox.Show($"O campo \"{i.Controls[lb].Text}\" é obrigatório.");
                        ok = false;
                        break;
                    }
                }
                else if (i.Controls["comboBoxTipoP"].Text == "")
                {
                    MessageBox.Show($"O campo \"{i.Controls["labelTipoP"].Text}\" é obrigatório.");
                    ok = false;
                    break;
                }
                else if (true)
                {
                    if (i.Controls["groupBoxPes"].Controls["comboBoxGen"].Text == "" && i.Controls["comboBoxTipoP"].Text.Equals("Física"))
                    {
                        MessageBox.Show($"O campo \"{i.Controls["groupBoxPes"].Controls["labelGen"].Text}\" é obrigatório.");
                        ok = false;
                        break;
                    }
                    else if (i.Controls["groupBoxPes"].Controls["dateNasc"].Text == " " && i.Controls["comboBoxTipoP"].Text.Equals("Física"))
                    {
                        MessageBox.Show($"O campo \"{i.Controls["groupBoxPes"].Controls["labelNasc"].Text}\" é obrigatório.");
                        ok = false;
                        break;
                    }
                    else if (i.Controls["groupBoxPes"].Controls["dateNasc"].Text != "" && i.Controls["comboBoxTipoP"].Text.Equals("Física"))
                    {
                        dateNasc = DateTime.Parse(i.Controls["groupBoxPes"].Controls["dateNasc"].Text).ToString("dd/MM/yyyy");
                        break;
                    }
                }
            }

            if (ok)
            {
                try
                {
                    DataTable data = conectMy.busca($"SELECT " +
                                            $"EMAIL, CPF_CNPJ, INSCRICAO " +
                                            $"from clientes " +
                                            $"where " +
                                            $"EMAIL = '{i.Controls["textBoxEmail"].Text}' OR " +
                                            $"CPF_CNPJ = '{i.Controls["textBoxCpfCnpj"].Text}' OR " +
                                            $"INSCRICAO = '{insEst}';");

                    if (data.Rows.Count == 0 || (i.Controls["buttonGuarda"].Visible && data.Rows.Count == 1))
                    {
                        ok = true;
                    }
                    else if (insEst == data.Rows[0][2].ToString() && ok)
                    {
                        MessageBox.Show("Esta Inscrição Estadual já está cadastrado para outro Cliente");
                        ok = false;
                    }
                    else if (i.Controls["textBoxEmail"].Text == data.Rows[0][0].ToString() && ok)
                    {
                        MessageBox.Show("Este e-mail já está cadastrado para outro Cliente");
                        ok = false;
                    }
                    else if (i.Controls["textBoxCpfCnpj"].Text == data.Rows[0][1].ToString() && ok)
                    {
                        MessageBox.Show("Este CPF/CNPJ já está cadastrado para outro Cliente");
                        ok = false;
                    }
                    else
                    {
                        throw new Exception("Não foi possível salver.\nPorfavor entre em contato com o suporte.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    ok = false;
                }
            }

            if (ok) {

                insEst = Convert.ToInt32(checkboxIs.Checked) == 1 ? "" : insEst;
                bool t;

                if (i.Controls["buttonAddCli"].Visible)
                {
                   t = conectMy.insere($"INSERT CLIENTES SELECT " +
                                       $"'{i.Controls["textBoxNomRaz"].Text}', " + //nome Razão
                                       $"'{i.Controls["textBoxEmail"].Text}', " + //email
                                       $"'{i.Controls["textBoxTel"].Text}', " + //telefone
                                       $"'{DateTime.Parse(i.Controls["dateCad"].Text).ToString("dd/MM/yyyy")}', " + //data cad
                                       $"'{i.Controls["comboBoxTipoP"].Text}', " + // Tipo pessoa
                                       $"'{i.Controls["textBoxCpfCnpj"].Text}', " + //CPF ou CNPJ
                                       $"'{insEst}', " + //inscrição
                                       $"'{Convert.ToInt32(checkboxIs.Checked)} ', " + //isenção
                                       $"'{i.Controls["groupBoxPes"].Controls["comboBoxGen"].Text}', " + //genero
                                       $"'{dateNasc}', " + //data nascimento
                                       $"'{Convert.ToInt32(checkboxBl.Checked)}', " + //bloqueio
                                       $"'{i.Controls["textBoxSenha"].Text}' " + //senha
                                       $"from dual;");

                    MessageBox.Show("Salvo com sucesso!");

                }
                else if(i.Controls["buttonGuarda"].Visible)
                {

                    t = conectMy.insere($"UPDATE CLIENTES SET " +
                                        $"NOME_RAZAO = '{i.Controls["textBoxNomRaz"].Text}', " + //nome Razão
                                        $"EMAIL = '{i.Controls["textBoxEmail"].Text}', " + //email
                                        $"TEL = '{i.Controls["textBoxTel"].Text}', " + //telefone
                                        $"DATA_CAD = '{DateTime.Parse(i.Controls["dateCad"].Text).ToString("dd/MM/yyyy")}', " + //data cad
                                        $"TIPO = '{i.Controls["comboBoxTipoP"].Text}', " + // Tipo pessoa
                                        $"CPF_CNPJ = '{i.Controls["textBoxCpfCnpj"].Text}', " + //CPF ou CNPJ
                                        $"INSCRICAO = '{insEst}', " + //inscrição
                                        $"ISENTO = '{Convert.ToInt32(checkboxIs.Checked)}', " + //isenção
                                        $"GENERO = '{i.Controls["groupBoxPes"].Controls["comboBoxGen"].Text}', " + //genero
                                        $"DATA_NASC ='{dateNasc}', " + //data nascimento
                                        $"BLOQ = '{Convert.ToInt32(checkboxBl.Checked)}', " + //bloqueio
                                        $"SENHA = '{i.Controls["textBoxSenha"].Text}' " + //senha
                                        $"WHERE EMAIL = '{i.Controls["textBoxEmail"].Text}';");
                    
                    _= t ? MessageBox.Show("Alteração salva!") : ((byte)NullValue.NullValue) ;

                }
                else
                {
                    MessageBox.Show("Não foi possível incluir este registro.\nPor favor entre em contato com o suporte!");
                    ok = false;
                }
                
            }
            return ok;
        }

        private string limp(string str)
        {
            var charsToRemove = new string[] { " ", "(", ")", "-", "+", ".", "/" };
            foreach (var c in charsToRemove)
            {
                str = str.Replace(c, string.Empty);
            }

            return str;
        }
    }
}
