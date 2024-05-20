namespace SmartHint_NET
{
    partial class frmClientes
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes));
            this.buttonAddCli = new System.Windows.Forms.Button();
            this.buttonFiltro = new System.Windows.Forms.Button();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.buttonLimBloq = new System.Windows.Forms.Button();
            this.comboBoxBloq = new System.Windows.Forms.ComboBox();
            this.buttonLimData = new System.Windows.Forms.Button();
            this.buttonLimTel = new System.Windows.Forms.Button();
            this.buttonLimEmail = new System.Windows.Forms.Button();
            this.buttonLimpNome = new System.Windows.Forms.Button();
            this.buttonAplic = new System.Windows.Forms.Button();
            this.buttonLimp = new System.Windows.Forms.Button();
            this.labelCliBloq = new System.Windows.Forms.Label();
            this.labelDataCli = new System.Windows.Forms.Label();
            this.dateCriad = new System.Windows.Forms.DateTimePicker();
            this.labelTel = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeRaz = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.labelLinhas = new System.Windows.Forms.Label();
            this.buttonAt = new System.Windows.Forms.Button();
            this.buttonAv = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.groupBoxFiltro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCli
            // 
            this.buttonAddCli.Location = new System.Drawing.Point(12, 32);
            this.buttonAddCli.Name = "buttonAddCli";
            this.buttonAddCli.Size = new System.Drawing.Size(100, 23);
            this.buttonAddCli.TabIndex = 0;
            this.buttonAddCli.Text = "Adicionar Cliente";
            this.buttonAddCli.UseVisualStyleBackColor = true;
            this.buttonAddCli.Click += new System.EventHandler(this.buttonAddCli_Click);
            // 
            // buttonFiltro
            // 
            this.buttonFiltro.Location = new System.Drawing.Point(155, 32);
            this.buttonFiltro.Name = "buttonFiltro";
            this.buttonFiltro.Size = new System.Drawing.Size(42, 23);
            this.buttonFiltro.TabIndex = 1;
            this.buttonFiltro.Text = "Filtro";
            this.buttonFiltro.UseVisualStyleBackColor = true;
            this.buttonFiltro.Click += new System.EventHandler(this.buttonFiltro_Click);
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Controls.Add(this.buttonLimBloq);
            this.groupBoxFiltro.Controls.Add(this.comboBoxBloq);
            this.groupBoxFiltro.Controls.Add(this.buttonLimData);
            this.groupBoxFiltro.Controls.Add(this.buttonLimTel);
            this.groupBoxFiltro.Controls.Add(this.buttonLimEmail);
            this.groupBoxFiltro.Controls.Add(this.buttonLimpNome);
            this.groupBoxFiltro.Controls.Add(this.buttonAplic);
            this.groupBoxFiltro.Controls.Add(this.buttonLimp);
            this.groupBoxFiltro.Controls.Add(this.labelCliBloq);
            this.groupBoxFiltro.Controls.Add(this.labelDataCli);
            this.groupBoxFiltro.Controls.Add(this.dateCriad);
            this.groupBoxFiltro.Controls.Add(this.labelTel);
            this.groupBoxFiltro.Controls.Add(this.textBoxTel);
            this.groupBoxFiltro.Controls.Add(this.label2);
            this.groupBoxFiltro.Controls.Add(this.textBoxEmail);
            this.groupBoxFiltro.Controls.Add(this.label1);
            this.groupBoxFiltro.Controls.Add(this.textBoxNomeRaz);
            this.groupBoxFiltro.Location = new System.Drawing.Point(203, 32);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(1006, 74);
            this.groupBoxFiltro.TabIndex = 2;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Campos";
            // 
            // buttonLimBloq
            // 
            this.buttonLimBloq.Location = new System.Drawing.Point(821, 34);
            this.buttonLimBloq.Name = "buttonLimBloq";
            this.buttonLimBloq.Size = new System.Drawing.Size(26, 23);
            this.buttonLimBloq.TabIndex = 16;
            this.buttonLimBloq.Text = "X";
            this.buttonLimBloq.UseVisualStyleBackColor = true;
            this.buttonLimBloq.Click += new System.EventHandler(this.buttonLimBloq_Click);
            // 
            // comboBoxBloq
            // 
            this.comboBoxBloq.FormattingEnabled = true;
            this.comboBoxBloq.Items.AddRange(new object[] {
            "Sim",
            "Não"});
            this.comboBoxBloq.Location = new System.Drawing.Point(748, 36);
            this.comboBoxBloq.Name = "comboBoxBloq";
            this.comboBoxBloq.Size = new System.Drawing.Size(70, 21);
            this.comboBoxBloq.TabIndex = 15;
            // 
            // buttonLimData
            // 
            this.buttonLimData.Location = new System.Drawing.Point(707, 34);
            this.buttonLimData.Name = "buttonLimData";
            this.buttonLimData.Size = new System.Drawing.Size(26, 23);
            this.buttonLimData.TabIndex = 14;
            this.buttonLimData.Text = "X";
            this.buttonLimData.UseVisualStyleBackColor = true;
            this.buttonLimData.Click += new System.EventHandler(this.buttonLimData_Click);
            // 
            // buttonLimTel
            // 
            this.buttonLimTel.Location = new System.Drawing.Point(579, 35);
            this.buttonLimTel.Name = "buttonLimTel";
            this.buttonLimTel.Size = new System.Drawing.Size(27, 23);
            this.buttonLimTel.TabIndex = 13;
            this.buttonLimTel.Text = "X";
            this.buttonLimTel.UseVisualStyleBackColor = true;
            this.buttonLimTel.Click += new System.EventHandler(this.buttonLimTel_Click);
            // 
            // buttonLimEmail
            // 
            this.buttonLimEmail.Location = new System.Drawing.Point(427, 35);
            this.buttonLimEmail.Name = "buttonLimEmail";
            this.buttonLimEmail.Size = new System.Drawing.Size(27, 23);
            this.buttonLimEmail.TabIndex = 12;
            this.buttonLimEmail.Text = "X";
            this.buttonLimEmail.UseVisualStyleBackColor = true;
            this.buttonLimEmail.Click += new System.EventHandler(this.buttonLimEmail_Click);
            // 
            // buttonLimpNome
            // 
            this.buttonLimpNome.Location = new System.Drawing.Point(197, 36);
            this.buttonLimpNome.Name = "buttonLimpNome";
            this.buttonLimpNome.Size = new System.Drawing.Size(27, 23);
            this.buttonLimpNome.TabIndex = 11;
            this.buttonLimpNome.Text = "X";
            this.buttonLimpNome.UseVisualStyleBackColor = true;
            this.buttonLimpNome.Click += new System.EventHandler(this.buttonLimpNome_Click);
            // 
            // buttonAplic
            // 
            this.buttonAplic.Location = new System.Drawing.Point(955, 32);
            this.buttonAplic.Name = "buttonAplic";
            this.buttonAplic.Size = new System.Drawing.Size(45, 23);
            this.buttonAplic.TabIndex = 10;
            this.buttonAplic.Text = "Aplicar";
            this.buttonAplic.UseVisualStyleBackColor = true;
            this.buttonAplic.Click += new System.EventHandler(this.buttonAplic_Click);
            // 
            // buttonLimp
            // 
            this.buttonLimp.Location = new System.Drawing.Point(904, 33);
            this.buttonLimp.Name = "buttonLimp";
            this.buttonLimp.Size = new System.Drawing.Size(45, 23);
            this.buttonLimp.TabIndex = 4;
            this.buttonLimp.Text = "Limpar";
            this.buttonLimp.UseVisualStyleBackColor = true;
            this.buttonLimp.Click += new System.EventHandler(this.buttonLimp_Click);
            // 
            // labelCliBloq
            // 
            this.labelCliBloq.AutoSize = true;
            this.labelCliBloq.Location = new System.Drawing.Point(745, 21);
            this.labelCliBloq.Name = "labelCliBloq";
            this.labelCliBloq.Size = new System.Drawing.Size(96, 13);
            this.labelCliBloq.TabIndex = 9;
            this.labelCliBloq.Text = "Cliente Bloqueado:";
            // 
            // labelDataCli
            // 
            this.labelDataCli.AutoSize = true;
            this.labelDataCli.Location = new System.Drawing.Point(610, 21);
            this.labelDataCli.Name = "labelDataCli";
            this.labelDataCli.Size = new System.Drawing.Size(93, 13);
            this.labelDataCli.TabIndex = 7;
            this.labelDataCli.Text = "Data de Cadastro:";
            // 
            // dateCriad
            // 
            this.dateCriad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateCriad.Location = new System.Drawing.Point(613, 36);
            this.dateCriad.Name = "dateCriad";
            this.dateCriad.Size = new System.Drawing.Size(93, 20);
            this.dateCriad.TabIndex = 6;
            this.dateCriad.Enter += new System.EventHandler(this.formatData);
            // 
            // labelTel
            // 
            this.labelTel.AutoSize = true;
            this.labelTel.Location = new System.Drawing.Point(462, 21);
            this.labelTel.Name = "labelTel";
            this.labelTel.Size = new System.Drawing.Size(52, 13);
            this.labelTel.TabIndex = 5;
            this.labelTel.Text = "Telefône:";
            // 
            // textBoxTel
            // 
            this.textBoxTel.AccessibleDescription = "";
            this.textBoxTel.AccessibleName = "";
            this.textBoxTel.Location = new System.Drawing.Point(465, 37);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(114, 20);
            this.textBoxTel.TabIndex = 4;
            this.textBoxTel.WordWrap = false;
            this.textBoxTel.Enter += new System.EventHandler(this.placeholder);
            this.textBoxTel.Leave += new System.EventHandler(this.mascTel);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "E-Mail:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AccessibleDescription = "";
            this.textBoxEmail.AccessibleName = "";
            this.textBoxEmail.Location = new System.Drawing.Point(236, 37);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(191, 20);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.WordWrap = false;
            this.textBoxEmail.Enter += new System.EventHandler(this.placeholder);
            this.textBoxEmail.Leave += new System.EventHandler(this.validEmail);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome/Razão Social:";
            // 
            // textBoxNomeRaz
            // 
            this.textBoxNomeRaz.AccessibleDescription = "";
            this.textBoxNomeRaz.AccessibleName = "";
            this.textBoxNomeRaz.Location = new System.Drawing.Point(18, 38);
            this.textBoxNomeRaz.Name = "textBoxNomeRaz";
            this.textBoxNomeRaz.Size = new System.Drawing.Size(179, 20);
            this.textBoxNomeRaz.TabIndex = 0;
            this.textBoxNomeRaz.Tag = "Teste";
            this.textBoxNomeRaz.WordWrap = false;
            this.textBoxNomeRaz.Enter += new System.EventHandler(this.placeholder);
            this.textBoxNomeRaz.Leave += new System.EventHandler(this.placeholder);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1197, 356);
            this.dataGridView1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(429, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Consulte os seus Clientes cadastrados na sua Loja ou realize o cadastro de novos " +
    "Cliente";
            // 
            // labelLinhas
            // 
            this.labelLinhas.AutoSize = true;
            this.labelLinhas.Location = new System.Drawing.Point(545, 474);
            this.labelLinhas.Name = "labelLinhas";
            this.labelLinhas.Size = new System.Drawing.Size(16, 13);
            this.labelLinhas.TabIndex = 5;
            this.labelLinhas.Text = "...";
            // 
            // buttonAt
            // 
            this.buttonAt.Location = new System.Drawing.Point(498, 474);
            this.buttonAt.Name = "buttonAt";
            this.buttonAt.Size = new System.Drawing.Size(26, 23);
            this.buttonAt.TabIndex = 17;
            this.buttonAt.Text = "<";
            this.buttonAt.UseVisualStyleBackColor = true;
            this.buttonAt.Click += new System.EventHandler(this.abaAt);
            // 
            // buttonAv
            // 
            this.buttonAv.Location = new System.Drawing.Point(686, 474);
            this.buttonAv.Name = "buttonAv";
            this.buttonAv.Size = new System.Drawing.Size(26, 23);
            this.buttonAv.TabIndex = 18;
            this.buttonAv.Text = ">";
            this.buttonAv.UseVisualStyleBackColor = true;
            this.buttonAv.Click += new System.EventHandler(this.abaAv);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(12, 61);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(100, 23);
            this.buttonEdit.TabIndex = 19;
            this.buttonEdit.Text = "Editar Cliente";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 502);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAv);
            this.Controls.Add(this.buttonAt);
            this.Controls.Add(this.labelLinhas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.buttonFiltro);
            this.Controls.Add(this.buttonAddCli);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "frmClientes";
            this.Text = "Clientes";
            this.VisibleChanged += new System.EventHandler(this.alterado);
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCli;
        private System.Windows.Forms.Button buttonFiltro;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.TextBox textBoxNomeRaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateCriad;
        private System.Windows.Forms.Label labelTel;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCliBloq;
        private System.Windows.Forms.Label labelDataCli;
        private System.Windows.Forms.Button buttonLimp;
        private System.Windows.Forms.Button buttonLimData;
        private System.Windows.Forms.Button buttonLimTel;
        private System.Windows.Forms.Button buttonLimEmail;
        private System.Windows.Forms.Button buttonLimpNome;
        private System.Windows.Forms.Button buttonAplic;
        private System.Windows.Forms.ComboBox comboBoxBloq;
        private System.Windows.Forms.Button buttonLimBloq;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelLinhas;
        private System.Windows.Forms.Button buttonAt;
        private System.Windows.Forms.Button buttonAv;
        private System.Windows.Forms.Button buttonEdit;
    }
}

