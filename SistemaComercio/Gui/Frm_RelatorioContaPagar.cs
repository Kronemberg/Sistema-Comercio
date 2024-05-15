using Microsoft.Reporting.WinForms;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_RelatorioContaPagar : Form
    {
        private IContaPagarPort service;
        private List<ItemCompra> itemCompras;
        private IItemCompraPort serviceItemC;
        private ICompraPort serviceC;
        private List<Compra> compras;
        private List<ContaPagar> contasPagar;
        private ContaPagar contaPagar;
        private Compra compra;
        private DataTable dt = new DataTable();
        private Frm_Principal frmprincipal;
        private string totalContas;


        public Frm_RelatorioContaPagar()
        {
            InitializeComponent();
            cmbSituacao.Text = "Paga";
            UpdateReportViewer();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void Frm_RelatorioContaPagar_Load(object sender, EventArgs e)
        {
            this.rvRelatorioContaPagar.RefreshReport();
        }

        public void UpdateReportViewer()
        {
            serviceC = new CompraService();
            service = new ContaPagarService();
            serviceItemC = new ItemCompraService();

            if (cmbSituacao.Text.Equals("Paga"))
            {
                CreateContasPagarDataTable();
            }
            else
            {
                CreateItemCompraDataTable();
            }

            CreateReportViewer();
        }

        public void CreateContasPagarDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("DataLancamento", typeof(string));
            dt.Columns.Add("DataVencimento", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("Pago", typeof(string));
            dt.Columns.Add("DataPagamento", typeof(string));
            dt.Columns.Add("ValorPagamento", typeof(string));
            dt.Columns.Add("FormaPagamento", typeof(string));
            dt.Columns.Add("Parcelamento", typeof(string));
            dt.Columns.Add("Fornecedor", typeof(string));

            if (contasPagar == null)
                contasPagar = service.GetAllContaPagar();

            foreach (var contaPagar in contasPagar)
            {
                var FormRelatorioCP = new FormRelatorioContaPagar(contaPagar);

                dt.Rows.Add(new object[]
                {
                    FormRelatorioCP.Id,
                    "Pago",
                    FormRelatorioCP.Descricao,
                    FormRelatorioCP.DataLancamento,
                    FormRelatorioCP.DataVencimento,
                    FormRelatorioCP.Valor,
                    FormRelatorioCP.Pago,
                    FormRelatorioCP.DataPagamento,
                    FormRelatorioCP.ValorPagamento,
                    FormRelatorioCP.FormaPagamento,
                    FormRelatorioCP.Parcelamento,
                    FormRelatorioCP.Fornecedor,
                });
            }
            totalContas = contasPagar.Count.ToString();

        } //ta certo???

        public void CreateReportViewer()
        {
            rvRelatorioContaPagar.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ContasPagar", dt);
            rvRelatorioContaPagar.LocalReport.ReportPath = "RelatorioContaPagar.rdlc";
            rvRelatorioContaPagar.LocalReport.DataSources.Add(reportDataSource);

            AddParameter("TotalContaPagar", totalContas);
            rvRelatorioContaPagar.LocalReport.Refresh();
        }

        public void AddParameter(string parameter, string value)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter(parameter, value);
            rvRelatorioContaPagar.LocalReport.SetParameters(parameters);
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceItemC = new ItemCompraService();
            UpdateSituationReportViewer();

            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioContaPagar.RefreshReport();
        }

        public void UpdateSituationReportViewer()
        {
            var item = serviceItemC.GetAllItemCompra();

            if (cmbSituacao.Text.Equals("Não Vencida"))
            {
                itemCompras = item.Where(x => x.Compra.Situacao_Compra.Equals("Aguardando Pagamento")).ToList();
            }

            if (cmbSituacao.Text.Equals("Em Atraso"))
            {
                itemCompras = new List<ItemCompra>();
                foreach (var itemCompra in item)
                {
                    var dataVencimento = Convert.ToDateTime(itemCompra.Compra.Data).AddDays(2);
                    int result = DateTime.Compare(DateTime.Now.Date, dataVencimento);

                    if (result > 0 && itemCompra.Compra.Situacao_Compra != "Pago")
                    {
                        itemCompra.Compra.Situacao_Compra = "Em Atraso";
                        itemCompras.Add(itemCompra);
                        serviceItemC.UpdateItemCompra(itemCompra);
                    }
                }
            }

            if (cmbSituacao.Text.Equals("A Vencer"))
            {
                itemCompras = new List<ItemCompra>();

                foreach (var itemCompra in item)
                {
                    var dataVencimento = Convert.ToDateTime(itemCompra.Compra.Data).AddDays(2).ToString("dd-MM-yyyy");
                    var date = DateTime.Now.ToString("dd-MM-yyyy");

                    if (dataVencimento.Equals(date) && itemCompra.Compra.Situacao_Compra != "Pago")
                    {
                        itemCompra.Compra.Situacao_Compra = "A Vencer";
                        itemCompras.Add(itemCompra);
                        serviceItemC.UpdateItemCompra(itemCompra);
                    }
                }
            }
        }


        private void ClearReportViewer()
        {
            rvRelatorioContaPagar.ResetPageSettings();
            rvRelatorioContaPagar.LocalReport.Refresh();
            this.rvRelatorioContaPagar.LocalReport.DataSources.Clear();
        }

        private void rvRelatorioContaPagar_ReportRefresh(object sender, CancelEventArgs e)
        {
            CreateReportViewer();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var contaC = new Frm_ContaPagar(frmprincipal);
            this.Hide();
        }


        public void CreateItemCompraDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("DataLancamento", typeof(string));
            dt.Columns.Add("DataVencimento", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("Pago", typeof(string));
            dt.Columns.Add("DataPagamento", typeof(string));
            dt.Columns.Add("ValorPagamento", typeof(string));
            dt.Columns.Add("FormaPagamento", typeof(string));
            dt.Columns.Add("Parcelamento", typeof(string));
            dt.Columns.Add("Fornecedor", typeof(string));

            foreach (var itemCompra in itemCompras)
            {
                //CRIAR OUTRO CONSTRUTOR
                var FormRelatorioCP = new FormRelatorioContaPagar(itemCompra);

                dt.Rows.Add(new object[]
                {
                   FormRelatorioCP.Id,
                   FormRelatorioCP.Status,
                    FormRelatorioCP.Descricao,
                    FormRelatorioCP.DataLancamento,
                    FormRelatorioCP.DataVencimento,
                    FormRelatorioCP.Valor,
                    FormRelatorioCP.Pago,
                    FormRelatorioCP.DataPagamento,
                    FormRelatorioCP.ValorPagamento,
                    FormRelatorioCP.FormaPagamento,
                    FormRelatorioCP.Parcelamento,
                    FormRelatorioCP.Fornecedor,
                });
            }

            totalContas = itemCompras.Count.ToString();

        }
    }
}
