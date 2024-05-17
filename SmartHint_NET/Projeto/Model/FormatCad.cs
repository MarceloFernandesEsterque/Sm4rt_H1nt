using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Management;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Encoders;
using SmartHint_NET.Cadastro.View;

namespace SmartHint_NET.Cadastro.Model
{

    internal class FormatCad
    {
        public void fCad(Control S)
        {
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;

            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(S.Controls["textBoxNomRaz"], "Nome Completo ou Razão Social");
            toolTip1.SetToolTip(S.Controls["textBoxEmail"], "E-mail do Cliente");
            toolTip1.SetToolTip(S.Controls["textBoxTel"], "Telefone do Cliente");
            toolTip1.SetToolTip(S.Controls["comboBoxTipoP"], "Selecione o tipo de Pessoa");
            toolTip1.SetToolTip(S.Controls["textBoxCpfCnpj"], "Insira CPF ou o CNPJ do Cliente");
            toolTip1.SetToolTip(S.Controls["textBoxInsEst"], "Inscrição Estadual do Cliente, selecionar Isento caso assim for");
            toolTip1.SetToolTip(S.Controls["groupBoxPes"].Controls["comboBoxGen"], "Selecione o gênero do Cliente");
            toolTip1.SetToolTip(S.Controls["groupBoxPes"].Controls["dateNasc"], "Data de Nascimento do Cliente");
            toolTip1.SetToolTip(S.Controls["groupBoxSitua"].Controls["checkBoxSitua"], "Bloqueio o acesso do Cliente na sua loja");
            toolTip1.SetToolTip(S.Controls["textBoxSenha"], "Cadastre a Senha de acesso do Cliente");
            toolTip1.SetToolTip(S.Controls["textBoxConfSenha"], "Inscrição Estadual do Cliente, selecionar Isento caso assim for");
        }

        public void mascTel(object t)
        {
            Control objt = t as Control;

            var str = objt.Text;

            try
            {
                var charsToRemove = new string[] { " ", "(", ")", "-", "+" };
                foreach (var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }
                long TEL = Convert.ToInt64(str.Substring(str.PadLeft(11, '0').Length - 11));
                
                string TELFormatado = String.Format(@"{0:\(00\) 00000\-0000}", TEL);
                objt.Text = TELFormatado;

                string colorcode = "#FFffffff";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, digite um número válido!", "Número incorreto");

                string colorcode = "#FFE28686";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
        }

        public void mascCpf(object t)
        {
            Control objt = t as Control;

            var str = objt.Text;

            try
            {
                var charsToRemove = new string[] { " ", ".", "-"};
                foreach (var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                string CpfRazForm = "";

                if (str.Length <= 11)
                {
                    long CPF = Convert.ToInt64(str.Substring(str.PadLeft(11, '0').Length - 11));
                    
                    CpfRazForm = String.Format(@"{0:000\.000\.000\-00}", CPF);
                } else if (str.Length <= 14)
                {
                    long CNPJ = Convert.ToInt64(str.Substring(str.PadLeft(14, '0').Length - 14));
                    
                    CpfRazForm = String.Format(@"{0:00\.000\.000\/0000\-00}", CNPJ);
                }
                else
                {
                    throw new Exception();
                }

                objt.Text = CpfRazForm;

                string colorcode = "#FFffffff";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, digite um número válido!", "Número incorreto");

                string colorcode = "#FFE28686";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
        }

        public void emailValid(object t)
        {
            Control objt = t as Control;

            var str = objt.Text;

            try
            {
                bool isValid = IsValidEmail(str);

                if (!isValid)
                {
                    throw new Exception();
                }

                string colorcode = "#FFffffff";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, digite um e-mail válido\ne inferior a 150 caracters.");

                string colorcode = "#FFE28686";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
        }

        public static bool IsValidEmail(string email)
        {
            // Padrão de expressão regular para verificar o formato de email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            // Verifica se o email corresponde ao padrão
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
        }

        public void mascInsc(object t)
        {
            Control objt = t as Control;

            var str = objt.Text;

            try
            {
                var charsToRemove = new string[] { " ", ".", "-" };
                foreach (var c in charsToRemove)
                {
                    str = str.Replace(c, string.Empty);
                }

                string insc = "";

                if (str.Length <= 12)
                {
                    long numIns = Convert.ToInt64(str.Substring(str.PadLeft(12, '0').Length - 12));

                    insc = String.Format(@"{0:000\.000\.000\-000}", numIns);
                }
                else
                {
                    throw new Exception();
                }

                objt.Text = insc;

                string colorcode = "#FFffffff";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor, digite um número válido!", "Número incorreto");

                string colorcode = "#FFE28686";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.BackColor = clr;
            }

        }

        public void senhaValid(object t)
        {
            Control objt = t as Control;

            try
            {
                _= objt.Controls["textBoxSenha"].Text != objt.Controls["textBoxConfSenha"].Text ? throw new Exception("As senhas precisam ser iguais.") : "" ;

                _ = objt.Controls["textBoxSenha"].Text.Length < 8 || objt.Controls["textBoxSenha"].Text.Length > 15 ? throw new Exception("Quantidade min 8 e max 15 dígitos.") : "";

                if (IsAlphanumeric(objt.Controls["textBoxSenha"].Text))
                {
                    objt.Controls["buttonAddCli"].Enabled = true;
                }
                else
                {
                    objt.Controls["buttonAddCli"].Enabled = false;
                    throw new Exception("Necessário ter somente letras e números.");
                }

                object a = objt.Controls["buttonAddCli"].Enabled = true;

                string colorcode = "#FF8FDC90";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.Controls["textBoxSenha"].BackColor = clr;
                objt.Controls["textBoxConfSenha"].BackColor = clr;
            }
            catch (Exception ex)
            {
                objt.Controls["buttonAddCli"].Enabled = false;
                MessageBox.Show(ex.Message);

                string colorcode = "#FFE28686";
                int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
                Color clr = Color.FromArgb(argb);

                objt.Controls["textBoxSenha"].BackColor = clr;
                objt.Controls["textBoxConfSenha"].BackColor = clr;
            }
        }

        public static bool IsAlphanumeric(string str)
        {
            bool od = false;

            // Expressão regular para verificar se a string contém apenas letras e números
            if (!Regex.IsMatch(str, @"^[a-zA-Z]+$") && !Regex.IsMatch(str, @"^[0-9]+$"))
            {
                od = Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");
            }
            return od;
        }

        public void limparOb(Control t)
        {
            string colorcode = "#FFffffff";
            int argb = Int32.Parse(colorcode.Replace("#", ""), NumberStyles.HexNumber);
            Color clr = Color.FromArgb(argb);

            t.Text = "";
            t.BackColor = clr;

        }
    }
}
