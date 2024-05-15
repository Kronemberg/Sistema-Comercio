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
    public partial class Frm_ContaReceber : Form
    {
        private IContaReceberPort service;
        private IItemVendaPort serviceItemV;
        private IVendaPort serviceV;
        private DataTable dt = new DataTable();
        private Venda vnd = null;
        private string columnFilter;
        private List<ItemVenda> itemVendas;
        private ItemVenda itemVenda;
        private List<Venda> vendas;
        private Venda venda;
        private string metodoPagamento = "Pix";
        private Frm_Principal formprincipal;
        private ICaixaPort serviceCaixa;
        private Caixa caixa;

        public Frm_ContaReceber(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formprincipal = frm_Principal;
            UpdateVenda();
        }

        #region ComboBox

        private void AddComboBoxContaReceber()
        {
            this.cmbSelecioneContaReceber.Items.Clear();

            foreach (var venda in vendas)
            {
                if (venda.Situacao_Venda != "Vendido" && venda.Situacao_Venda != "Cancelado")
                {
                    this.cmbSelecioneContaReceber.Items.AddRange(new object[] {
                venda.Id.ToString()
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
            Frm_RelatorioContaReceber relatorioCR = new Frm_RelatorioContaReceber();
            relatorioCR.Show();
        }

        private void ClickLimparCampos(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickVender(object sender, EventArgs e)
        {
            try
            {
                var valorRecebido = Convert.ToDouble(txtValorPaga.Text);
             
                    //Valida se foi informado o valor total do produto
                    if (venda.Total_Venda == valorRecebido)
                    {
                        CreateContaReceber();
                        LimparCampos();
                        UpdateVenda();
                        formprincipal.UpdateSalarioUser(formprincipal.user.Salario += valorRecebido);
                        MessageBox.Show("Venda Realizada!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Informe o valor total!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

            }
            catch
            {
                MessageBox.Show("Erro ao realizar venda!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
  
        
        #endregion

        #region Funções

        private void UpdateVenda()
        {
            serviceV = new VendaService();
            service = new ContaReceberService();
            serviceCaixa = new CaixaService();

            caixa = serviceCaixa.GetAllCaixa().First();
            vendas = serviceV.GetAllVenda();

            AddComboBoxContaReceber();
        }

        private void LimparCampos()
        {
            cmbSelecioneContaReceber.SelectedIndex = -1;
            txtCliente.Clear();
            txtDescricao.Clear();
            txtDataLanca.Clear();
            txtDataVenci.Clear();
            txtValorPaga.Clear();
            txtValor.Clear();
            cmbParcelamento.SelectedIndex = -1;
            cmbParcelamento.Enabled = false;
            gpbFormaPagamento.Enabled = false;
        }

        private void SetGeracaoContaReceber()
        {
            txtDescricao.Text = venda.ItemVenda.First().Produto.Nome.ToString();
            txtCliente.Text = venda.Cliente.Nome;
            txtDataLanca.Text = venda.Data;
            txtDataVenci.Text = Convert.ToDateTime(venda.Data).AddDays(2).ToString("dd-MM-yyyy");
            txtValor.Text = venda.Total_Venda.ToString();
        } 

        private void CreateContaReceber()
        {
            var dataLanca = Convert.ToDateTime(txtDataLanca.Text).ToString("dd-MM-yyyy");
            var dataVenci = Convert.ToDateTime(txtDataVenci.Text).ToString("dd-MM-yyyy");
            var parcela = 0;

            if (metodoPagamento.Equals("Cartão de Crédito"))
                parcela = Convert.ToInt32(cmbParcelamento.Text.Substring(0, 1));

            var contaReceber = new ContaReceber()
            {
                Descricao = txtDescricao.Text,
                Data_Lancamento = Convert.ToDateTime(dataLanca),
                Data_Vencimento = Convert.ToDateTime(dataVenci),
                Valor = Convert.ToDouble(txtValor.Text),
                Recebido = Convert.ToDouble(txtValorPaga.Text),
                Data_Recebimento = DateTime.Now,
                Valor_Recebimento = Convert.ToDouble(txtValorPaga.Text),
                Id_Cliente = venda.Id_Cliente,
                Parcela = parcela,
                FormaPagamento = metodoPagamento,
            };

            venda.Situacao_Venda = "Vendido";


            serviceV.UpdateVenda(venda);
            service.AddContaReceber(contaReceber);
            UpdateCaixa(parcela);
        }
        
        public void UpdateCaixa(int parcela)
        {
            var movimento = new MovimentoCaixa()
            {
                Data_Movimento = DateTime.Now,
                Hora_Movimento = DateTime.Now,
                Descricao = venda.ItemVenda.First().Produto.Nome,
                Id_Caixa = caixa.Id,
                Quantidade = venda.ItemVenda.First().Quantidade,
                Tipo_Movimento = "Venda",
                Valor = Convert.ToDouble(txtValorPaga.Text),
                FormaPagamento = metodoPagamento,
                Parcelamento = parcela.ToString()
            };

            caixa.SaldoAnterior = caixa.Saldo;
            caixa.Saldo += Convert.ToDouble(txtValorPaga.Text);
            caixa.MovimentoCaixa.Add(movimento);

            serviceCaixa.UpdateCaixa(caixa);
        }

        #endregion

        #region Escutadores

        private void cmbSelecioneContaReceber_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelecioneContaReceber.SelectedIndex != -1)
            {
                rdbPix.Checked = true;
                var idVenda = Convert.ToInt32(cmbSelecioneContaReceber.Text);
                venda = serviceV.GetByIdVenda(idVenda);
                SetGeracaoContaReceber();
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

        private void rdbDinehiro_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Dinheiro";
            cmbParcelamento.Enabled = false;
            cmbParcelamento.SelectedIndex = -1;
        }

        private void rdbCartaoDebito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Cartão de Débito";
            cmbParcelamento.Enabled = false;
            cmbParcelamento.SelectedIndex = -1;
        }

        private void rbbCartaoCredito_CheckedChanged(object sender, EventArgs e)
        {
            metodoPagamento = "Cartão de Crédito";
            cmbParcelamento.Items.Clear();

            if (cmbSelecioneContaReceber.SelectedIndex != -1 && rdbCartaoCredito.Checked)
            {
                cmbParcelamento.Enabled = true;
                cmbParcelamento.SelectedIndex = -1;

                for (int i = 1; i < 10; i++)
                {
                    var result = venda.Total_Venda / i;
                    this.cmbParcelamento.Items.AddRange(new object[] {
                     $"{i}x de {result.ToString("C")} sem juros."
                });
                }

                cmbParcelamento.SelectedIndex = 0;
            }
        }

        #endregion
    }
}
