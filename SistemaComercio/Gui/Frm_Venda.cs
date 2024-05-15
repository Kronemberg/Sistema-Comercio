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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaComercio.Gui
{
    public partial class Frm_Venda : Form
    {
        private List<ItemCompra> itemCompras;
        private List<ItemVenda> itemVendas;
        private List<Cliente> clientes;
        private List<Produto> produtos;
        private Produto produto;
        private ItemVenda itemVenda;
        private IVendaPort service;
        private IItemCompraPort serviceItemC;
        private IItemVendaPort serviceItemV;
        private IProdutoPort serviceProd;
        private IClientePort serviceCliente;
        private DataTable dt = new DataTable();
        private string columnFilter;
        private Venda vnd = null;
        private double totalVenda;
        private Frm_Principal formprincipal;

        public Frm_Venda(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formprincipal = frm_Principal;
            UpdateVendaInDataGrid();
        }


        #region ComboBox

        public void UpdateAllComboBox()
        {
            AddComboBoxVenda();
            AddComboBoxCancelarVenda();
            AddComboBoxCliente();
        }

        private void AddComboBoxVenda()
        {
            this.cmbSelecioneProduto.Items.Clear();

            foreach (var produto in produtos.Distinct())
            {
                this.cmbSelecioneProduto.Items.AddRange(new object[] {
                produto.Nome
                });
            }
        }

        private void AddComboBoxCancelarVenda()
        {
            this.cmbSelecioneCancelamento.Items.Clear();

            foreach (var itemVenda in itemVendas)
            {
                if (itemVenda.Venda.Situacao_Venda != "Cancelado")
                {
                    this.cmbSelecioneCancelamento.Items.AddRange(new object[] {
                    itemVenda.Id.ToString()
                });

                }
            }
        }

        private void AddComboBoxCliente()
        {
            cmbSelecioneCli.Items.Clear();

            foreach (var cliente in clientes)
            {
                cmbSelecioneCli.Items.AddRange(new object[] {
                    cliente.Nome.ToString()

                });
            }
        }

        private void AddComboBoxQuantiCancel()
        {
            for (int i = 1; i <= itemVenda.Quantidade; i++)
            {
                cmbQuantiCancelar.Items.AddRange(new object[] {
                        i.ToString()
                    });
            }
        }

        #endregion


        #region DataGridView


        private void UpdateVendaInDataGrid()
        {
            service = new VendaService();
            serviceItemC = new ItemCompraService();
            serviceItemV = new ItemVendaService();
            serviceProd = new ProdutoService();
            serviceCliente = new ClienteService();

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Valor Unitario", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Id Produto", typeof(string));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Id Venda", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Situacao", typeof(string));
            dt.Columns.Add("Id Cliente", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));

            itemVendas = serviceItemV.GetAllItemVenda();
            produtos = serviceProd.GetAllVenda();
            clientes = serviceCliente.GetAllCliente();

            foreach (var itemVenda in itemVendas)
            {
                dt.Rows.Add(new object[]
                {
                    itemVenda.Id,
                    itemVenda.Quantidade,
                    itemVenda.Valor_Unitario,
                    itemVenda.Total_Item,
                    itemVenda.Id_Produto,
                    itemVenda.Produto.Nome,
                    itemVenda.Id_Venda,
                    itemVenda.Venda.Data,
                    itemVenda.Venda.Hora,
                    itemVenda.Venda.Situacao_Venda,
                    itemVenda.Venda.Id_Cliente,
                    itemVenda.Venda.Cliente.Nome

                });
            }
            formprincipal.GetCount();
            dataGridViewVenda.DataSource = dt;
            itemCompras = serviceItemC.GetAllItemCompra();

            UpdateAllComboBox();
        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewVenda.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Valor Unitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Id Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Id Venda"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Situacao"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Id Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewVenda.Columns["Cliente"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewVenda.Columns)
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
                        coluna.Width = 60;
                        break;
                    case "Total":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 55;
                        break;
                    case "Id Produto":
                        coluna.Width = 45;
                        break;
                    case "Produto":
                        coluna.Width = 115;
                        break;
                    case "Id Venda":
                        coluna.Width = 45;
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
                    case "Id Cliente":
                        coluna.Width = 45;
                        break;
                    case "Cliente":
                        coluna.DisplayIndex = 1;
                        coluna.Width = 60;
                        break;
                }
            }
        }  //DataBindingComplete


        #endregion


        #region Click Botões Form

        private void ClickEmitirRelatorio(object sender, EventArgs e)
        {
            Frm_RelatorioVenda relatorioV = new Frm_RelatorioVenda(formprincipal);
            relatorioV.Show();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickConsultar(object sender, EventArgs e)
        {
            PesquisaVendaFiltro();
        }

        private void ClickLimparCamposLancar(object sender, EventArgs e)
        {
            LimparCampos();
            lblRespostaSituacao.Text = "";
            txtData.Text = "";
            txtHora.Text = "";
            txtTotal.Text = "";
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickLimparCamposCancel(object sender, EventArgs e)
        {
            LimparCampos();
            txtData.Text = "";
            txtHora.Text = "";
            txtTotal.Text = "";
            lblRespostaSituacao.Text = "";
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ClickLancarVenda(object sender, EventArgs e)
        {
            try
            {
                //TEM Q VER ESSE Q N TA CAINDO AQUI
                if (cmbQuantidade.SelectedIndex == -1 || cmbSelecioneProduto.SelectedIndex == -1 || cmbSelecioneCli.SelectedIndex == -1)
                {
                    MessageBox.Show("É necessário preencher todos os campos!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CreateVenda();
                    UpdateVendaInDataGrid();
                    LimparCampos();
                    MessageBox.Show("Venda Lançada!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch
            {
                MessageBox.Show("Erro ao lançar venda!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCancelarVenda(object sender, EventArgs e)
        {
            try
            {
                itemVenda = serviceItemV.GetByIdItemVenda(Convert.ToInt32(cmbSelecioneCancelamento.Text));

                if (cmbQuantiCancelar.Text == itemVenda.Quantidade.ToString())
                {
                    CancelItemVenda(itemVenda, "Cancelado");
                    MessageBox.Show("Venda Cancelada!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    itemVenda.Quantidade -= Convert.ToInt32(cmbQuantiCancelar.Text);
                    CancelItemVenda(itemVenda, "Alterado");
                    MessageBox.Show("Situação de venda alterada!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                LimparCampos();
                UpdateVendaInDataGrid();
            }
            catch
            {
                MessageBox.Show("Erro ao cancelar venda!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        #region Funções

        private void PesquisaVendaFiltro()
        {
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", columnFilter, txtSelecioneVenda.Text);
            dataGridViewVenda.DataSource = dt;
        }

        private void LimparCampos()
        {
            txtPreco.Clear();
            txtTotalCima.Clear();
            cmbSelecioneCli.SelectedIndex = -1;
            cmbSelecioneProduto.SelectedIndex = -1;
            cmbSelecioneCancelamento.SelectedIndex = -1;
            cmbQuantidade.SelectedIndex = -1;
            cmbQuantiCancelar.SelectedIndex = -1;
            txtPrecoCancel.Clear();
            txtTotalCimaCancel.Clear();
            cmbQuantidade.Items.Clear();

        }

        private void RemoveVenda(int id)
        {
            vnd = service.GetByIdVenda(id);
            try
            {
                service.DelVenda(vnd);
                UpdateVendaInDataGrid();
                MessageBox.Show("Venda excluida!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir venda!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void CreateVenda()
        {
            var cliente = serviceCliente.GetByNomeCliente(cmbSelecioneCli.Text);

            totalVenda = Convert.ToInt32(produto.Preco) * Convert.ToInt32(cmbQuantidade.Text);

            var venda = new Venda()
            {
                Total_Venda = totalVenda,
                Data = DateTime.Now.ToString("dd-MM-yyyy"),
                Hora = DateTime.Now.ToString("HH:mm:ss"),
                Situacao_Venda = "Aguardando Pagamento",
                Id_Cliente = cliente.Id
            };

            var itemVenda = new ItemVenda()
            {
                Venda = venda,
                Id_Produto = produto.Id,
                Quantidade = Convert.ToInt32(cmbQuantidade.Text),
                Total_Item = totalVenda,
                Valor_Unitario = produto.Preco,
            };

            produto.Quantidade_Estoque -= itemVenda.Quantidade;

            serviceItemV.AddItemVenda(itemVenda);
            serviceProd.UpdateProduto(produto);

            SetDadosOperacionais(itemVenda);
        }

        public void CancelItemVenda(ItemVenda itemVenda, string status)
        {
            itemVenda.Venda.Situacao_Venda = status;
            itemVenda.Produto.Quantidade_Estoque += Convert.ToInt32(cmbQuantiCancelar.Text);
            serviceItemV.UpdateItemVenda(itemVenda);
            lblRespostaSituacao.Text = status;
            lblRespostaSituacao.Text = status;
        }

        void SetDadosOperacionais(ItemVenda itemVenda)
        {
            txtData.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtHora.Text = DateTime.Now.ToString("HH:mm:ss");
            txtTotal.Text = "R$" + itemVenda.Venda.Total_Venda;
            lblRespostaSituacao.Text = itemVenda.Venda.Situacao_Venda;
        }

        #endregion


        #region Escutadores

        private void cmbSelecioneProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQuantidade.Items.Clear();

            serviceProd = new ProdutoService();

            if (cmbSelecioneProduto.SelectedIndex != -1)
            {
                produto = serviceProd.GetByName(cmbSelecioneProduto.Text);

                if (produto != null)
                {
                    txtPreco.Text = "R$ " + produto.Preco.ToString();

                    for (int i = 1; i <= produto.Quantidade_Estoque; i++)
                    {
                        cmbQuantidade.Items.AddRange(new object[] {
                        i
                    });
                    }
                }
            }
        }

        private void cmbQuantidade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuantidade.SelectedIndex != -1)
            {
                totalVenda = Convert.ToInt32(produto.Preco) * Convert.ToInt32(cmbQuantidade.Text);
                txtTotalCima.Text = totalVenda.ToString("C");
            }

        }

        private void cmbQuantiCancelar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQuantiCancelar.SelectedIndex != -1)
            {
                var total = Convert.ToInt32(itemVenda.Venda.Total_Venda) * Convert.ToInt32(cmbQuantiCancelar.Text);
                txtTotalCimaCancel.Text = total.ToString("C");
            }
        }

        private void cmbSelecioneCancelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQuantiCancelar.Items.Clear();

            if (cmbSelecioneCancelamento.SelectedIndex != -1)
            {
                itemVenda = serviceItemV.GetByIdItemVenda(Convert.ToInt32(cmbSelecioneCancelamento.Text));

                if (itemVenda != null)
                {
                    txtPrecoCancel.Text = "R$ " + itemVenda.Valor_Unitario.ToString();
                    AddComboBoxQuantiCancel();
                }
            }
        }

        #endregion

        private void cmbQuantidade_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cmbQuantidade.SelectedIndex != -1)
            {
                var total = produto.Preco * Convert.ToInt32(cmbQuantidade.Text);
                txtTotalCima.Text = total.ToString("C");
            }
        }

        private void RadioButtonPeriodoCheckChanged(object sender, EventArgs e)
        {
            txtSelecioneVenda.Enabled = true;
            columnFilter = "Data";
        }

        private void RadioButtonClienteCheckChanged(object sender, EventArgs e)
        {
            txtSelecioneVenda.Enabled = true;
            columnFilter = "Cliente";
        }
    }
}