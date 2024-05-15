namespace SistemaComercio.Gui
{
    partial class Frm_ContaPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ContaPagar));
            this.gpbContaPagar = new System.Windows.Forms.GroupBox();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.lblSelecioneForne = new System.Windows.Forms.Label();
            this.cmbSelecioneCompra = new System.Windows.Forms.ComboBox();
            this.lblSelecioneCompra = new System.Windows.Forms.Label();
            this.txtDataVenci = new System.Windows.Forms.TextBox();
            this.txtDataLanca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDataFecha = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblDataLanca = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtValorPaga = new System.Windows.Forms.TextBox();
            this.lblValorPaga = new System.Windows.Forms.Label();
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.gpbFormaPagamento = new System.Windows.Forms.GroupBox();
            this.cmbParcelamento = new System.Windows.Forms.ComboBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.lblParcelamento = new System.Windows.Forms.Label();
            this.rdbCartaoCredito = new System.Windows.Forms.RadioButton();
            this.rdbCartaoDebito = new System.Windows.Forms.RadioButton();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbPix = new System.Windows.Forms.RadioButton();
            this.lblSlecionePagamento = new System.Windows.Forms.Label();
            this.gpbContaPagar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gpbFormaPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbContaPagar
            // 
            this.gpbContaPagar.BackColor = System.Drawing.Color.Tan;
            this.gpbContaPagar.Controls.Add(this.txtFornecedor);
            this.gpbContaPagar.Controls.Add(this.txtValor);
            this.gpbContaPagar.Controls.Add(this.lblSelecioneForne);
            this.gpbContaPagar.Controls.Add(this.cmbSelecioneCompra);
            this.gpbContaPagar.Controls.Add(this.lblSelecioneCompra);
            this.gpbContaPagar.Controls.Add(this.txtDataVenci);
            this.gpbContaPagar.Controls.Add(this.txtDataLanca);
            this.gpbContaPagar.Controls.Add(this.txtDescricao);
            this.gpbContaPagar.Controls.Add(this.lblDataFecha);
            this.gpbContaPagar.Controls.Add(this.lblValor);
            this.gpbContaPagar.Controls.Add(this.lblDataLanca);
            this.gpbContaPagar.Controls.Add(this.lblDescricao);
            this.gpbContaPagar.Location = new System.Drawing.Point(14, 12);
            this.gpbContaPagar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbContaPagar.Name = "gpbContaPagar";
            this.gpbContaPagar.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbContaPagar.Size = new System.Drawing.Size(576, 120);
            this.gpbContaPagar.TabIndex = 0;
            this.gpbContaPagar.TabStop = false;
            this.gpbContaPagar.Text = "Geração de Conta a Pagar";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Enabled = false;
            this.txtFornecedor.Location = new System.Drawing.Point(67, 84);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(206, 21);
            this.txtFornecedor.TabIndex = 19;
            // 
            // txtValor
            // 
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(444, 26);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(124, 21);
            this.txtValor.TabIndex = 12;
            // 
            // lblSelecioneForne
            // 
            this.lblSelecioneForne.AutoSize = true;
            this.lblSelecioneForne.Location = new System.Drawing.Point(7, 87);
            this.lblSelecioneForne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecioneForne.Name = "lblSelecioneForne";
            this.lblSelecioneForne.Size = new System.Drawing.Size(64, 13);
            this.lblSelecioneForne.TabIndex = 18;
            this.lblSelecioneForne.Text = "Fornecedor:";
            // 
            // cmbSelecioneCompra
            // 
            this.cmbSelecioneCompra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneCompra.FormattingEnabled = true;
            this.cmbSelecioneCompra.Location = new System.Drawing.Point(216, 26);
            this.cmbSelecioneCompra.Name = "cmbSelecioneCompra";
            this.cmbSelecioneCompra.Size = new System.Drawing.Size(183, 21);
            this.cmbSelecioneCompra.TabIndex = 17;
            this.cmbSelecioneCompra.SelectedIndexChanged += new System.EventHandler(this.cmbSelecioneCompra_SelectedIndexChanged);
            // 
            // lblSelecioneCompra
            // 
            this.lblSelecioneCompra.AutoSize = true;
            this.lblSelecioneCompra.Location = new System.Drawing.Point(7, 29);
            this.lblSelecioneCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecioneCompra.Name = "lblSelecioneCompra";
            this.lblSelecioneCompra.Size = new System.Drawing.Size(209, 13);
            this.lblSelecioneCompra.TabIndex = 14;
            this.lblSelecioneCompra.Text = "Selecione o id da compra que deseja pagar:";
            // 
            // txtDataVenci
            // 
            this.txtDataVenci.Enabled = false;
            this.txtDataVenci.Location = new System.Drawing.Point(397, 84);
            this.txtDataVenci.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataVenci.Name = "txtDataVenci";
            this.txtDataVenci.Size = new System.Drawing.Size(169, 21);
            this.txtDataVenci.TabIndex = 9;
            // 
            // txtDataLanca
            // 
            this.txtDataLanca.Enabled = false;
            this.txtDataLanca.Location = new System.Drawing.Point(397, 57);
            this.txtDataLanca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDataLanca.Name = "txtDataLanca";
            this.txtDataLanca.Size = new System.Drawing.Size(171, 21);
            this.txtDataLanca.TabIndex = 8;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(67, 58);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(206, 21);
            this.txtDescricao.TabIndex = 7;
            // 
            // lblDataFecha
            // 
            this.lblDataFecha.AutoSize = true;
            this.lblDataFecha.Location = new System.Drawing.Point(292, 87);
            this.lblDataFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataFecha.Name = "lblDataFecha";
            this.lblDataFecha.Size = new System.Drawing.Size(107, 13);
            this.lblDataFecha.TabIndex = 2;
            this.lblDataFecha.Text = "Data do Vencimento:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(406, 29);
            this.lblValor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(37, 13);
            this.lblValor.TabIndex = 3;
            this.lblValor.Text = "Valor:";
            // 
            // lblDataLanca
            // 
            this.lblDataLanca.AutoSize = true;
            this.lblDataLanca.Location = new System.Drawing.Point(292, 61);
            this.lblDataLanca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDataLanca.Name = "lblDataLanca";
            this.lblDataLanca.Size = new System.Drawing.Size(107, 13);
            this.lblDataLanca.TabIndex = 1;
            this.lblDataLanca.Text = "Data do Lançamento:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(9, 61);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(57, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtValorPaga
            // 
            this.txtValorPaga.Location = new System.Drawing.Point(339, 51);
            this.txtValorPaga.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtValorPaga.Name = "txtValorPaga";
            this.txtValorPaga.Size = new System.Drawing.Size(122, 21);
            this.txtValorPaga.TabIndex = 11;
            // 
            // lblValorPaga
            // 
            this.lblValorPaga.AutoSize = true;
            this.lblValorPaga.Location = new System.Drawing.Point(230, 54);
            this.lblValorPaga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValorPaga.Name = "lblValorPaga";
            this.lblValorPaga.Size = new System.Drawing.Size(107, 13);
            this.lblValorPaga.TabIndex = 6;
            this.lblValorPaga.Text = "Valor do Pagamento:";
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.Image = global::SistemaComercio.Properties.Resources.trade_report_reports_documents_2351;
            this.btnEmitirRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(20, 262);
            this.btnEmitirRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(130, 22);
            this.btnEmitirRelatorio.TabIndex = 2;
            this.btnEmitirRelatorio.Text = "        Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            this.btnEmitirRelatorio.Click += new System.EventHandler(this.ClickEmitirRelatorio);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(504, 262);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(93, 22);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ClickSair);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.btnLimparCampos);
            this.panel1.Controls.Add(this.gpbFormaPagamento);
            this.panel1.Controls.Add(this.btnEmitirRelatorio);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Location = new System.Drawing.Point(-7, -6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 296);
            this.panel1.TabIndex = 4;
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimparCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.Location = new System.Drawing.Point(157, 262);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(114, 22);
            this.btnLimparCampos.TabIndex = 5;
            this.btnLimparCampos.Text = "     Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.ClickLimparCampos);
            // 
            // gpbFormaPagamento
            // 
            this.gpbFormaPagamento.Controls.Add(this.cmbParcelamento);
            this.gpbFormaPagamento.Controls.Add(this.txtValorPaga);
            this.gpbFormaPagamento.Controls.Add(this.btnPagar);
            this.gpbFormaPagamento.Controls.Add(this.lblParcelamento);
            this.gpbFormaPagamento.Controls.Add(this.rdbCartaoCredito);
            this.gpbFormaPagamento.Controls.Add(this.rdbCartaoDebito);
            this.gpbFormaPagamento.Controls.Add(this.rdbDinheiro);
            this.gpbFormaPagamento.Controls.Add(this.lblValorPaga);
            this.gpbFormaPagamento.Controls.Add(this.rdbPix);
            this.gpbFormaPagamento.Controls.Add(this.lblSlecionePagamento);
            this.gpbFormaPagamento.Enabled = false;
            this.gpbFormaPagamento.Location = new System.Drawing.Point(21, 144);
            this.gpbFormaPagamento.Name = "gpbFormaPagamento";
            this.gpbFormaPagamento.Size = new System.Drawing.Size(576, 112);
            this.gpbFormaPagamento.TabIndex = 4;
            this.gpbFormaPagamento.TabStop = false;
            this.gpbFormaPagamento.Text = "Forma de Pagamento";
            // 
            // cmbParcelamento
            // 
            this.cmbParcelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParcelamento.Enabled = false;
            this.cmbParcelamento.FormattingEnabled = true;
            this.cmbParcelamento.Location = new System.Drawing.Point(305, 75);
            this.cmbParcelamento.Name = "cmbParcelamento";
            this.cmbParcelamento.Size = new System.Drawing.Size(156, 21);
            this.cmbParcelamento.TabIndex = 5;
            this.cmbParcelamento.SelectedIndexChanged += new System.EventHandler(this.cmbParcelamento_SelectedIndexChanged);
            // 
            // btnPagar
            // 
            this.btnPagar.Image = global::SistemaComercio.Properties.Resources.ImgCash;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(483, 68);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(83, 23);
            this.btnPagar.TabIndex = 9;
            this.btnPagar.Text = "      Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.ClickPagar);
            // 
            // lblParcelamento
            // 
            this.lblParcelamento.AutoSize = true;
            this.lblParcelamento.Location = new System.Drawing.Point(235, 78);
            this.lblParcelamento.Name = "lblParcelamento";
            this.lblParcelamento.Size = new System.Drawing.Size(73, 13);
            this.lblParcelamento.TabIndex = 6;
            this.lblParcelamento.Text = "Parcelamento:";
            // 
            // rdbCartaoCredito
            // 
            this.rdbCartaoCredito.AutoSize = true;
            this.rdbCartaoCredito.Location = new System.Drawing.Point(111, 76);
            this.rdbCartaoCredito.Name = "rdbCartaoCredito";
            this.rdbCartaoCredito.Size = new System.Drawing.Size(108, 17);
            this.rdbCartaoCredito.TabIndex = 4;
            this.rdbCartaoCredito.Text = "Cartão de Crédito";
            this.rdbCartaoCredito.UseVisualStyleBackColor = true;
            this.rdbCartaoCredito.CheckedChanged += new System.EventHandler(this.rdbCartaoCredito_CheckedChanged);
            // 
            // rdbCartaoDebito
            // 
            this.rdbCartaoDebito.AutoSize = true;
            this.rdbCartaoDebito.Location = new System.Drawing.Point(111, 53);
            this.rdbCartaoDebito.Name = "rdbCartaoDebito";
            this.rdbCartaoDebito.Size = new System.Drawing.Size(105, 17);
            this.rdbCartaoDebito.TabIndex = 3;
            this.rdbCartaoDebito.Text = "Cartão de Débito";
            this.rdbCartaoDebito.UseVisualStyleBackColor = true;
            this.rdbCartaoDebito.CheckedChanged += new System.EventHandler(this.rdbCartaoDebito_CheckedChanged);
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(12, 76);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(67, 17);
            this.rdbDinheiro.TabIndex = 2;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            this.rdbDinheiro.CheckedChanged += new System.EventHandler(this.rdbDinheiro_CheckedChanged);
            // 
            // rdbPix
            // 
            this.rdbPix.AutoSize = true;
            this.rdbPix.Checked = true;
            this.rdbPix.Location = new System.Drawing.Point(10, 53);
            this.rdbPix.Name = "rdbPix";
            this.rdbPix.Size = new System.Drawing.Size(41, 17);
            this.rdbPix.TabIndex = 1;
            this.rdbPix.TabStop = true;
            this.rdbPix.Text = "Pix";
            this.rdbPix.UseVisualStyleBackColor = true;
            this.rdbPix.CheckedChanged += new System.EventHandler(this.rdbPix_CheckedChanged);
            // 
            // lblSlecionePagamento
            // 
            this.lblSlecionePagamento.AutoSize = true;
            this.lblSlecionePagamento.Location = new System.Drawing.Point(9, 27);
            this.lblSlecionePagamento.Name = "lblSlecionePagamento";
            this.lblSlecionePagamento.Size = new System.Drawing.Size(196, 13);
            this.lblSlecionePagamento.TabIndex = 0;
            this.lblSlecionePagamento.Text = "Selecione abaixo a forma de pagamento:";
            // 
            // Frm_ContaPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 285);
            this.Controls.Add(this.gpbContaPagar);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_ContaPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contas a Pagar";
            this.gpbContaPagar.ResumeLayout(false);
            this.gpbContaPagar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gpbFormaPagamento.ResumeLayout(false);
            this.gpbFormaPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbContaPagar;
        private System.Windows.Forms.Label lblDataLanca;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDataFecha;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtValorPaga;
        private System.Windows.Forms.TextBox txtDataVenci;
        private System.Windows.Forms.TextBox txtDataLanca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblValorPaga;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblSelecioneCompra;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelecioneCompra;
        private System.Windows.Forms.GroupBox gpbFormaPagamento;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblParcelamento;
        private System.Windows.Forms.ComboBox cmbParcelamento;
        private System.Windows.Forms.RadioButton rdbCartaoCredito;
        private System.Windows.Forms.RadioButton rdbCartaoDebito;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbPix;
        private System.Windows.Forms.Label lblSlecionePagamento;
        private System.Windows.Forms.Label lblSelecioneForne;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.TextBox txtFornecedor;
    }
}