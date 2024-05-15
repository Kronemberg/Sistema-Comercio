using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Data;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Produto : Form
    {
        private IProdutoPort service;
        private IFornecedorPort serviceForne;
        private DataTable dt = new DataTable();
        private Produto prod = null;
        private Frm_Principal formprincipal;

        public Frm_Produto(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formprincipal = frm_Principal;
            UpdateProductsInDataGrid();
            AddComboBoxFornecedor();
            dataGridViewProd.ReadOnly = true;
        }

        //vai usar ainda?
        private void Frm_Produto_Load(object sender, EventArgs e)
        {
            dataGridViewProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProd.DataSource = service.GetAllProduto();
        }

        #region ComboBox
        private void AddComboBoxFornecedor()
        {
            var fornecedores = serviceForne.GetAllFornecedor();
            foreach (var fornecedor in fornecedores)
            {
                this.cmbNomeForne.Items.AddRange(new object[] {
                fornecedor.Nome.ToString()
                });
            }
        }

        #endregion

        #region DataGridView
        private void UpdateProductsInDataGrid()
        {
            service = new ProdutoService();
            serviceForne = new FornecedorService();

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Qtd Estoque", typeof(string));
            dt.Columns.Add("Preço", typeof(string));
            dt.Columns.Add("Unidade", typeof(string));
            dt.Columns.Add("Id_Fornecedor", typeof(string));
            dt.Columns.Add("Fornecedor", typeof(string));

            var produtos = service.GetAllProduto();

            foreach (var produto in produtos)
            {
                dt.Rows.Add(new object[]
                {
                    produto.Id,
                    produto.Nome,
                    produto.Quantidade_Estoque,
                    produto.Preco,
                    produto.Unidade,
                    produto.Id_Fornecedor,
                    produto.Fornecedor.Nome
                });

            }

            formprincipal.GetCount();
            dataGridViewProd.DataSource = dt;
        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewProd.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProd.Columns["Qtd Estoque"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProd.Columns["Preço"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProd.Columns["Unidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProd.Columns["Id_Fornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewProd.Columns["Fornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewProd.Columns)
            {
                switch (coluna.Name)
                {
                    case "Excluir":
                        //coluna.DisplayIndex = 1; se quiser mudar a posição 
                        coluna.Width = 30;
                        break;
                    case "Editar":
                        coluna.Width = 30;
                        break;
                    case "Id":
                        coluna.Width = 30;
                        break;
                    case "Nome":
                        coluna.Width = 115;
                        break;
                    case "Qtd Estoque":
                        coluna.Width = 60;
                        break;
                    case "Preço":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 60;
                        break;
                    case "Unidade":
                        coluna.Width = 50;
                        break;
                    case "Id_Fornecedor":
                        coluna.Width = 100;
                        break;
                    case "Fornecedor":
                        coluna.Width = 115;
                        break;
                }
            }
        } //DataBindingComplete

        private void FormattingCollunms(object sender, DataGridViewCellEventArgs e)
        {
            //quando clica em editar pega ele
            if (dataGridViewProd.Columns[e.ColumnIndex] == dataGridViewProd.Columns["Editar"])
            {
                //preciso pegar o id dele pra saber qm é
                var id = dataGridViewProd.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                prod = service.GetByIdProduto(Convert.ToInt32(id));

                txtNome.Text = prod.Nome;
                txtEstoque.Text = prod.Quantidade_Estoque.ToString();
                txtPreco.Text = prod.Preco.ToString();
                cmbUnidade.Text = prod.Unidade;
                cmbNomeForne.Text = prod.Fornecedor.Nome;

                btnSalvar.Enabled = true;
                btnCadastrar.Enabled = false;
            }

            //quando clica em excluir pega ele
            if (dataGridViewProd.Columns[e.ColumnIndex] == dataGridViewProd.Columns["Excluir"])
            {
                if (MessageBox.Show("Deseja mesmo remover este produto?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //preciso pegar o id dele pra saber qm é
                    var id = Convert.ToInt32(dataGridViewProd.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    RemoveProduct(id);
                }
            }
        } //CellContentClick

        private void FormatttingMensageRows(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //e -> PEGA TODA A LINHA 
            dataGridViewProd.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Excluir Produto";
            dataGridViewProd.Rows[e.RowIndex].Cells["Editar"].ToolTipText = "Editar Produto";

        } //CellFormatting

        #endregion

        #region Clicks Botões Form

        private void ClickLimpar(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CLickPesquisar(object sender, EventArgs e)
        {
            UpdateProductsInDataGrid();
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", "Nome", txtPesquisar.Text);
            dataGridViewProd.DataSource = dt;
        }

        private void ClickSalvar(object sender, EventArgs e)
        {

            var nomeForne = cmbNomeForne.Text; //pego o nome marcado pelo usuario
            var umForne = serviceForne.GetByNomeFornecedor(nomeForne); //pego no banco o fornecedor q tem esse nome

            var produto = new Produto()
            {
                Id_Fornecedor = umForne.Id,
                Id = prod.Id,
                Nome = txtNome.Text,
                Quantidade_Estoque = Convert.ToInt32(txtEstoque.Text),
                Preco = Convert.ToDouble(txtPreco.Text),
                Unidade = cmbUnidade.Text,
            };

            try
            {
                if (ValidarCampos())
                {
                    service.UpdateProduto(produto);
                    UpdateProductsInDataGrid(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
                    MessageBox.Show("Produto editado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCadastrar(object sender, EventArgs e)
        {
            var nomeForne = cmbNomeForne.Text; //pego o nome marcado pelo usuario
            var umForne = serviceForne.GetByNomeFornecedor(nomeForne); //pego no banco o fornecedor q tem esse nome

            var produto = new Produto()
            {
                Id_Fornecedor = umForne.Id,
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPreco.Text),
                Unidade = cmbUnidade.Text,
            };

            try
            {
                if (ValidarCampos())
                {
                    service.AddProduto(produto);
                    UpdateProductsInDataGrid(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
                    MessageBox.Show("Produto cadastrado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        #endregion

        #region Funções

        private void RemoveProduct(int id)
        {
            prod = service.GetByIdProduto(id);
            try
            {
                service.DelProduto(prod);
                UpdateProductsInDataGrid();
                MessageBox.Show("Produto excluido!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LimparCampos()
        {
            txtNome.Clear();
            txtEstoque.Clear();
            txtPreco.Clear();
            cmbUnidade.SelectedIndex = -1;
            cmbNomeForne.SelectedIndex = -1;
            btnSalvar.Enabled = false;
            btnCadastrar.Enabled = true;
        }

        bool ValidarCampos()
        {
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(cmbUnidade.Text) || String.IsNullOrEmpty(txtPreco.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        #endregion

    }
}