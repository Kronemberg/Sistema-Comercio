using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Caixa : Form
    {
        private DataTable dt = new DataTable();
        private IContaPagarPort serviceCotaPagar;
        private IContaReceberPort serviceContaReceber;
        private ICaixaPort serviceCaixa;
        private List<ContaPagar> contasPagar;
        private List<ContaReceber> contasReceber;
        private Caixa caixa;

        public Frm_Caixa()
        {
            InitializeComponent();
            UpdateCaixaInDataGrid();
            dataGridViewCaixa.ReadOnly = true;
        }

        private void UpdateCaixaInDataGrid()
        {
            serviceCotaPagar = new ContaPagarService();
            serviceContaReceber = new ContaReceberService();
            serviceCaixa = new CaixaService();

            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("Movimento", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Forma de pagamento", typeof(string));

            CreateEntityCaixa();

            foreach (var movimento in caixa.MovimentoCaixa)
            {
                dt.Rows.Add(new object[]
                {
                   movimento.Id,
                   movimento.Data_Movimento,
                   movimento.Hora_Movimento,
                   movimento.Descricao,
                   movimento.Quantidade,
                   movimento.Tipo_Movimento,
                   movimento.Valor,
                   movimento.FormaPagamento,
                });
            }

            contasReceber = serviceContaReceber.GetAllContaReceber();
            contasPagar = serviceCotaPagar.GetAllContaPagar();
            UpdateSaldo();
            dataGridViewCaixa.DataSource = dt;
        }

        public void CreateEntityCaixa()
        {
            var count = serviceCaixa.GetAllCaixa().Count();

            if (count <= 0)
            {
                var newCaixa = new Caixa()
                {
                    Nome = "caixa1",
                    Saldo = 0,
                };

                serviceCaixa.AddCaixa(newCaixa);
            }

            caixa = serviceCaixa.GetAllCaixa().First();
            caixa.MovimentoCaixa = new List<MovimentoCaixa>();
        }

        public void UpdateSaldo()
        {
            lblTotalCompra.Text = contasPagar.Count.ToString();
            lblTotalVenda.Text = contasReceber.Count.ToString();
            lblSaldoAtual.Text = caixa.Saldo.ToString();
            lblAnterior.Text = caixa.SaldoAnterior.ToString();
        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewCaixa.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Data"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Hora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Id Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Produto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCaixa.Columns["Forma de pagamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewCaixa.Columns)
            {
                switch (coluna.Name)
                {
                    case "Id":
                        coluna.Width = 40;
                        break;
                    case "Data":
                        coluna.Width = 100;
                        break;
                    case "Hora":
                        coluna.Width = 100;
                        break;
                    case "Id Produto":
                        coluna.Width = 55;
                        break;
                    case "Produto":
                        coluna.Width = 150;
                        break;
                    case "Quantidade":
                        coluna.Width = 55;
                        break;
                    case "Total":
                        coluna.DefaultCellStyle.Format = "C2";
                        coluna.Width = 70;
                        break;
                    case "Forma de pagamento":
                        coluna.Width = 120;
                        break;
                    case "Situacao":
                        coluna.DisplayIndex = 1;
                        coluna.Width = 135;
                        break;
                }
            }

        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        private void ClickGerarRelatorio(object sender, EventArgs e)
        {
            var relatorio = new Frm_RelatorioCaixa();
            relatorio.Show();
        }

    }
}