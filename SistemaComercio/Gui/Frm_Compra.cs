using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Compra : Form
    {
        private IProdutoPort serviceProd;
        private ICompraPort service;
        private IItemCompraPort serviceItemC;
        private List<Produto> produtos;
        private Produto produto;
        private DataTable dt = new DataTable();
        private Compra cmp = null;
        private string columnFilter;
        private List<ItemCompra> itemCompras;
        private ItemCompra itemCompra;
        private Frm_Principal formprincipal;

        public Frm_Compra(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formprincipal = frm_Principal;
            UpdateCompraInDataGrid();
            dataGridViewCompra.ReadOnly = true;
        }

        #region ComboBox

        private void AddComboBoxCompra()
        {
            this.cmbSelecioneProduto.Items.Clear();

            foreach (var produto in produtos)
            {
                this.cmbSelecioneProduto.Items.AddRange(new object[] {
                produto.Nome.ToString()
                });
            }
        }

        private void AddComboBoxCancelarCompra()
        {
            this.cmbSelecioneCancel.Items.Clear();

            foreach (var itemCompra in itemCompras)
            {
                if (itemCompra.Compra.Situacao_Compra != "Cancelado")
                {
                    this.cmbSelecioneCancel.Items.AddRange(new object[] {
                    itemCompra.Id.ToString()
                });

                }
            }
        }

        #endregion

        #region DataGridView

        private void UpdateCompraInDataGrid()
        {
            serviceProd = new ProdutoService();
            service = new CompraService();
            serviceItemC = new ItemCompraService();

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Valor Unitario", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Id Produto", typeof(string));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Id Compra", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Situacao", typeof(string));
            dt.Columns.Add("Id Fornecedor", typeof(string));
            dt.Columns.Add("Fornecedor", typeof(string));

            itemCompras = serviceItemC.GetAllItemCompra();

            foreach (var itemCompra in itemCompras)
            {
                dt.Rows.Add(new object[]
                {
                    itemCompra.Id,
                    itemCompra.Quantidade,
                    itemCompra.Valor_Unitario,
                    itemCompra.Total_Item,
                    itemCompra.Id_Produto,
                    itemCompra.Produto.Nome,
                    itemCompra.Id_Compra,
                    itemCompra.Compra.Data,
                    itemCompra.Compra.Hora,
                    itemCompra.Compra.Situacao_Compra,
                    itemCompra.Compra.Id_Fornecedor,
                    itemCompra.Compra.Fornecedor.Nome

                });
            }
            formprincipal.GetCount();
            dataGridViewCompra.DataSource = dt;

            produtos = serviceProd.GetAllProduto();

            UpdateComboBox();
        }

        public void UpdateComboBox()
        {
            AddComboBoxCompra();
            AddComboBoxCancelarCompra();
        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewCompra.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Valor Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Id Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Id Compra"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Id Fornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCompra.Columns["Fornecedor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewCompra.Columns)
            {
                switch (coluna.Name)
                {
                    case "Id":
                        coluna.Width = 30;
                        break;
                    case "Quantidade":
                        coluna.Width = 60;
                        break;
                    case "Valor Unitario":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 55;
                        break;
                    case "Total":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 45;
                        break;
                    case "Id Produto":
                        coluna.Width = 55;
                        break;
                    case "Produto":
                        coluna.Width = 115;
                        break;
                    case "Id Compra":
                        coluna.Width = 55;
                        break;
                    case "Data":
                        coluna.Width = 100;
                        break;
                    case "Hora":
                        coluna.Width = 100;
                        break;
                    case "Situacao":
                        coluna.Width = 60;
                        break;
                    case "Id Fornecedor":
                        coluna.Width = 45;
                        break;
                    case "Fornecedor":
                        coluna.DisplayIndex = 1;
                        coluna.Width = 135;
                        break;
                }
            }
        } //DataBindingComplete


        #endregion

        #region Click Botões Form

        private void ClickEmitirRelatorio(object sender, EventArgs e)
        {
            Frm_RelatorioCompra relatorioC = new Frm_RelatorioCompra(formprincipal);
            relatorioC.Show();
        }

        private void ClickLançarCompra(object sender, EventArgs e)
        {
            //VALIDAR SE CAMPOS FORAM PREENCHIDOS
            try
            {
                //TEM Q VER ESSE Q N TA CAINDO AQUI
                if (txtQuant.Text == null || cmbSelecioneProduto.SelectedIndex == -1)
                {
                    MessageBox.Show("É necessário preencher todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CreateCompra();
                    LimparCampos();
                    MessageBox.Show("Compra Lançada!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao lançar compra!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCancelarCompra(object sender, EventArgs e)
        {
            try
            {
                itemCompra = serviceItemC.GetByIdItemCompra(Convert.ToInt32(cmbSelecioneCancel.Text));

                //verifica se escolheu o valor total d estoque do produto
                if (cmbQUantidadeCancel.Text == itemCompra.Quantidade.ToString())
                {
                    itemCompra.Compra.Situacao_Compra = "Cancelado";
                    itemCompra.Produto.Quantidade_Estoque -= Convert.ToInt32(cmbQUantidadeCancel.Text);
                    serviceItemC.UpdateItemCompra(itemCompra);
                    lblRespostaSituacao.Text = "Cancelado";
                    MessageBox.Show("Compra Cancelada!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    itemCompra.Compra.Situacao_Compra = "Alterado";
                    itemCompra.Quantidade -= Convert.ToInt32(cmbQUantidadeCancel.Text);
                    itemCompra.Produto.Quantidade_Estoque -= Convert.ToInt32(cmbQUantidadeCancel.Text);
                    serviceItemC.UpdateItemCompra(itemCompra);
                    lblRespostaSituacao.Text = "Alterado";
                    MessageBox.Show("Situação de compra alterada!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                UpdateCompraInDataGrid();
            }
            catch
            {
                MessageBox.Show("Erro ao cancelar compra!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickConsultar(object sender, EventArgs e)
        {
            PesquisaCompraFiltro();
        }

        private void ClickLimparCamposLancar(object sender, EventArgs e)
        {
            LimparCampos();
            txtData.Clear();
            txtHora.Clear();
            txtTotal.Clear();
            lblRespostaSituacao.Text = "";
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickLimparCamposDel(object sender, EventArgs e)
        {
            LimparCampos();
            txtData.Text = "";
            txtHora.Text = "";
            txtTotal.Text = "";
            lblRespostaSituacao.Text = "";
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region Funções

        private void RemoveCompra(int id)
        {
            cmp = service.GetByIdCompra(id);
            try
            {
                service.DelCompra(cmp);
                UpdateCompraInDataGrid();
                MessageBox.Show("Produto excluido!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir produto!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        void SetDadosOperacionais(Compra compra)
        {
            txtData.Text = compra.Data.ToString();
            txtHora.Text = compra.Hora.ToString();
            txtTotal.Text = "R$" + compra.Total_Compra.ToString();
            lblRespostaSituacao.Text = "Aguardando Pagamento";
        }

        private void LimparCampos()
        {
            txtPreco.Clear();
            txtTotalCima.Clear();
            txtQuant.Clear();
            cmbSelecioneProduto.SelectedIndex = -1;
            cmbQUantidadeCancel.SelectedIndex = -1;
            cmbSelecioneCancel.SelectedIndex = -1;
            txtPrecoCancel.Clear();
            txtTotalCimaCancel.Clear();
            txtQuant.Enabled = false;
            txtTotalCimaCancel.Clear();


        }

        private void PesquisaCompraFiltro()
        {
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", columnFilter, txtSelecioneCompra.Text);
            dataGridViewCompra.DataSource = dt;
        }

        private void CreateCompra()
        {
            var compra = new Compra()
            {
                Situacao_Compra = "Aguardando Pagamento",
                Total_Compra = produto.Preco * Convert.ToInt32(txtQuant.Text),
                Data = DateTime.Now.ToString("dd-MM-yyyy"),
                Hora = DateTime.Now.ToString("HH:mm:ss"),
                Id_Fornecedor = produto.Id_Fornecedor,
            };


            var itemCompra = new ItemCompra()
            {
                Compra = compra,
                Id_Produto = produto.Id,
                Quantidade = Convert.ToInt32(txtQuant.Text),
                Total_Item = compra.Total_Compra,
                Valor_Unitario = produto.Preco,
            };

            produto.Quantidade_Estoque += itemCompra.Quantidade;
            serviceProd.UpdateProduto(produto);

            serviceItemC.AddItemCompra(itemCompra);
            SetDadosOperacionais(compra);
            UpdateCompraInDataGrid();
        }

        private void RadioButtonPeriodoCheckChanged(object sender, EventArgs e)
        {
            txtSelecioneCompra.Enabled = true;
            columnFilter = "Data";
        }

        private void RadioButtonFornecedorCheckChanged(object sender, EventArgs e)
        {
            txtSelecioneCompra.Enabled = true;
            columnFilter = "Fornecedor";
        }

        #endregion

        #region Escutador

        private void cmbSelecioneProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQuant.Enabled = true;
            txtQuant.Clear();

            serviceProd = new ProdutoService();

            produto = serviceProd.GetByName(cmbSelecioneProduto.Text);

            if (produto != null)
            {
                txtPreco.Text = "R$ " + produto.Preco.ToString();
            }
        }

        private void cmbSelecioneCancel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQUantidadeCancel.Items.Clear();
            txtTotalCimaCancel.Clear();

            if (cmbSelecioneCancel.SelectedIndex != -1)
            {
                itemCompra = serviceItemC.GetByIdItemCompra(Convert.ToInt32(cmbSelecioneCancel.Text));
            }

            if (itemCompra != null)
            {
                txtPrecoCancel.Text = "R$ " + itemCompra.Valor_Unitario.ToString();

                //para listar a quantidade
                for (int i = 1; i <= itemCompra.Quantidade; i++)
                {
                    cmbQUantidadeCancel.Items.AddRange(new object[] {
                        i.ToString()
                    });
                }
            }
        }

        private void cmbQUantidadeCancel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelecioneCancel.SelectedIndex != -1 && cmbQUantidadeCancel.SelectedIndex != -1)
            {
                var itemC = itemCompras.FirstOrDefault(itemCompras => itemCompras.Id.Equals(Convert.ToInt32(cmbSelecioneCancel.Text)));
                var total = Convert.ToDouble(cmbQUantidadeCancel.Text) * itemC.Valor_Unitario;
                txtTotalCimaCancel.Text = "R$" + total.ToString();
            }

        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {
            if (txtQuant.Text.Equals(""))
            {
                txtTotalCima.Clear();

            }
            else
            {
                if (produto != null)
                {
                    var total = Convert.ToDouble(txtQuant.Text) * produto.Preco;
                    txtTotalCima.Text = total.ToString();
                }
            }

        }

        #endregion

    }
}