namespace SistemaComercio.Gui
{
    partial class Frm_Compra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Compra));
            this.gpbDadosOperacionais = new System.Windows.Forms.GroupBox();
            this.lblRespostaSituacao = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.lblSituacao = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblSelecionarProduto = new System.Windows.Forms.Label();
            this.lblExemplo = new System.Windows.Forms.Label();
            this.dataGridViewCompra = new System.Windows.Forms.DataGridView();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.cmbSelecioneProduto = new System.Windows.Forms.ComboBox();
            this.gpbConsulta = new System.Windows.Forms.GroupBox();
            this.rdbForne = new System.Windows.Forms.RadioButton();
            this.rdbPeriodo = new System.Windows.Forms.RadioButton();
            this.lblConsulta = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSelecioneCompra = new System.Windows.Forms.TextBox();
            this.tbcCompra = new System.Windows.Forms.TabControl();
            this.tbpLancarCompra = new System.Windows.Forms.TabPage();
            this.txtQuant = new System.Windows.Forms.TextBox();
            this.txtTotalCima = new System.Windows.Forms.TextBox();
            this.lblTotalCima = new System.Windows.Forms.Label();
            this.tbpCancelarCompra = new System.Windows.Forms.TabPage();
            this.txtTotalCimaCancel = new System.Windows.Forms.TextBox();
            this.lblTotalCimaCancel = new System.Windows.Forms.Label();
            this.cmbSelecioneCancel = new System.Windows.Forms.ComboBox();
            this.txtPrecoCancel = new System.Windows.Forms.TextBox();
            this.lblPrecoCancel = new System.Windows.Forms.Label();
            this.cmbQUantidadeCancel = new System.Windows.Forms.ComboBox();
            this.lblQuantidadeCancel = new System.Windows.Forms.Label();
            this.lblExemploCancel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnLimparCancel = new System.Windows.Forms.Button();
            this.btnCancelarCompra = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbDadosOperacionais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).BeginInit();
            this.gpbConsulta.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tbcCompra.SuspendLayout();
            this.tbpLancarCompra.SuspendLayout();
            this.tbpCancelarCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosOperacionais
            // 
            this.gpbDadosOperacionais.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbDadosOperacionais.Controls.Add(this.lblRespostaSituacao);
            this.gpbDadosOperacionais.Controls.Add(this.txtTotal);
            this.gpbDadosOperacionais.Controls.Add(this.lblTotal);
            this.gpbDadosOperacionais.Controls.Add(this.txtHora);
            this.gpbDadosOperacionais.Controls.Add(this.lblSituacao);
            this.gpbDadosOperacionais.Controls.Add(this.txtData);
            this.gpbDadosOperacionais.Controls.Add(this.lblHora);
            this.gpbDadosOperacionais.Controls.Add(this.lblData);
            this.gpbDadosOperacionais.Location = new System.Drawing.Point(14, 400);
            this.gpbDadosOperacionais.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbDadosOperacionais.Name = "gpbDadosOperacionais";
            this.gpbDadosOperacionais.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbDadosOperacionais.Size = new System.Drawing.Size(492, 91);
            this.gpbDadosOperacionais.TabIndex = 0;
            this.gpbDadosOperacionais.TabStop = false;
            this.gpbDadosOperacionais.Text = "Dados Operacionais";
            // 
            // lblRespostaSituacao
            // 
            this.lblRespostaSituacao.AutoSize = true;
            this.lblRespostaSituacao.Location = new System.Drawing.Point(64, 56);
            this.lblRespostaSituacao.Name = "lblRespostaSituacao";
            this.lblRespostaSituacao.Size = new System.Drawing.Size(0, 13);
            this.lblRespostaSituacao.TabIndex = 19;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(310, 53);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(174, 21);
            this.txtTotal.TabIndex = 4;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(273, 56);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Total:";
            // 
            // txtHora
            // 
            this.txtHora.Enabled = false;
            this.txtHora.Location = new System.Drawing.Point(310, 24);
            this.txtHora.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(174, 21);
            this.txtHora.TabIndex = 3;
            // 
            // lblSituacao
            // 
            this.lblSituacao.AutoSize = true;
            this.lblSituacao.Location = new System.Drawing.Point(7, 56);
            this.lblSituacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSituacao.Name = "lblSituacao";
            this.lblSituacao.Size = new System.Drawing.Size(50, 13);
            this.lblSituacao.TabIndex = 5;
            this.lblSituacao.Text = "Situação:";
            // 
            // txtData
            // 
            this.txtData.Enabled = false;
            this.txtData.Location = new System.Drawing.Point(42, 24);
            this.txtData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(212, 21);
            this.txtData.TabIndex = 2;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(273, 27);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(34, 13);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "Hora:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(7, 27);
            this.lblData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(32, 13);
            this.lblData.TabIndex = 0;
            this.lblData.Text = "Data:";
            // 
            // lblSelecionarProduto
            // 
            this.lblSelecionarProduto.AutoSize = true;
            this.lblSelecionarProduto.Location = new System.Drawing.Point(7, 14);
            this.lblSelecionarProduto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelecionarProduto.Name = "lblSelecionarProduto";
            this.lblSelecionarProduto.Size = new System.Drawing.Size(198, 13);
            this.lblSelecionarProduto.TabIndex = 3;
            this.lblSelecionarProduto.Text = "Selecione o produto que deseja comprar:";
            // 
            // lblExemplo
            // 
            this.lblExemplo.AutoSize = true;
            this.lblExemplo.Location = new System.Drawing.Point(406, 33);
            this.lblExemplo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExemplo.Name = "lblExemplo";
            this.lblExemplo.Size = new System.Drawing.Size(74, 13);
            this.lblExemplo.TabIndex = 5;
            this.lblExemplo.Text = "Ex: Xbox 360";
            // 
            // dataGridViewCompra
            // 
            this.dataGridViewCompra.AllowUserToAddRows = false;
            this.dataGridViewCompra.AllowUserToDeleteRows = false;
            this.dataGridViewCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompra.Location = new System.Drawing.Point(16, 243);
            this.dataGridViewCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataGridViewCompra.Name = "dataGridViewCompra";
            this.dataGridViewCompra.ReadOnly = true;
            this.dataGridViewCompra.RowHeadersVisible = false;
            this.dataGridViewCompra.Size = new System.Drawing.Size(491, 156);
            this.dataGridViewCompra.TabIndex = 7;
            this.dataGridViewCompra.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.FormattingRows);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(217, 59);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(76, 13);
            this.lblPreco.TabIndex = 8;
            this.lblPreco.Text = "Preço unitário:";
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(7, 59);
            this.lblQuant.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(64, 13);
            this.lblQuant.TabIndex = 9;
            this.lblQuant.Text = "Quantidade:";
            // 
            // txtPreco
            // 
            this.txtPreco.Enabled = false;
            this.txtPreco.Location = new System.Drawing.Point(291, 56);
            this.txtPreco.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(186, 21);
            this.txtPreco.TabIndex = 7;
            // 
            // cmbSelecioneProduto
            // 
            this.cmbSelecioneProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneProduto.FormattingEnabled = true;
            this.cmbSelecioneProduto.Location = new System.Drawing.Point(10, 30);
            this.cmbSelecioneProduto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbSelecioneProduto.Name = "cmbSelecioneProduto";
            this.cmbSelecioneProduto.Size = new System.Drawing.Size(395, 21);
            this.cmbSelecioneProduto.TabIndex = 13;
            this.cmbSelecioneProduto.SelectedIndexChanged += new System.EventHandler(this.cmbSelecioneProduto_SelectedIndexChanged);
            // 
            // gpbConsulta
            // 
            this.gpbConsulta.BackColor = System.Drawing.Color.Cornsilk;
            this.gpbConsulta.Controls.Add(this.rdbForne);
            this.gpbConsulta.Controls.Add(this.rdbPeriodo);
            this.gpbConsulta.Location = new System.Drawing.Point(17, 173);
            this.gpbConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbConsulta.Name = "gpbConsulta";
            this.gpbConsulta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbConsulta.Size = new System.Drawing.Size(126, 64);
            this.gpbConsulta.TabIndex = 13;
            this.gpbConsulta.TabStop = false;
            this.gpbConsulta.Text = "Tipo de Consulta:";
            // 
            // rdbForne
            // 
            this.rdbForne.AutoSize = true;
            this.rdbForne.Location = new System.Drawing.Point(10, 42);
            this.rdbForne.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbForne.Name = "rdbForne";
            this.rdbForne.Size = new System.Drawing.Size(79, 17);
            this.rdbForne.TabIndex = 15;
            this.rdbForne.TabStop = true;
            this.rdbForne.Text = "Fornecedor";
            this.rdbForne.UseVisualStyleBackColor = true;
            this.rdbForne.CheckedChanged += new System.EventHandler(this.RadioButtonFornecedorCheckChanged);
            // 
            // rdbPeriodo
            // 
            this.rdbPeriodo.AutoSize = true;
            this.rdbPeriodo.Location = new System.Drawing.Point(10, 19);
            this.rdbPeriodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rdbPeriodo.Name = "rdbPeriodo";
            this.rdbPeriodo.Size = new System.Drawing.Size(62, 17);
            this.rdbPeriodo.TabIndex = 14;
            this.rdbPeriodo.TabStop = true;
            this.rdbPeriodo.Text = "Período";
            this.rdbPeriodo.UseVisualStyleBackColor = true;
            this.rdbPeriodo.CheckedChanged += new System.EventHandler(this.RadioButtonPeriodoCheckChanged);
            // 
            // lblConsulta
            // 
            this.lblConsulta.AutoSize = true;
            this.lblConsulta.BackColor = System.Drawing.Color.Cornsilk;
            this.lblConsulta.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsulta.Location = new System.Drawing.Point(151, 186);
            this.lblConsulta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConsulta.Name = "lblConsulta";
            this.lblConsulta.Size = new System.Drawing.Size(360, 13);
            this.lblConsulta.TabIndex = 13;
            this.lblConsulta.Text = "Selecione a compra que deseja consultar após selecionar o tipo de consulta:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.Controls.Add(this.txtSelecioneCompra);
            this.panel1.Controls.Add(this.tbcCompra);
            this.panel1.Controls.Add(this.dataGridViewCompra);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Controls.Add(this.lblConsulta);
            this.panel1.Controls.Add(this.gpbConsulta);
            this.panel1.Location = new System.Drawing.Point(-3, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 543);
            this.panel1.TabIndex = 15;
            // 
            // txtSelecioneCompra
            // 
            this.txtSelecioneCompra.Enabled = false;
            this.txtSelecioneCompra.Location = new System.Drawing.Point(155, 202);
            this.txtSelecioneCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSelecioneCompra.Name = "txtSelecioneCompra";
            this.txtSelecioneCompra.Size = new System.Drawing.Size(247, 21);
            this.txtSelecioneCompra.TabIndex = 14;
            // 
            // tbcCompra
            // 
            this.tbcCompra.Controls.Add(this.tbpLancarCompra);
            this.tbcCompra.Controls.Add(this.tbpCancelarCompra);
            this.tbcCompra.Location = new System.Drawing.Point(15, 17);
            this.tbcCompra.Name = "tbcCompra";
            this.tbcCompra.SelectedIndex = 0;
            this.tbcCompra.Size = new System.Drawing.Size(496, 150);
            this.tbcCompra.TabIndex = 0;
            // 
            // tbpLancarCompra
            // 
            this.tbpLancarCompra.BackColor = System.Drawing.Color.Cornsilk;
            this.tbpLancarCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpLancarCompra.Controls.Add(this.txtQuant);
            this.tbpLancarCompra.Controls.Add(this.txtTotalCima);
            this.tbpLancarCompra.Controls.Add(this.lblTotalCima);
            this.tbpLancarCompra.Controls.Add(this.btnLimpar);
            this.tbpLancarCompra.Controls.Add(this.txtPreco);
            this.tbpLancarCompra.Controls.Add(this.btnComprar);
            this.tbpLancarCompra.Controls.Add(this.cmbSelecioneProduto);
            this.tbpLancarCompra.Controls.Add(this.lblSelecionarProduto);
            this.tbpLancarCompra.Controls.Add(this.lblQuant);
            this.tbpLancarCompra.Controls.Add(this.lblExemplo);
            this.tbpLancarCompra.Controls.Add(this.lblPreco);
            this.tbpLancarCompra.Location = new System.Drawing.Point(4, 22);
            this.tbpLancarCompra.Name = "tbpLancarCompra";
            this.tbpLancarCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tbpLancarCompra.Size = new System.Drawing.Size(488, 124);
            this.tbpLancarCompra.TabIndex = 0;
            this.tbpLancarCompra.Text = "Lançar Compra";
            // 
            // txtQuant
            // 
            this.txtQuant.Enabled = false;
            this.txtQuant.Location = new System.Drawing.Point(67, 56);
            this.txtQuant.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQuant.Name = "txtQuant";
            this.txtQuant.Size = new System.Drawing.Size(138, 21);
            this.txtQuant.TabIndex = 16;
            this.txtQuant.TextChanged += new System.EventHandler(this.txtQuant_TextChanged);
            // 
            // txtTotalCima
            // 
            this.txtTotalCima.Enabled = false;
            this.txtTotalCima.Location = new System.Drawing.Point(38, 88);
            this.txtTotalCima.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTotalCima.Name = "txtTotalCima";
            this.txtTotalCima.Size = new System.Drawing.Size(167, 21);
            this.txtTotalCima.TabIndex = 15;
            // 
            // lblTotalCima
            // 
            this.lblTotalCima.AutoSize = true;
            this.lblTotalCima.Location = new System.Drawing.Point(7, 91);
            this.lblTotalCima.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalCima.Name = "lblTotalCima";
            this.lblTotalCima.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCima.TabIndex = 14;
            this.lblTotalCima.Text = "Total:";
            // 
            // tbpCancelarCompra
            // 
            this.tbpCancelarCompra.BackColor = System.Drawing.Color.Cornsilk;
            this.tbpCancelarCompra.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpCancelarCompra.Controls.Add(this.txtTotalCimaCancel);
            this.tbpCancelarCompra.Controls.Add(this.lblTotalCimaCancel);
            this.tbpCancelarCompra.Controls.Add(this.btnLimparCancel);
            this.tbpCancelarCompra.Controls.Add(this.cmbSelecioneCancel);
            this.tbpCancelarCompra.Controls.Add(this.txtPrecoCancel);
            this.tbpCancelarCompra.Controls.Add(this.lblPrecoCancel);
            this.tbpCancelarCompra.Controls.Add(this.cmbQUantidadeCancel);
            this.tbpCancelarCompra.Controls.Add(this.lblQuantidadeCancel);
            this.tbpCancelarCompra.Controls.Add(this.lblExemploCancel);
            this.tbpCancelarCompra.Controls.Add(this.btnCancelarCompra);
            this.tbpCancelarCompra.Controls.Add(this.label1);
            this.tbpCancelarCompra.Location = new System.Drawing.Point(4, 22);
            this.tbpCancelarCompra.Name = "tbpCancelarCompra";
            this.tbpCancelarCompra.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCancelarCompra.Size = new System.Drawing.Size(488, 124);
            this.tbpCancelarCompra.TabIndex = 1;
            this.tbpCancelarCompra.Text = "Cancelar Compra";
            // 
            // txtTotalCimaCancel
            // 
            this.txtTotalCimaCancel.Enabled = false;
            this.txtTotalCimaCancel.Location = new System.Drawing.Point(38, 88);
            this.txtTotalCimaCancel.Name = "txtTotalCimaCancel";
            this.txtTotalCimaCancel.Size = new System.Drawing.Size(154, 21);
            this.txtTotalCimaCancel.TabIndex = 20;
            // 
            // lblTotalCimaCancel
            // 
            this.lblTotalCimaCancel.AutoSize = true;
            this.lblTotalCimaCancel.Location = new System.Drawing.Point(7, 91);
            this.lblTotalCimaCancel.Name = "lblTotalCimaCancel";
            this.lblTotalCimaCancel.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCimaCancel.TabIndex = 19;
            this.lblTotalCimaCancel.Text = "Total:";
            // 
            // cmbSelecioneCancel
            // 
            this.cmbSelecioneCancel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelecioneCancel.FormattingEnabled = true;
            this.cmbSelecioneCancel.Location = new System.Drawing.Point(10, 29);
            this.cmbSelecioneCancel.Name = "cmbSelecioneCancel";
            this.cmbSelecioneCancel.Size = new System.Drawing.Size(395, 21);
            this.cmbSelecioneCancel.TabIndex = 12;
            this.cmbSelecioneCancel.SelectedIndexChanged += new System.EventHandler(this.cmbSelecioneCancel_SelectedIndexChanged);
            // 
            // txtPrecoCancel
            // 
            this.txtPrecoCancel.Enabled = false;
            this.txtPrecoCancel.Location = new System.Drawing.Point(298, 56);
            this.txtPrecoCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPrecoCancel.Name = "txtPrecoCancel";
            this.txtPrecoCancel.Size = new System.Drawing.Size(182, 21);
            this.txtPrecoCancel.TabIndex = 7;
            // 
            // lblPrecoCancel
            // 
            this.lblPrecoCancel.AutoSize = true;
            this.lblPrecoCancel.Location = new System.Drawing.Point(219, 59);
            this.lblPrecoCancel.Name = "lblPrecoCancel";
            this.lblPrecoCancel.Size = new System.Drawing.Size(79, 13);
            this.lblPrecoCancel.TabIndex = 17;
            this.lblPrecoCancel.Text = "Preço Unitário:";
            // 
            // cmbQUantidadeCancel
            // 
            this.cmbQUantidadeCancel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQUantidadeCancel.FormattingEnabled = true;
            this.cmbQUantidadeCancel.Location = new System.Drawing.Point(77, 56);
            this.cmbQUantidadeCancel.Name = "cmbQUantidadeCancel";
            this.cmbQUantidadeCancel.Size = new System.Drawing.Size(136, 21);
            this.cmbQUantidadeCancel.TabIndex = 16;
            this.cmbQUantidadeCancel.SelectedIndexChanged += new System.EventHandler(this.cmbQUantidadeCancel_SelectedIndexChanged);
            // 
            // lblQuantidadeCancel
            // 
            this.lblQuantidadeCancel.AutoSize = true;
            this.lblQuantidadeCancel.Location = new System.Drawing.Point(7, 59);
            this.lblQuantidadeCancel.Name = "lblQuantidadeCancel";
            this.lblQuantidadeCancel.Size = new System.Drawing.Size(64, 13);
            this.lblQuantidadeCancel.TabIndex = 15;
            this.lblQuantidadeCancel.Text = "Quantidade:";
            // 
            // lblExemploCancel
            // 
            this.lblExemploCancel.AutoSize = true;
            this.lblExemploCancel.Location = new System.Drawing.Point(406, 32);
            this.lblExemploCancel.Name = "lblExemploCancel";
            this.lblExemploCancel.Size = new System.Drawing.Size(74, 13);
            this.lblExemploCancel.TabIndex = 13;
            this.lblExemploCancel.Text = "Ex: Xbox 360";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o id da compra que deseja cancelar:";
            // 
            // btnSair
            // 
            this.btnSair.Image = global::SistemaComercio.Properties.Resources.sair;
            this.btnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.Location = new System.Drawing.Point(420, 497);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.ClickSair);
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Image = global::SistemaComercio.Properties.Resources.trade_report_reports_documents_2351;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(14, 497);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(126, 23);
            this.btnRelatorio.TabIndex = 1;
            this.btnRelatorio.Text = "        Emitir Relatório";
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.ClickEmitirRelatorio);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(346, 88);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 23);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "    Limpar Campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.ClickLimparCamposLancar);
            // 
            // btnComprar
            // 
            this.btnComprar.Image = global::SistemaComercio.Properties.Resources.adicionar;
            this.btnComprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnComprar.Location = new System.Drawing.Point(220, 88);
            this.btnComprar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(118, 23);
            this.btnComprar.TabIndex = 10;
            this.btnComprar.Text = "    Lançar Compra";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.ClickLançarCompra);
            // 
            // btnLimparCancel
            // 
            this.btnLimparCancel.Image = global::SistemaComercio.Properties.Resources.limpar;
            this.btnLimparCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimparCancel.Location = new System.Drawing.Point(340, 88);
            this.btnLimparCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLimparCancel.Name = "btnLimparCancel";
            this.btnLimparCancel.Size = new System.Drawing.Size(118, 23);
            this.btnLimparCancel.TabIndex = 18;
            this.btnLimparCancel.Text = "     Limpar Campos";
            this.btnLimparCancel.UseVisualStyleBackColor = true;
            this.btnLimparCancel.Click += new System.EventHandler(this.ClickLimparCamposDel);
            // 
            // btnCancelarCompra
            // 
            this.btnCancelarCompra.Image = global::SistemaComercio.Properties.Resources.lixo;
            this.btnCancelarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarCompra.Location = new System.Drawing.Point(214, 88);
            this.btnCancelarCompra.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelarCompra.Name = "btnCancelarCompra";
            this.btnCancelarCompra.Size = new System.Drawing.Size(118, 23);
            this.btnCancelarCompra.TabIndex = 11;
            this.btnCancelarCompra.Text = "     Cancelar Compra";
            this.btnCancelarCompra.UseVisualStyleBackColor = true;
            this.btnCancelarCompra.Click += new System.EventHandler(this.ClickCancelarCompra);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Image = global::SistemaComercio.Properties.Resources.lupa;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(409, 202);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(98, 23);
            this.btnConsultar.TabIndex = 14;
            this.btnConsultar.Text = "   Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.ClickConsultar);
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 532);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelatorio);
            this.Controls.Add(this.gpbDadosOperacionais);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Mongolian Baiti", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Frm_Compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.gpbDadosOperacionais.ResumeLayout(false);
            this.gpbDadosOperacionais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompra)).EndInit();
            this.gpbConsulta.ResumeLayout(false);
            this.gpbConsulta.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tbcCompra.ResumeLayout(false);
            this.tbpLancarCompra.ResumeLayout(false);
            this.tbpLancarCompra.PerformLayout();
            this.tbpCancelarCompra.ResumeLayout(false);
            this.tbpCancelarCompra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosOperacionais;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Label lblSituacao;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblSelecionarProduto;
        private System.Windows.Forms.Label lblExemplo;
        private System.Windows.Forms.DataGridView dataGridViewCompra;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnCancelarCompra;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox gpbConsulta;
        private System.Windows.Forms.RadioButton rdbForne;
        private System.Windows.Forms.RadioButton rdbPeriodo;
        private System.Windows.Forms.Label lblConsulta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSelecioneProduto;
        private System.Windows.Forms.TabControl tbcCompra;
        private System.Windows.Forms.TabPage tbpLancarCompra;
        private System.Windows.Forms.TabPage tbpCancelarCompra;
        private System.Windows.Forms.Button btnLimparCancel;
        private System.Windows.Forms.ComboBox cmbSelecioneCancel;
        private System.Windows.Forms.TextBox txtPrecoCancel;
        private System.Windows.Forms.Label lblPrecoCancel;
        private System.Windows.Forms.ComboBox cmbQUantidadeCancel;
        private System.Windows.Forms.Label lblQuantidadeCancel;
        private System.Windows.Forms.Label lblExemploCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRespostaSituacao;
        private System.Windows.Forms.TextBox txtSelecioneCompra;
        private System.Windows.Forms.TextBox txtTotalCima;
        private System.Windows.Forms.Label lblTotalCima;
        private System.Windows.Forms.TextBox txtTotalCimaCancel;
        private System.Windows.Forms.Label lblTotalCimaCancel;
        private System.Windows.Forms.TextBox txtQuant;
    }
}