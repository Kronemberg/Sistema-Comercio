namespace SistemaComercio.Gui
{
    partial class Frm_ContaReceber
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ContaReceber));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.gpbFormaPagamento = new System.Windows.Forms.GroupBox();
            this.txtValorPaga = new System.Windows.Forms.TextBox();
            this.lblValorPaga = new System.Windows.Forms.Label();
            this.btnVender = new System.Windows.Forms.Button();
            this.cmbParcelamento = new System.Windows.Forms.ComboBox();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.rdbCartaoCredito = new System.Windows.Forms.RadioButton();
            this.rdbCartaoDebito = new System.Windows.Forms.RadioButton();
            this.rdbDinehiro = new System.Windows.Forms.RadioButton();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.lblSelecionePagamento = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEmitirRela = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtDataVenci = new System.Windows.Forms.TextBox();
            this.lblDataVenci = new System.Windows.Forms.Label();
            this.txtDataLanca = new System.Windows.Forms.TextBox();
            this.lblDataLanca = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cmbSelecioneContaReceber = new System.Windows.Forms.ComboBox();
            this.lblSelecioneContaReceber = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpbFormaPagamento.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.btnLimparCampos);
            this.panel1.Controls.Add(this.gpbFormaPagamento);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEmitirRela);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(-5, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(612, 295);
            this.panel1.TabIndex = 0;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimparCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.Location = new System.Drawing.Point(152, 261);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(113, 23);
            this.btnLimparCampos.TabIndex = 6;
            this.btnLimparCampos.Text = "     Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.ClickLimparCampos);
            // 
            // gpbFormaPagamento
            // 
            this.gpbFormaPagamento.Controls.Add(this.txtValorPaga);
            this.gpbFormaPagamento.Controls.Add(this.lblValorPaga);
            this.gpbFormaPagamento.Controls.Add(this.btnVender);
            this.gpbFormaPagamento.Controls.Add(this.cmbParcelamento);
            this.gpbFormaPagamento.Controls.Add(this.lblParcelamento);
            this.gpbFormaPagamento.Controls.Add(this.rdbCartaoCredito);
            this.gpbFormaPagamento.Controls.Add(this.rdbCartaoDebito);
            this.gpbFormaPagamento.Controls.Add(this.rdbDinehiro);
            this.gpbFormaPagamento.Controls.Add(this.rdbPix);
            this.gpbFormaPagamento.Controls.Add(this.lblSelecionePagamento);
            this.gpbFormaPagamento.Enabled = false;
            this.gpbFormaPagamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gpbFormaPagamento.Location = new System.Drawing.Point(17, 145);
            this.gpbFormaPagamento.Name = "gpbFormaPagamento";
            this.gpbFormaPagamento.Size = new System.Drawing.Size(576, 110);
            this.gpbFormaPagamento.TabIndex = 5;
            this.gpbFormaPagamento.TabStop = false;
            this.gpbFormaPagamento.Text = "Forma de Pagamento";
            // 
            // txtValorPaga
            // 
            this.txtValorPaga.Location = new System.Drawing.Point(328, 48);
            this.txtValorPaga.Name = "txtValorPaga";
            this.txtValorPaga.Size = new System.Drawing.Size(137, 21);
            this.txtValorPaga.TabIndex = 21;
            // 
            // lblValorPaga
            // 
            this.lblValorPaga.AutoSize = true;
            this.lblValorPaga.Location = new System.Drawing.Point(224, 53);
            this.lblValorPaga.Name = "lblValorPaga";
            this.lblValorPaga.Size = new System.Drawing.Size(107, 13);
            this.lblValorPaga.TabIndex = 20;
            this.lblValorPaga.Text = "Valor do Pagamento:";
            // 
            // btnVender
            // 
            this.btnVender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVender.Image = global::SistemaComercio.Properties.Resources.ImgCash;
            this.btnVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVender.Location = new System.Drawing.Point(487, 53);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(83, 23);
            this.btnVender.TabIndex = 6;
            this.btnVender.Text = "      Vender";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.ClickVender);
            // 
            // cmbParcelamento
            // 
            this.cmbParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelamento.Enabled = false;
            this.cmbParcelamento.FormattingEnabled = true;
            this.cmbParcelamento.Location = new System.Drawing.Point(294, 75);
            this.cmbParcelamento.Name = "cmbParcelamento";
            this.cmbParcelamento.Size = new System.Drawing.Size(171, 21);
            this.cmbParcelamento.TabIndex = 6;
            this.cmbParcelamento.SelectedIndexChanged += new System.EventHandler(this.cmbParcelamento_SelectedIndexChanged);
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Location = new System.Drawing.Point(224, 78);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(73, 13);
            this.lblParcelamento.TabIndex = 5;
            this.lblParcelamento.Text = "Parcelamento:";
            // 
            // rdbCartaoCredito
            // 
            this.rdbCartaoCredito.AutoSize = true;
            this.rdbCartaoCredito.Location = new System.Drawing.Point(97, 76);
            this.rdbCartaoCredito.Name = "rdbCartaoCredito";
            this.rdbCartaoCredito.Size = new System.Drawing.Size(108, 17);
            this.rdbCartaoCredito.TabIndex = 4;
            this.rdbCartaoCredito.TabStop = true;
            this.rdbCartaoCredito.Text = "Cartão de Crédito";
            this.rdbCartaoCredito.UseVisualStyleBackColor = true;
            this.rdbCartaoCredito.CheckedChanged += new System.EventHandler(this.rbbCartaoCredito_CheckedChanged);
            // 
            // rdbCartaoDebito
            // 
            this.rdbCartaoDebito.AutoSize = true;
            this.rdbCartaoDebito.Location = new System.Drawing.Point(97, 53);
            this.rdbCartaoDebito.Name = "rdbCartaoDebito";
            this.rdbCartaoDebito.Size = new System.Drawing.Size(105, 17);
            this.rdbCartaoDebito.TabIndex = 3;
            this.rdbCartaoDebito.TabStop = true;
            this.rdbCartaoDebito.Text = "Cartão de Débito";
            this.rdbCartaoDebito.UseVisualStyleBackColor = true;
            this.rdbCartaoDebito.CheckedChanged += new System.EventHandler(this.rdbCartaoDebito_CheckedChanged);
            // 
            // rdbDinehiro
            // 
            this.rdbDinehiro.AutoSize = true;
            this.rdbDinehiro.Location = new System.Drawing.Point(9, 76);
            this.rdbDinehiro.Name = "rdbDinehiro";
            this.rdbDinehiro.Size = new System.Drawing.Size(67, 17);
            this.rdbDinehiro.TabIndex = 2;
            this.rdbDinehiro.TabStop = true;
            this.rdbDinehiro.Text = "Dinheiro";
            this.rdbDinehiro.UseVisualStyleBackColor = true;
            this.rdbDinehiro.CheckedChanged += new System.EventHandler(this.rdbDinehiro_CheckedChanged);
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Checked = true;
            this.rdbPix.Location = new System.Drawing.Point(9, 53);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(41, 17);
            this.rdbPix.TabIndex = 1;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "Pix";
            this.rdbPix.UseVisualStyleBackColor = true;
            this.rdbPix.CheckedChanged += new System.EventHandler(this.rdbPix_CheckedChanged);
            // 
            // lblSelecionePagamento
            // 
            this.lblSelecionePagamento.AutoSize = true;
            this.lblSelecionePagamento.Location = new System.Drawing.Point(6, 27);
            this.lblSelecionePagamento.Name = "lblSelecionePagamento";
            this.lblSelecionePagamento.Size = new System.Drawing.Size(196, 13);
            this.lblSelecionePagamento.TabIndex = 0;
            this.lblSelecionePagamento.Text = "Selecione abaixo a forma de pagamento:";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(504, 261);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(89, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ClickSair);
            // 
            // btnEmitirRela
            // 
            this.btnEmitirRela.Image = global::SistemaComercio.Properties.Resources.trade_report_reports_documents_2351;
            this.btnEmitirRela.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitirRela.Location = new System.Drawing.Point(17, 261);
            this.btnEmitirRela.Name = "btnEmitirRela";
            this.btnEmitirRela.Size = new System.Drawing.Size(129, 23);
            this.btnEmitirRela.TabIndex = 3;
            this.btnEmitirRela.Text = "      Emitir Relatório";
            this.btnEmitirRela.UseVisualStyleBackColor = true;
            this.btnEmitirRela.Click += new System.EventHandler(this.ClickEmitirRelatorio);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtValor);
            this.groupBox1.Controls.Add(this.lblValor);
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.txtCliente);
            this.groupBox1.Controls.Add(this.txtDataVenci);
            this.groupBox1.Controls.Add(this.lblDataVenci);
            this.groupBox1.Controls.Add(this.txtDataLanca);
            this.groupBox1.Controls.Add(this.lblDataLanca);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.cmbSelecioneContaReceber);
            this.groupBox1.Controls.Add(this.lblSelecioneContaReceber);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 121);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geração de Conta a Receber";
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(462, 29);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(108, 21);
            this.txtValor.TabIndex = 12;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(428, 32);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 11;
            this.lblValor.Text = "Valor:";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(11, 90);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(43, 13);
            this.lblCliente.TabIndex = 10;
            this.lblCliente.Text = "Cliente:";
            // 
            // txtCliente
            // 
            this.txtCliente.Enabled = false;
            this.txtCliente.Location = new System.Drawing.Point(60, 87);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(224, 21);
            this.txtCliente.TabIndex = 9;
            // 
            // txtDataVenci
            // 
            this.txtDataVenci.Enabled = false;
            this.txtDataVenci.Location = new System.Drawing.Point(404, 89);
            this.txtDataVenci.Name = "txtDataVenci";
            this.txtDataVenci.Size = new System.Drawing.Size(166, 21);
            this.txtDataVenci.TabIndex = 8;
            // 
            // lblDataVenci
            // 
            this.lblDataVenci.AutoSize = true;
            this.lblDataVenci.Location = new System.Drawing.Point(301, 92);
            this.lblDataVenci.Name = "lblDataVenci";
            this.lblDataVenci.Size = new System.Drawing.Size(107, 13);
            this.lblDataVenci.TabIndex = 7;
            this.lblDataVenci.Text = "Data do Vencimento:";
            // 
            // txtDataLanca
            // 
            this.txtDataLanca.Enabled = false;
            this.txtDataLanca.Location = new System.Drawing.Point(404, 61);
            this.txtDataLanca.Name = "txtDataLanca";
            this.txtDataLanca.Size = new System.Drawing.Size(166, 21);
            this.txtDataLanca.TabIndex = 6;
            // 
            // lblDataLanca
            // 
            this.lblDataLanca.AutoSize = true;
            this.lblDataLanca.Location = new System.Drawing.Point(301, 64);
            this.lblDataLanca.Name = "lblDataLanca";
            this.lblDataLanca.Size = new System.Drawing.Size(107, 13);
            this.lblDataLanca.TabIndex = 5;
            this.lblDataLanca.Text = "Data do Lançamento:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(60, 59);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(224, 21);
            this.txtDescricao.TabIndex = 4;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(6, 62);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(57, 13);
            this.lblDescricao.TabIndex = 3;
            this.lblDescricao.Text = "Descrição:";
            // 
            // cmbSelecioneContaReceber
            // 
            this.cmbSelecioneContaReceber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneContaReceber.FormattingEnabled = true;
            this.cmbSelecioneContaReceber.Location = new System.Drawing.Point(209, 29);
            this.cmbSelecioneContaReceber.Name = "cmbSelecioneContaReceber";
            this.cmbSelecioneContaReceber.Size = new System.Drawing.Size(199, 21);
            this.cmbSelecioneContaReceber.TabIndex = 1;
            this.cmbSelecioneContaReceber.SelectedIndexChanged += new System.EventHandler(this.cmbSelecioneContaReceber_SelectedIndexChanged);
            // 
            // lblSelecioneContaReceber
            // 
            this.lblSelecioneContaReceber.AutoSize = true;
            this.lblSelecioneContaReceber.Location = new System.Drawing.Point(6, 32);
            this.lblSelecioneContaReceber.Name = "lblSelecioneContaReceber";
            this.lblSelecioneContaReceber.Size = new System.Drawing.Size(207, 13);
            this.lblSelecioneContaReceber.TabIndex = 0;
            this.lblSelecioneContaReceber.Text = "Selecioneo id da venda que deseja receber:";
            // 
            // Frm_ContaReceber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 286);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_ContaReceber";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conta a Receber";
            this.panel1.ResumeLayout(false);
            this.gpbFormaPagamento.ResumeLayout(false);
            this.gpbFormaPagamento.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelecioneContaReceber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSelecioneContaReceber;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataVenci;
        private System.Windows.Forms.TextBox txtDataLanca;
        private System.Windows.Forms.Label lblDataLanca;
        private System.Windows.Forms.TextBox txtDataVenci;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEmitirRela;
        private System.Windows.Forms.GroupBox gpbFormaPagamento;
        private System.Windows.Forms.RadioButton rdbCartaoDebito;
        private System.Windows.Forms.RadioButton rdbDinehiro;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.Label lblSelecionePagamento;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.ComboBox cmbParcelamento;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.RadioButton rdbCartaoCredito;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.Label lblValorPaga;
        private System.Windows.Forms.TextBox txtValorPaga;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label lblValor;
    }
}