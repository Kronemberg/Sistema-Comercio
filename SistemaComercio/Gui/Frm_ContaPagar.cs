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
    public partial class Frm_ContaPagar : Form
    {
        private IContaPagarPort service;
        private IItemCompraPort serviceItemC;
        private ICompraPort serviceC;
        private DataTable dt = new DataTable();
        private Compra cmp = null;
        private string columnFilter;
        private List<ItemCompra> itemCompras;
        private ItemCompra itemCompra;
        private List<Compra> compras;
        private Compra compra;
        private Frm_Principal formPrincipal;
        private string metodoPagamento = "Pix";
        private ICaixaPort serviceCaixa;
        private Caixa caixa;

        public Frm_ContaPagar(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formPrincipal = frm_Principal;
            UpdateCompra();
        }

        #region ComboBox

        private void AddComboBoxContaPagar()
        {
            this.cmbSelecioneCompra.Items.Clear();

            foreach (var compra in compras)
            {
                if (compra.Situacao_Compra != "Pago" && compra.Situacao_Compra != "Cancelado")
                {
                    this.cmbSelecioneCompra.Items.AddRange(new object[] {
                compra.Id.ToString()
                });
                }
            }
        }

        #endregion

        #region Click Botões Form

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickEmitirRelatorio(object sender, EventArgs e)
        {
            Frm_RelatorioContaPagar relatorioCP = new Frm_RelatorioContaPagar();
            relatorioCP.Show();
        }

        private void ClickLimparCampos(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickPagar(object sender, EventArgs e)
        {
            try
            {
                var valorPago = Convert.ToDouble(txtValorPaga.Text);

                //Valida se o usuario possui o dinheiro
                if (valorPago <= caixa.Saldo)
                {
                    //Valida se foi informado o valor total do produto

                    if (compra.Total_Compra == valorPago)
                    {
                        CreateContaPagar();
                        LimparCampos();
                        UpdateCompra();
                        formPrincipal.UpdateSalarioUser(formPrincipal.user.Salario -= valorPago);
                        MessageBox.Show("Compra Paga!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Informe o valor total!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                }
                else
                {
                    MessageBox.Show("Saldo insuficiente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            catch
            {
                MessageBox.Show("Erro ao pagar compra!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #endregion

        #region Funções

        private void UpdateCompra()
        {
            serviceC = new CompraService();
            service = new ContaPagarService();

            serviceCaixa = new CaixaService();

            caixa = serviceCaixa.GetAllCaixa().First();
            compras = serviceC.GetAllCompra();

            AddComboBoxContaPagar();
        }

        private void LimparCampos()
        {
            cmbSelecioneCompra.SelectedIndex = -1;
            txtFornecedor.Clear();
            txtDescricao.Clear();
            txtDataLanca.Clear();
            txtDataVenci.Clear();
            txtValorPaga.Clear();
            txtValor.Clear();
            cmbParcelamento.SelectedIndex = -1;
            cmbParcelamento.Enabled = false;
            gpbFormaPagamento.Enabled = false;

        }

        private void SetGeracaoContaPagar()
        {
            txtDescricao.Text = compra.ItemCompra.First().Produto.Nome;
            txtFornecedor.Text = compra.Fornecedor.Nome;
            txtDataLanca.Text = compra.Data;
            txtDataVenci.Text = Convert.ToDateTime(compra.Data).AddDays(2).ToString("dd-MM-yyyy");
            txtValor.Text = compra.Total_Compra.ToString();
        }

        private void CreateContaPagar()
        {
            var dataLanca = Convert.ToDateTime(txtDataLanca.Text).ToString("dd-MM-yyyy HH:mm:ss");
            var dataVenci = Convert.ToDateTime(txtDataVenci.Text).ToString("dd-MM-yyyy HH:mm:ss");
            var parcela = 0;

            if (metodoPagamento.Equals("Cartão de Crédito"))
                parcela = Convert.ToInt32(cmbParcelamento.Text.Substring(0, 1));

            var contaPagar = new ContaPagar()
            {
                Descricao = txtDescricao.Text,
                Data_Lancamento = Convert.ToDateTime(dataLanca),
                Data_Vencimento = Convert.ToDateTime(dataVenci),
                Valor = Convert.ToDouble(txtValor.Text),
                Pago = Convert.ToDouble(txtValorPaga.Text),
                Data_Pagamento = DateTime.Now,
                Valor_Pagamento = Convert.ToDouble(txtValorPaga.Text),
                Id_Fornecedor = compra.Id_Fornecedor,
                Parcela = parcela,
                FormaPagamento = metodoPagamento,
            };

            compra.Situacao_Compra = "Pago";

            serviceC.UpdateCompra(compra);
            service.AddContaPagar(contaPagar);
            UpdateCaixa(parcela);
        }

        public void UpdateCaixa(int parcela)
        {
            var movimento = new MovimentoCaixa()
            {
                Data_Movimento = DateTime.Now,
                Hora_Movimento = DateTime.Now,
                Descricao = compra.ItemCompra.First().Produto.Nome,
                Id_Caixa = caixa.Id,
                Quantidade = compra.ItemCompra.First().Quantidade,
                Tipo_Movimento = "Compra",
                Valor = Convert.ToDouble(txtValorPaga.Text),
                FormaPagamento = metodoPagamento,
                Parcelamento = parcela.ToString()
            };

            caixa.SaldoAnterior = caixa.Saldo;
            caixa.Saldo -= Convert.ToDouble(txtValorPaga.Text);
            caixa.MovimentoCaixa.Add(movimento);
            serviceCaixa.UpdateCaixa(caixa);
        }


        #endregion

        #region Escutadores

        private void cmbSelecioneCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelecioneCompra.SelectedIndex != -1)
            {
                rdbPix.Checked = true;
                var idCompra = Convert.ToInt32(cmbSelecioneCompra.Text);
                compra = serviceC.GetByIdCompra(idCompra);
                SetGeracaoContaPagar();
                gpbFormaPagamento.Enabled = true;
            }

        }

        private void cmbParcelamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbParcelamento.SelectedIndex != -1)
            {


            }
        }

        private void rdbPix_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Pix";
            cmbParcelamento.Enabled = false;
            cmbParcelamento.SelectedIndex = -1;
        }

        private void rdbCartaoDebito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Cartão de Débito";
            cmbParcelamento.Enabled = false;
            cmbParcelamento.SelectedIndex = -1;
        }

        private void rdbCartaoCredito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Cartão de Crédito";
            cmbParcelamento.Items.Clear();

            if (cmbSelecioneCompra.SelectedIndex != -1 && rdbCartaoCredito.Checked)
            {
                cmbParcelamento.Enabled = true;
                cmbParcelamento.SelectedIndex = -1;

                for (int i = 1; i < 10; i++)
                {
                    var result = compra.Total_Compra / i;
                    this.cmbParcelamento.Items.AddRange(new object[] {
                     $"{i}x de {result.ToString("C")} sem juros."
                });
                }

                cmbParcelamento.SelectedIndex = 0;
            }
        }

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Dinheiro";
            cmbParcelamento.Enabled = false;
            cmbParcelamento.SelectedIndex = -1;
        }

        #endregion

    }
}

