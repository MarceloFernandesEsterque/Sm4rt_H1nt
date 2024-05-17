using System.Runtime.CompilerServices;

namespace SmartHint_NET.Cadastro.View
{
    partial class CadCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCli));
            this.textBoxNomRaz = new System.Windows.Forms.TextBox();
            this.labelNomRaz = new System.Windows.Forms.Label();
            this.buttonAddCli = new System.Windows.Forms.Button();
            this.buttonVolta = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.labelCpfCnpj = new System.Windows.Forms.Label();
            this.textBoxCpfCnpj = new System.Windows.Forms.TextBox();
            this.labelDataCri = new System.Windows.Forms.Label();
            this.dateCad = new System.Windows.Forms.DateTimePicker();
            this.labelGen = new System.Windows.Forms.Label();
            this.comboBoxGen = new System.Windows.Forms.ComboBox();
            this.labelInsEst = new System.Windows.Forms.Label();
            this.textBoxInsEst = new System.Windows.Forms.TextBox();
            this.checkBoxIsent = new System.Windows.Forms.CheckBox();
            this.labelNasc = new System.Windows.Forms.Label();
            this.groupBoxPes = new System.Windows.Forms.GroupBox();
            this.dateNasc = new System.Windows.Forms.DateTimePicker();
            this.labelTipoP = new System.Windows.Forms.Label();
            this.comboBoxTipoP = new System.Windows.Forms.ComboBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelConfSenha = new System.Windows.Forms.Label();
            this.textBoxConfSenha = new System.Windows.Forms.TextBox();
            this.groupBoxSitua = new System.Windows.Forms.GroupBox();
            this.checkBoxSitua = new System.Windows.Forms.CheckBox();
            this.buttonGuarda = new System.Windows.Forms.Button();
            this.groupBoxPes.SuspendLayout();
            this.groupBoxSitua.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNomRaz
            // 
            this.textBoxNomRaz.Location = new System.Drawing.Point(29, 59);
            this.textBoxNomRaz.Name = "textBoxNomRaz";
            this.textBoxNomRaz.Size = new System.Drawing.Size(291, 20);
            this.textBoxNomRaz.TabIndex = 0;
            // 
            // labelNomRaz
            // 
            this.labelNomRaz.AutoSize = true;
            this.labelNomRaz.Location = new System.Drawing.Point(29, 40);
            this.labelNomRaz.Name = "labelNomRaz";
            this.labelNomRaz.Size = new System.Drawing.Size(106, 13);
            this.labelNomRaz.TabIndex = 1;
            this.labelNomRaz.Text = "Nome/Razão Social:";
            // 
            // buttonAddCli
            // 
            this.buttonAddCli.Location = new System.Drawing.Point(38, 455);
            this.buttonAddCli.Name = "buttonAddCli";
            this.buttonAddCli.Size = new System.Drawing.Size(102, 23);
            this.buttonAddCli.TabIndex = 2;
            this.buttonAddCli.Text = "Adicionar Cliente";
            this.buttonAddCli.UseVisualStyleBackColor = true;
            this.buttonAddCli.Click += new System.EventHandler(this.buttonAddCli_Click);
            // 
            // buttonVolta
            // 
            this.buttonVolta.Location = new System.Drawing.Point(146, 455);
            this.buttonVolta.Name = "buttonVolta";
            this.buttonVolta.Size = new System.Drawing.Size(75, 23);
            this.buttonVolta.TabIndex = 3;
            this.buttonVolta.Text = "Voltar";
            this.buttonVolta.UseVisualStyleBackColor = true;
            this.buttonVolta.Click += new System.EventHandler(this.buttonVolta_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(29, 95);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(39, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "E-Mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(29, 114);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(291, 20);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.Leave += new System.EventHandler(this.validEmail);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(374, 95);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 13);
            this.labelTel.TabIndex = 7;
            this.labelTel.Text = "Telefone:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(374, 114);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(126, 20);
            this.textBoxTel.TabIndex = 6;
            this.textBoxTel.Leave += new System.EventHandler(this.mascT);
            // 
            // labelCpfCnpj
            // 
            this.labelCpfCnpj.AutoSize = true;
            this.labelCpfCnpj.Location = new System.Drawing.Point(374, 40);
            this.labelCpfCnpj.Name = "labelCpfCnpj";
            this.labelCpfCnpj.Size = new System.Drawing.Size(62, 13);
            this.labelCpfCnpj.TabIndex = 9;
            this.labelCpfCnpj.Text = "CPF/CNPJ:";
            // 
            // textBoxCpfCnpj
            // 
            this.textBoxCpfCnpj.Location = new System.Drawing.Point(374, 59);
            this.textBoxCpfCnpj.Name = "textBoxCpfCnpj";
            this.textBoxCpfCnpj.Size = new System.Drawing.Size(207, 20);
            this.textBoxCpfCnpj.TabIndex = 8;
            this.textBoxCpfCnpj.Leave += new System.EventHandler(this.mascC);
            // 
            // labelDataCri
            // 
            this.labelDataCri.AutoSize = true;
            this.labelDataCri.Location = new System.Drawing.Point(631, 97);
            this.labelDataCri.Name = "labelDataCri";
            this.labelDataCri.Size = new System.Drawing.Size(78, 13);
            this.labelDataCri.TabIndex = 10;
            this.labelDataCri.Text = "Data Cadastro:";
            // 
            // dateCad
            // 
            this.dateCad.Checked = false;
            this.dateCad.Enabled = false;
            this.dateCad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCad.Location = new System.Drawing.Point(634, 114);
            this.dateCad.Name = "dateCad";
            this.dateCad.Size = new System.Drawing.Size(99, 20);
            this.dateCad.TabIndex = 11;
            // 
            // labelGen
            // 
            this.labelGen.AutoSize = true;
            this.labelGen.Location = new System.Drawing.Point(6, 26);
            this.labelGen.Name = "labelGen";
            this.labelGen.Size = new System.Drawing.Size(45, 13);
            this.labelGen.TabIndex = 12;
            this.labelGen.Text = "Gênero:";
            // 
            // comboBoxGen
            // 
            this.comboBoxGen.AutoCompleteCustomSource.AddRange(new string[] {
            "Feminino",
            "Masculino",
            "Outros"});
            this.comboBoxGen.FormattingEnabled = true;
            this.comboBoxGen.Items.AddRange(new object[] {
            "Feminino",
            "Masculino",
            "Outros"});
            this.comboBoxGen.Location = new System.Drawing.Point(9, 43);
            this.comboBoxGen.Name = "comboBoxGen";
            this.comboBoxGen.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGen.TabIndex = 13;
            // 
            // labelInsEst
            // 
            this.labelInsEst.AutoSize = true;
            this.labelInsEst.Location = new System.Drawing.Point(29, 155);
            this.labelInsEst.Name = "labelInsEst";
            this.labelInsEst.Size = new System.Drawing.Size(97, 13);
            this.labelInsEst.TabIndex = 15;
            this.labelInsEst.Text = "Inscrição Estadual:";
            // 
            // textBoxInsEst
            // 
            this.textBoxInsEst.Location = new System.Drawing.Point(29, 174);
            this.textBoxInsEst.Name = "textBoxInsEst";
            this.textBoxInsEst.Size = new System.Drawing.Size(126, 20);
            this.textBoxInsEst.TabIndex = 14;
            this.textBoxInsEst.Leave += new System.EventHandler(this.mascInsc);
            // 
            // checkBoxIsent
            // 
            this.checkBoxIsent.AutoSize = true;
            this.checkBoxIsent.Location = new System.Drawing.Point(217, 174);
            this.checkBoxIsent.Name = "checkBoxIsent";
            this.checkBoxIsent.Size = new System.Drawing.Size(64, 17);
            this.checkBoxIsent.TabIndex = 16;
            this.checkBoxIsent.Text = "Isenção";
            this.checkBoxIsent.UseVisualStyleBackColor = true;
            this.checkBoxIsent.CheckedChanged += new System.EventHandler(this.isent);
            // 
            // labelNasc
            // 
            this.labelNasc.AutoSize = true;
            this.labelNasc.Location = new System.Drawing.Point(345, 26);
            this.labelNasc.Name = "labelNasc";
            this.labelNasc.Size = new System.Drawing.Size(64, 13);
            this.labelNasc.TabIndex = 17;
            this.labelNasc.Text = "Data Nasc.:";
            // 
            // groupBoxPes
            // 
            this.groupBoxPes.Controls.Add(this.dateNasc);
            this.groupBoxPes.Controls.Add(this.labelNasc);
            this.groupBoxPes.Controls.Add(this.labelGen);
            this.groupBoxPes.Controls.Add(this.comboBoxGen);
            this.groupBoxPes.Location = new System.Drawing.Point(29, 220);
            this.groupBoxPes.Name = "groupBoxPes";
            this.groupBoxPes.Size = new System.Drawing.Size(552, 100);
            this.groupBoxPes.TabIndex = 19;
            this.groupBoxPes.TabStop = false;
            this.groupBoxPes.Text = "Pessoa Física";
            // 
            // dateNasc
            // 
            this.dateNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateNasc.Location = new System.Drawing.Point(348, 43);
            this.dateNasc.Name = "dateNasc";
            this.dateNasc.Size = new System.Drawing.Size(123, 20);
            this.dateNasc.TabIndex = 18;
            this.dateNasc.Enter += new System.EventHandler(this.alterDate);
            // 
            // labelTipoP
            // 
            this.labelTipoP.AutoSize = true;
            this.labelTipoP.Location = new System.Drawing.Point(631, 40);
            this.labelTipoP.Name = "labelTipoP";
            this.labelTipoP.Size = new System.Drawing.Size(83, 13);
            this.labelTipoP.TabIndex = 19;
            this.labelTipoP.Text = "Tipo de pessoa:";
            // 
            // comboBoxTipoP
            // 
            this.comboBoxTipoP.AutoCompleteCustomSource.AddRange(new string[] {
            "Física",
            "Jurídica"});
            this.comboBoxTipoP.FormattingEnabled = true;
            this.comboBoxTipoP.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.comboBoxTipoP.Location = new System.Drawing.Point(634, 57);
            this.comboBoxTipoP.Name = "comboBoxTipoP";
            this.comboBoxTipoP.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoP.TabIndex = 20;
            this.comboBoxTipoP.SelectedIndexChanged += new System.EventHandler(this.tipoPessoa);
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(35, 348);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 22;
            this.labelSenha.Text = "Senha:";
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(35, 367);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(126, 20);
            this.textBoxSenha.TabIndex = 21;
            this.textBoxSenha.Leave += new System.EventHandler(this.senhaValid);
            // 
            // labelConfSenha
            // 
            this.labelConfSenha.AutoSize = true;
            this.labelConfSenha.Location = new System.Drawing.Point(214, 348);
            this.labelConfSenha.Name = "labelConfSenha";
            this.labelConfSenha.Size = new System.Drawing.Size(85, 13);
            this.labelConfSenha.TabIndex = 24;
            this.labelConfSenha.Text = "Confirma Senha:";
            // 
            // textBoxConfSenha
            // 
            this.textBoxConfSenha.Location = new System.Drawing.Point(214, 367);
            this.textBoxConfSenha.Name = "textBoxConfSenha";
            this.textBoxConfSenha.Size = new System.Drawing.Size(126, 20);
            this.textBoxConfSenha.TabIndex = 23;
            this.textBoxConfSenha.Leave += new System.EventHandler(this.senhaValid);
            // 
            // groupBoxSitua
            // 
            this.groupBoxSitua.Controls.Add(this.checkBoxSitua);
            this.groupBoxSitua.Location = new System.Drawing.Point(634, 220);
            this.groupBoxSitua.Name = "groupBoxSitua";
            this.groupBoxSitua.Size = new System.Drawing.Size(121, 100);
            this.groupBoxSitua.TabIndex = 25;
            this.groupBoxSitua.TabStop = false;
            this.groupBoxSitua.Text = "Situação";
            // 
            // checkBoxSitua
            // 
            this.checkBoxSitua.AutoSize = true;
            this.checkBoxSitua.Location = new System.Drawing.Point(35, 43);
            this.checkBoxSitua.Name = "checkBoxSitua";
            this.checkBoxSitua.Size = new System.Drawing.Size(67, 17);
            this.checkBoxSitua.TabIndex = 26;
            this.checkBoxSitua.Text = "Bloqueio";
            this.checkBoxSitua.UseVisualStyleBackColor = true;
            // 
            // buttonGuarda
            // 
            this.buttonGuarda.Location = new System.Drawing.Point(38, 455);
            this.buttonGuarda.Name = "buttonGuarda";
            this.buttonGuarda.Size = new System.Drawing.Size(102, 23);
            this.buttonGuarda.TabIndex = 26;
            this.buttonGuarda.Text = "Guardar";
            this.buttonGuarda.UseVisualStyleBackColor = true;
            this.buttonGuarda.Click += new System.EventHandler(this.edit);
            // 
            // CadCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 510);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGuarda);
            this.Controls.Add(this.groupBoxSitua);
            this.Controls.Add(this.labelConfSenha);
            this.Controls.Add(this.textBoxConfSenha);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelTipoP);
            this.Controls.Add(this.groupBoxPes);
            this.Controls.Add(this.comboBoxTipoP);
            this.Controls.Add(this.checkBoxIsent);
            this.Controls.Add(this.labelInsEst);
            this.Controls.Add(this.textBoxInsEst);
            this.Controls.Add(this.dateCad);
            this.Controls.Add(this.labelDataCri);
            this.Controls.Add(this.labelCpfCnpj);
            this.Controls.Add(this.textBoxCpfCnpj);
            this.Controls.Add(this.labelTel);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.buttonVolta);
            this.Controls.Add(this.buttonAddCli);
            this.Controls.Add(this.labelNomRaz);
            this.Controls.Add(this.textBoxNomRaz);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "CadCli";
            this.Text = "Cadastro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadCli_FormClosing);
            this.groupBoxPes.ResumeLayout(false);
            this.groupBoxPes.PerformLayout();
            this.groupBoxSitua.ResumeLayout(false);
            this.groupBoxSitua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNomRaz;
        public System.Windows.Forms.Label labelNomRaz;
        private System.Windows.Forms.Button buttonAddCli;
        private System.Windows.Forms.Button buttonVolta;
        public System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label labelCpfCnpj;
        private System.Windows.Forms.TextBox textBoxCpfCnpj;
        private System.Windows.Forms.Label labelDataCri;
        private System.Windows.Forms.DateTimePicker dateCad;
        private System.Windows.Forms.Label labelGen;
        public System.Windows.Forms.ComboBox comboBoxGen;
        private System.Windows.Forms.Label labelInsEst;
        public System.Windows.Forms.TextBox textBoxInsEst;
        public System.Windows.Forms.CheckBox checkBoxIsent;
        private System.Windows.Forms.Label labelNasc;
        private System.Windows.Forms.GroupBox groupBoxPes;
        private System.Windows.Forms.DateTimePicker dateNasc;
        private System.Windows.Forms.Label labelTipoP;
        private System.Windows.Forms.ComboBox comboBoxTipoP;
        private System.Windows.Forms.Label labelSenha;
        public System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelConfSenha;
        public System.Windows.Forms.TextBox textBoxConfSenha;
        private System.Windows.Forms.GroupBox groupBoxSitua;
        public System.Windows.Forms.CheckBox checkBoxSitua;
        private System.Windows.Forms.Button buttonGuarda;
    }
}