namespace SistemaComercio.Gui
{
    partial class Frm_Fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Fornecedor));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblComple = new System.Windows.Forms.Label();
            this.lblLogra = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCid = new System.Windows.Forms.Label();
            this.lblEst = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlFundoForne = new System.Windows.Forms.Panel();
            this.dataGridViewForne = new System.Windows.Forms.DataGridView();
            this.Excluir = new System.Windows.Forms.DataGridViewImageColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.txtProcurar = new System.Windows.Forms.TextBox();
            this.lblProcurarNome = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCad = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtComple = new System.Windows.Forms.TextBox();
            this.txtLogra = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.pnlFundoForne.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 9);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(39, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(15, 35);
            this.lblCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(64, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF/CNPJ:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.Location = new System.Drawing.Point(444, 9);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(51, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Telefone:";
            // 
            // lblComple
            // 
            this.lblComple.AutoSize = true;
            this.lblComple.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComple.Location = new System.Drawing.Point(15, 90);
            this.lblComple.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComple.Name = "lblComple";
            this.lblComple.Size = new System.Drawing.Size(76, 13);
            this.lblComple.TabIndex = 3;
            this.lblComple.Text = "Complemento:";
            // 
            // lblLogra
            // 
            this.lblLogra.AutoSize = true;
            this.lblLogra.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogra.Location = new System.Drawing.Point(15, 61);
            this.lblLogra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogra.Name = "lblLogra";
            this.lblLogra.Size = new System.Drawing.Size(66, 13);
            this.lblLogra.TabIndex = 4;
            this.lblLogra.Text = "Logradouro:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(15, 119);
            this.lblBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(40, 13);
            this.lblBairro.TabIndex = 5;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblCid
            // 
            this.lblCid.AutoSize = true;
            this.lblCid.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCid.Location = new System.Drawing.Point(444, 35);
            this.lblCid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCid.Name = "lblCid";
            this.lblCid.Size = new System.Drawing.Size(43, 13);
            this.lblCid.TabIndex = 6;
            this.lblCid.Text = "Cidade:";
            // 
            // lblEst
            // 
            this.lblEst.AutoSize = true;
            this.lblEst.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEst.Location = new System.Drawing.Point(444, 61);
            this.lblEst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEst.Name = "lblEst";
            this.lblEst.Size = new System.Drawing.Size(42, 13);
            this.lblEst.TabIndex = 7;
            this.lblEst.Text = "Estado:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(444, 90);
            this.lblCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(32, 13);
            this.lblCEP.TabIndex = 8;
            this.lblCEP.Text = "CEP:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(250, 119);
            this.lblNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(49, 13);
            this.lblNum.TabIndex = 9;
            this.lblNum.Text = "Número:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(444, 119);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email:";
            // 
            // pnlFundoForne
            // 
            this.pnlFundoForne.BackColor = System.Drawing.Color.Thistle;
            this.pnlFundoForne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFundoForne.Controls.Add(this.dataGridViewForne);
            this.pnlFundoForne.Controls.Add(this.panel1);
            this.pnlFundoForne.Controls.Add(this.btnSair);
            this.pnlFundoForne.Controls.Add(this.btnSalvar);
            this.pnlFundoForne.Controls.Add(this.btnProcurar);
            this.pnlFundoForne.Controls.Add(this.txtProcurar);
            this.pnlFundoForne.Controls.Add(this.lblProcurarNome);
            this.pnlFundoForne.Controls.Add(this.btnLimpar);
            this.pnlFundoForne.Controls.Add(this.btnCad);
            this.pnlFundoForne.Controls.Add(this.txtEmail);
            this.pnlFundoForne.Controls.Add(this.txtEstado);
            this.pnlFundoForne.Controls.Add(this.txtCidade);
            this.pnlFundoForne.Controls.Add(this.txtTel);
            this.pnlFundoForne.Controls.Add(this.txtCEP);
            this.pnlFundoForne.Controls.Add(this.txtNum);
            this.pnlFundoForne.Controls.Add(this.txtBairro);
            this.pnlFundoForne.Controls.Add(this.txtComple);
            this.pnlFundoForne.Controls.Add(this.txtLogra);
            this.pnlFundoForne.Controls.Add(this.txtCPF);
            this.pnlFundoForne.Controls.Add(this.txtNome);
            this.pnlFundoForne.Controls.Add(this.lblNome);
            this.pnlFundoForne.Controls.Add(this.lblEmail);
            this.pnlFundoForne.Controls.Add(this.lblNum);
            this.pnlFundoForne.Controls.Add(this.lblCPF);
            this.pnlFundoForne.Controls.Add(this.lblCEP);
            this.pnlFundoForne.Controls.Add(this.lblEst);
            this.pnlFundoForne.Controls.Add(this.lblTel);
            this.pnlFundoForne.Controls.Add(this.lblLogra);
            this.pnlFundoForne.Controls.Add(this.lblCid);
            this.pnlFundoForne.Controls.Add(this.lblComple);
            this.pnlFundoForne.Controls.Add(this.lblBairro);
            this.pnlFundoForne.Location = new System.Drawing.Point(-1, -1);
            this.pnlFundoForne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlFundoForne.Name = "pnlFundoForne";
            this.pnlFundoForne.Size = new System.Drawing.Size(792, 452);
            this.pnlFundoForne.TabIndex = 12;
            // 
            // dataGridViewForne
            // 
            this.dataGridViewForne.AllowUserToAddRows = false;
            this.dataGridViewForne.AllowUserToDeleteRows = false;
            this.dataGridViewForne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewForne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Excluir,
            this.Editar});
            this.dataGridViewForne.Location = new System.Drawing.Point(18, 199);
            this.dataGridViewForne.Name = "dataGridViewForne";
            this.dataGridViewForne.ReadOnly = true;
            this.dataGridViewForne.RowHeadersVisible = false;
            this.dataGridViewForne.Size = new System.Drawing.Size(752, 206);
            this.dataGridViewForne.TabIndex = 33;
            this.dataGridViewForne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FormattingCollumns);
            this.dataGridViewForne.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.FormatttingMensageRows);
            this.dataGridViewForne.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FormattingRows);
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "";
            this.Excluir.Image = global::SistemaComercio.Properties.Resources.lixo;
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Image = global::SistemaComercio.Properties.Resources.editar;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumOrchid;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-9, 151);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 10);
            this.panel1.TabIndex = 32;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(666, 411);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 27);
            this.btnSair.TabIndex = 31;
            this.btnSair.Text = "     Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ClickSair);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::SistemaComercio.Properties.Resources.salve1;
            this.btnSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvar.Location = new System.Drawing.Point(126, 411);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(99, 27);
            this.btnSalvar.TabIndex = 29;
            this.btnSalvar.Text = "    Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.ClickSalvar);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcurar.Image = global::SistemaComercio.Properties.Resources.lupa;
            this.btnProcurar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcurar.Location = new System.Drawing.Point(435, 171);
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(99, 24);
            this.btnProcurar.TabIndex = 28;
            this.btnProcurar.Text = "    Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            this.btnProcurar.Click += new System.EventHandler(this.ClickPesquisar);
            // 
            // txtProcurar
            // 
            this.txtProcurar.Location = new System.Drawing.Point(112, 172);
            this.txtProcurar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtProcurar.Name = "txtProcurar";
            this.txtProcurar.Size = new System.Drawing.Size(315, 21);
            this.txtProcurar.TabIndex = 27;
            // 
            // lblProcurarNome
            // 
            this.lblProcurarNome.AutoSize = true;
            this.lblProcurarNome.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProcurarNome.Location = new System.Drawing.Point(15, 175);
            this.lblProcurarNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcurarNome.Name = "lblProcurarNome";
            this.lblProcurarNome.Size = new System.Drawing.Size(99, 13);
            this.lblProcurarNome.TabIndex = 26;
            this.lblProcurarNome.Text = "Procurar por nome:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpar.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(233, 411);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 27);
            this.btnLimpar.TabIndex = 24;
            this.btnLimpar.Text = "     Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.ClickLimpar);
            // 
            // btnCad
            // 
            this.btnCad.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCad.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCad.Image = global::SistemaComercio.Properties.Resources.adicionar;
            this.btnCad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCad.Location = new System.Drawing.Point(19, 411);
            this.btnCad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(99, 27);
            this.btnCad.TabIndex = 23;
            this.btnCad.Text = "    Cadastrar";
            this.btnCad.UseVisualStyleBackColor = false;
            this.btnCad.Click += new System.EventHandler(this.ClickCadastrar);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(484, 116);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(285, 21);
            this.txtEmail.TabIndex = 21;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(493, 58);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(276, 21);
            this.txtEstado.TabIndex = 20;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(493, 32);
            this.txtCidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(276, 21);
            this.txtCidade.TabIndex = 19;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(502, 6);
            this.txtTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(268, 21);
            this.txtTel.TabIndex = 18;
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(484, 87);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(285, 21);
            this.txtCEP.TabIndex = 17;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(303, 116);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(124, 21);
            this.txtNum.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(69, 116);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(173, 21);
            this.txtBairro.TabIndex = 15;
            // 
            // txtComple
            // 
            this.txtComple.Location = new System.Drawing.Point(99, 87);
            this.txtComple.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtComple.Name = "txtComple";
            this.txtComple.Size = new System.Drawing.Size(328, 21);
            this.txtComple.TabIndex = 14;
            // 
            // txtLogra
            // 
            this.txtLogra.Location = new System.Drawing.Point(88, 58);
            this.txtLogra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtLogra.Name = "txtLogra";
            this.txtLogra.Size = new System.Drawing.Size(340, 21);
            this.txtLogra.TabIndex = 13;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(88, 32);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(340, 21);
            this.txtCPF.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(55, 6);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(373, 21);
            this.txtNome.TabIndex = 11;
            // 
            // Frm_Fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 449);
            this.Controls.Add(this.pnlFundoForne);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_Fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fornecedor";
            this.Load += new System.EventHandler(this.Frm_Fornecedor_Load);
            this.pnlFundoForne.ResumeLayout(false);
            this.pnlFundoForne.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewForne)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblComple;
        private System.Windows.Forms.Label lblLogra;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblCid;
        private System.Windows.Forms.Label lblEst;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnlFundoForne;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtComple;
        private System.Windows.Forms.TextBox txtLogra;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.TextBox txtProcurar;
        private System.Windows.Forms.Label lblProcurarNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridViewForne;
        private System.Windows.Forms.DataGridViewImageColumn Excluir;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
    }
}