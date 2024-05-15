namespace SistemaComercio.Gui
{
    partial class Frm_Venda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Venda));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSelecioneVenda = new System.Windows.Forms.TextBox();
            this.tbcVenda = new System.Windows.Forms.TabControl();
            this.tbpLancarVenda = new System.Windows.Forms.TabPage();
            this.cmbSelecioneCli = new System.Windows.Forms.ComboBox();
            this.lblSelecioneCli = new System.Windows.Forms.Label();
            this.txtTotalCima = new System.Windows.Forms.TextBox();
            this.lblTotalCima = new System.Windows.Forms.Label();
            this.btnLimparCampos = new System.Windows.Forms.Button();
            this.cmbQuantidade = new System.Windows.Forms.ComboBox();
            this.btnLancarVenda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cmbSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.lblPrecoUnitario = new System.Windows.Forms.Label();
            this.tbpCancelarVenda = new System.Windows.Forms.TabPage();
            this.txtTotalCimaCancel = new System.Windows.Forms.TextBox();
            this.lblTotalCimaCancel = new System.Windows.Forms.Label();
            this.btnLimparCancelar = new System.Windows.Forms.Button();
            this.txtPrecoCancel = new System.Windows.Forms.TextBox();
            this.lblPrecoCancelar = new System.Windows.Forms.Label();
            this.cmbQuantiCancelar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbSelecioneCancelamento = new System.Windows.Forms.ComboBox();
            this.lblExemploCancelar = new System.Windows.Forms.Label();
            this.lblSlecioneCancelamento = new System.Windows.Forms.Label();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEmitirRelatorio = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblRespostaSituacao = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.dataGridViewVenda = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.tbcVenda.SuspendLayout();
            this.tbpLancarVenda.SuspendLayout();
            this.tbpCancelarVenda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.txtSelecioneVenda);
            this.panel1.Controls.Add(this.tbcVenda);
            this.panel1.Controls.Add(this.btnSair);
            this.panel1.Controls.Add(this.btnEmitirRelatorio);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.dataGridViewVenda);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Location = new System.Drawing.Point(-7, -7);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 545);
            this.panel1.TabIndex = 0;
            // 
            // txtSelecioneVenda
            // 
            this.txtSelecioneVenda.Enabled = false;
            this.txtSelecioneVenda.Location = new System.Drawing.Point(162, 204);
            this.txtSelecioneVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelecioneVenda.Name = "txtSelecioneVenda";
            this.txtSelecioneVenda.Size = new System.Drawing.Size(246, 21);
            this.txtSelecioneVenda.TabIndex = 10;
            // 
            // tbcVenda
            // 
            this.tbcVenda.Controls.Add(this.tbpLancarVenda);
            this.tbcVenda.Controls.Add(this.tbpCancelarVenda);
            this.tbcVenda.Location = new System.Drawing.Point(19, 19);
            this.tbcVenda.Name = "tbcVenda";
            this.tbcVenda.SelectedIndex = 0;
            this.tbcVenda.Size = new System.Drawing.Size(493, 149);
            this.tbcVenda.TabIndex = 14;
            // 
            // tbpLancarVenda
            // 
            this.tbpLancarVenda.BackColor = System.Drawing.Color.MistyRose;
            this.tbpLancarVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLancarVenda.Controls.Add(this.cmbSelecioneCli);
            this.tbpLancarVenda.Controls.Add(this.lblSelecioneCli);
            this.tbpLancarVenda.Controls.Add(this.txtTotalCima);
            this.tbpLancarVenda.Controls.Add(this.lblTotalCima);
            this.tbpLancarVenda.Controls.Add(this.btnLimparCampos);
            this.tbpLancarVenda.Controls.Add(this.cmbQuantidade);
            this.tbpLancarVenda.Controls.Add(this.btnLancarVenda);
            this.tbpLancarVenda.Controls.Add(this.label1);
            this.tbpLancarVenda.Controls.Add(this.txtPreco);
            this.tbpLancarVenda.Controls.Add(this.cmbSelecioneProduto);
            this.tbpLancarVenda.Controls.Add(this.lblQuantidade);
            this.tbpLancarVenda.Controls.Add(this.lblPrecoUnitario);
            this.tbpLancarVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpLancarVenda.Name = "tbpLancarVenda";
            this.tbpLancarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLancarVenda.Size = new System.Drawing.Size(485, 123);
            this.tbpLancarVenda.TabIndex = 0;
            this.tbpLancarVenda.Text = "Lançar Venda";
            // 
            // cmbSelecioneCli
            // 
            this.cmbSelecioneCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneCli.FormattingEnabled = true;
            this.cmbSelecioneCli.Location = new System.Drawing.Point(262, 28);
            this.cmbSelecioneCli.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecioneCli.Name = "cmbSelecioneCli";
            this.cmbSelecioneCli.Size = new System.Drawing.Size(212, 21);
            this.cmbSelecioneCli.TabIndex = 13;
            // 
            // lblSelecioneCli
            // 
            this.lblSelecioneCli.AutoSize = true;
            this.lblSelecioneCli.Location = new System.Drawing.Point(259, 12);
            this.lblSelecioneCli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecioneCli.Name = "lblSelecioneCli";
            this.lblSelecioneCli.Size = new System.Drawing.Size(196, 13);
            this.lblSelecioneCli.TabIndex = 12;
            this.lblSelecioneCli.Text = "Selecione o cliente para realizar a venda:";
            // 
            // txtTotalCima
            // 
            this.txtTotalCima.Enabled = false;
            this.txtTotalCima.Location = new System.Drawing.Point(38, 87);
            this.txtTotalCima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalCima.Name = "txtTotalCima";
            this.txtTotalCima.Size = new System.Drawing.Size(160, 21);
            this.txtTotalCima.TabIndex = 11;
            // 
            // lblTotalCima
            // 
            this.lblTotalCima.AutoSize = true;
            this.lblTotalCima.Location = new System.Drawing.Point(7, 90);
            this.lblTotalCima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCima.Name = "lblTotalCima";
            this.lblTotalCima.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCima.TabIndex = 10;
            this.lblTotalCima.Text = "Total:";
            // 
            // btnLimparCampos
            // 
            this.btnLimparCampos.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimparCampos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCampos.Location = new System.Drawing.Point(356, 85);
            this.btnLimparCampos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparCampos.Name = "btnLimparCampos";
            this.btnLimparCampos.Size = new System.Drawing.Size(118, 23);
            this.btnLimparCampos.TabIndex = 9;
            this.btnLimparCampos.Text = "     Limpar Campos";
            this.btnLimparCampos.UseVisualStyleBackColor = true;
            this.btnLimparCampos.Click += new System.EventHandler(this.ClickLimparCamposLancar);
            // 
            // cmbQuantidade
            // 
            this.cmbQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantidade.FormattingEnabled = true;
            this.cmbQuantidade.Location = new System.Drawing.Point(70, 55);
            this.cmbQuantidade.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbQuantidade.Name = "cmbQuantidade";
            this.cmbQuantidade.Size = new System.Drawing.Size(167, 21);
            this.cmbQuantidade.TabIndex = 5;
            this.cmbQuantidade.SelectedIndexChanged += new System.EventHandler(this.cmbQuantidade_SelectedIndexChanged_1);
            // 
            // btnLancarVenda
            // 
            this.btnLancarVenda.Image = global::SistemaComercio.Properties.Resources.adicionar;
            this.btnLancarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancarVenda.Location = new System.Drawing.Point(219, 85);
            this.btnLancarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLancarVenda.Name = "btnLancarVenda";
            this.btnLancarVenda.Size = new System.Drawing.Size(118, 23);
            this.btnLancarVenda.TabIndex = 7;
            this.btnLancarVenda.Text = "Lançar Venda";
            this.btnLancarVenda.UseVisualStyleBackColor = true;
            this.btnLancarVenda.Click += new System.EventHandler(this.ClickLancarVenda);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o produto que deseja vender:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(322, 55);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(152, 21);
            this.txtPreco.TabIndex = 1;
            // 
            // cmbSelecioneProduto
            // 
            this.cmbSelecioneProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneProduto.FormattingEnabled = true;
            this.cmbSelecioneProduto.Location = new System.Drawing.Point(10, 28);
            this.cmbSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecioneProduto.Name = "cmbSelecioneProduto";
            this.cmbSelecioneProduto.Size = new System.Drawing.Size(227, 21);
            this.cmbSelecioneProduto.TabIndex = 3;
            this.cmbSelecioneProduto.SelectedIndexChanged += new System.EventHandler(this.cmbSelecioneProduto_SelectedIndexChanged);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(7, 58);
            this.lblQuantidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(64, 13);
            this.lblQuantidade.TabIndex = 4;
            this.lblQuantidade.Text = "Quantidade:";
            // 
            // lblPrecoUnitario
            // 
            this.lblPrecoUnitario.AutoSize = true;
            this.lblPrecoUnitario.Location = new System.Drawing.Point(245, 58);
            this.lblPrecoUnitario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoUnitario.Name = "lblPrecoUnitario";
            this.lblPrecoUnitario.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoUnitario.TabIndex = 6;
            this.lblPrecoUnitario.Text = "Preço Unitário:";
            // 
            // tbpCancelarVenda
            // 
            this.tbpCancelarVenda.BackColor = System.Drawing.Color.MistyRose;
            this.tbpCancelarVenda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpCancelarVenda.Controls.Add(this.txtTotalCimaCancel);
            this.tbpCancelarVenda.Controls.Add(this.lblTotalCimaCancel);
            this.tbpCancelarVenda.Controls.Add(this.btnLimparCancelar);
            this.tbpCancelarVenda.Controls.Add(this.txtPrecoCancel);
            this.tbpCancelarVenda.Controls.Add(this.lblPrecoCancelar);
            this.tbpCancelarVenda.Controls.Add(this.cmbQuantiCancelar);
            this.tbpCancelarVenda.Controls.Add(this.label3);
            this.tbpCancelarVenda.Controls.Add(this.cmbSelecioneCancelamento);
            this.tbpCancelarVenda.Controls.Add(this.lblExemploCancelar);
            this.tbpCancelarVenda.Controls.Add(this.lblSlecioneCancelamento);
            this.tbpCancelarVenda.Controls.Add(this.btnCancelarVenda);
            this.tbpCancelarVenda.Location = new System.Drawing.Point(4, 22);
            this.tbpCancelarVenda.Name = "tbpCancelarVenda";
            this.tbpCancelarVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCancelarVenda.Size = new System.Drawing.Size(485, 123);
            this.tbpCancelarVenda.TabIndex = 1;
            this.tbpCancelarVenda.Text = "Cancelar Venda";
            // 
            // txtTotalCimaCancel
            // 
            this.txtTotalCimaCancel.Enabled = false;
            this.txtTotalCimaCancel.Location = new System.Drawing.Point(38, 87);
            this.txtTotalCimaCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalCimaCancel.Name = "txtTotalCimaCancel";
            this.txtTotalCimaCancel.Size = new System.Drawing.Size(158, 21);
            this.txtTotalCimaCancel.TabIndex = 19;
            // 
            // lblTotalCimaCancel
            // 
            this.lblTotalCimaCancel.AutoSize = true;
            this.lblTotalCimaCancel.Location = new System.Drawing.Point(6, 90);
            this.lblTotalCimaCancel.Name = "lblTotalCimaCancel";
            this.lblTotalCimaCancel.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCimaCancel.TabIndex = 18;
            this.lblTotalCimaCancel.Text = "Total:";
            // 
            // btnLimparCancelar
            // 
            this.btnLimparCancelar.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimparCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCancelar.Location = new System.Drawing.Point(356, 87);
            this.btnLimparCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparCancelar.Name = "btnLimparCancelar";
            this.btnLimparCancelar.Size = new System.Drawing.Size(118, 23);
            this.btnLimparCancelar.TabIndex = 17;
            this.btnLimparCancelar.Text = "     Limpar Campos";
            this.btnLimparCancelar.UseVisualStyleBackColor = true;
            this.btnLimparCancelar.Click += new System.EventHandler(this.ClickLimparCamposCancel);
            // 
            // txtPrecoCancel
            // 
            this.txtPrecoCancel.Enabled = false;
            this.txtPrecoCancel.Location = new System.Drawing.Point(305, 58);
            this.txtPrecoCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecoCancel.Name = "txtPrecoCancel";
            this.txtPrecoCancel.Size = new System.Drawing.Size(169, 21);
            this.txtPrecoCancel.TabIndex = 16;
            // 
            // lblPrecoCancelar
            // 
            this.lblPrecoCancelar.AutoSize = true;
            this.lblPrecoCancelar.Location = new System.Drawing.Point(225, 61);
            this.lblPrecoCancelar.Name = "lblPrecoCancelar";
            this.lblPrecoCancelar.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoCancelar.TabIndex = 15;
            this.lblPrecoCancelar.Text = "Preço Unitário:";
            // 
            // cmbQuantiCancelar
            // 
            this.cmbQuantiCancelar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuantiCancelar.FormattingEnabled = true;
            this.cmbQuantiCancelar.Location = new System.Drawing.Point(66, 58);
            this.cmbQuantiCancelar.Name = "cmbQuantiCancelar";
            this.cmbQuantiCancelar.Size = new System.Drawing.Size(153, 21);
            this.cmbQuantiCancelar.TabIndex = 14;
            this.cmbQuantiCancelar.SelectedIndexChanged += new System.EventHandler(this.cmbQuantiCancelar_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Quantidade:";
            // 
            // cmbSelecioneCancelamento
            // 
            this.cmbSelecioneCancelamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneCancelamento.FormattingEnabled = true;
            this.cmbSelecioneCancelamento.Location = new System.Drawing.Point(9, 32);
            this.cmbSelecioneCancelamento.Name = "cmbSelecioneCancelamento";
            this.cmbSelecioneCancelamento.Size = new System.Drawing.Size(385, 21);
            this.cmbSelecioneCancelamento.TabIndex = 10;
            this.cmbSelecioneCancelamento.SelectedIndexChanged += new System.EventHandler(this.cmbSelecioneCancelamento_SelectedIndexChanged);
            // 
            // lblExemploCancelar
            // 
            this.lblExemploCancelar.AutoSize = true;
            this.lblExemploCancelar.Location = new System.Drawing.Point(400, 35);
            this.lblExemploCancelar.Name = "lblExemploCancelar";
            this.lblExemploCancelar.Size = new System.Drawing.Size(74, 13);
            this.lblExemploCancelar.TabIndex = 11;
            this.lblExemploCancelar.Text = "Ex: Xbox 360";
            // 
            // lblSlecioneCancelamento
            // 
            this.lblSlecioneCancelamento.AutoSize = true;
            this.lblSlecioneCancelamento.Location = new System.Drawing.Point(6, 16);
            this.lblSlecioneCancelamento.Name = "lblSlecioneCancelamento";
            this.lblSlecioneCancelamento.Size = new System.Drawing.Size(236, 13);
            this.lblSlecioneCancelamento.TabIndex = 9;
            this.lblSlecioneCancelamento.Text = "Selecione o produto que deseja cancelar a venda:";
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.Image = global::SistemaComercio.Properties.Resources.lixo;
            this.btnCancelarVenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarVenda.Location = new System.Drawing.Point(219, 87);
            this.btnCancelarVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarVenda.TabIndex = 8;
            this.btnCancelarVenda.Text = "    Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.ClickCancelarVenda);
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(426, 509);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ClickSair);
            // 
            // btnEmitirRelatorio
            // 
            this.btnEmitirRelatorio.Image = global::SistemaComercio.Properties.Resources.trade_report_reports_documents_2351;
            this.btnEmitirRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitirRelatorio.Location = new System.Drawing.Point(21, 509);
            this.btnEmitirRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEmitirRelatorio.Name = "btnEmitirRelatorio";
            this.btnEmitirRelatorio.Size = new System.Drawing.Size(126, 23);
            this.btnEmitirRelatorio.TabIndex = 10;
            this.btnEmitirRelatorio.Text = "        Emitir Relatório";
            this.btnEmitirRelatorio.UseVisualStyleBackColor = true;
            this.btnEmitirRelatorio.Click += new System.EventHandler(this.ClickEmitirRelatorio);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblRespostaSituacao);
            this.groupBox3.Controls.Add(this.txtTotal);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.lblSituacao);
            this.groupBox3.Controls.Add(this.txtHora);
            this.groupBox3.Controls.Add(this.lblHora);
            this.groupBox3.Controls.Add(this.txtData);
            this.groupBox3.Controls.Add(this.lblData);
            this.groupBox3.Location = new System.Drawing.Point(21, 412);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(492, 91);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados Operacionais";
            // 
            // lblRespostaSituacao
            // 
            this.lblRespostaSituacao.AutoSize = true;
            this.lblRespostaSituacao.Location = new System.Drawing.Point(65, 58);
            this.lblRespostaSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRespostaSituacao.Name = "lblRespostaSituacao";
            this.lblRespostaSituacao.Size = new System.Drawing.Size(0, 13);
            this.lblRespostaSituacao.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(309, 55);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 21);
            this.txtTotal.TabIndex = 15;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(274, 58);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 58);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(50, 13);
            this.lblSituacao.TabIndex = 13;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(309, 26);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(174, 21);
            this.txtHora.TabIndex = 12;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(274, 29);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 11;
            this.lblHora.Text = "Hora:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(42, 26);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(212, 21);
            this.txtData.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 29);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(32, 13);
            this.lblData.TabIndex = 10;
            this.lblData.Text = "Data:";
            // 
            // dataGridViewVenda
            // 
            this.dataGridViewVenda.AllowUserToAddRows = false;
            this.dataGridViewVenda.AllowUserToDeleteRows = false;
            this.dataGridViewVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVenda.Location = new System.Drawing.Point(21, 249);
            this.dataGridViewVenda.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewVenda.Name = "dataGridViewVenda";
            this.dataGridViewVenda.ReadOnly = true;
            this.dataGridViewVenda.RowHeadersVisible = false;
            this.dataGridViewVenda.Size = new System.Drawing.Size(491, 157);
            this.dataGridViewVenda.TabIndex = 11;
            this.dataGridViewVenda.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FormattingRows);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::SistemaComercio.Properties.Resources.lupa;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(416, 204);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(96, 23);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "   Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.ClickConsultar);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione a venda que deseja consultar após selecionar o tipo de consulta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbCliente);
            this.groupBox2.Controls.Add(this.rdbPeriodo);
            this.groupBox2.Location = new System.Drawing.Point(21, 179);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(126, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de Consulta";
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(8, 41);
            this.rdbCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(58, 17);
            this.rdbCliente.TabIndex = 3;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.CheckedChanged += new System.EventHandler(this.RadioButtonClienteCheckChanged);
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Checked = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(8, 18);
            this.rdbPeriodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(62, 17);
            this.rdbPeriodo.TabIndex = 2;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            this.rdbPeriodo.CheckedChanged += new System.EventHandler(this.RadioButtonPeriodoCheckChanged);
            // 
            // Frm_Venda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 534);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_Venda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcVenda.ResumeLayout(false);
            this.tbpLancarVenda.ResumeLayout(false);
            this.tbpLancarVenda.PerformLayout();
            this.tbpCancelarVenda.ResumeLayout(false);
            this.tbpCancelarVenda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVenda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.ComboBox cmbSelecioneProduto;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.ComboBox cmbQuantidade;
        private System.Windows.Forms.Label lblPrecoUnitario;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.Button btnLancarVenda;
        private System.Windows.Forms.Button btnLimparCampos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dataGridViewVenda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEmitirRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TabControl tbcVenda;
        private System.Windows.Forms.TabPage tbpLancarVenda;
        private System.Windows.Forms.TabPage tbpCancelarVenda;
        private System.Windows.Forms.Button btnLimparCancelar;
        private System.Windows.Forms.TextBox txtPrecoCancel;
        private System.Windows.Forms.Label lblPrecoCancelar;
        private System.Windows.Forms.ComboBox cmbQuantiCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbSelecioneCancelamento;
        private System.Windows.Forms.Label lblExemploCancelar;
        private System.Windows.Forms.Label lblSlecioneCancelamento;
        private System.Windows.Forms.Label lblRespostaSituacao;
        private System.Windows.Forms.TextBox txtSelecioneVenda;
        private System.Windows.Forms.TextBox txtTotalCima;
        private System.Windows.Forms.Label lblTotalCima;
        private System.Windows.Forms.TextBox txtTotalCimaCancel;
        private System.Windows.Forms.Label lblTotalCimaCancel;
        private System.Windows.Forms.ComboBox cmbSelecioneCli;
        private System.Windows.Forms.Label lblSelecioneCli;
    }
}