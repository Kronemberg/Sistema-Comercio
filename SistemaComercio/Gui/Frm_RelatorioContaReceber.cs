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
    public partial class Frm_RelatorioContaReceber : Form
    {
        private IContaReceberPort service;
        private List<ItemVenda> itemVendas;
        private IItemVendaPort serviceItemV;
        private IVendaPort serviceV;
        private List<Venda> vendas;
        private List<ContaReceber> contasReceber;
        private ContaReceber contaReceber;
        private Venda venda;
        private DataTable dt = new DataTable();
        private Frm_Principal frmprincipal;
        private string totalConta;

        public Frm_RelatorioContaReceber()
        {
            InitializeComponent();
            cmbSituacao.Text = "Vendido";
            UpdateReportViewer();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Frm_RelatorioContaReceber_Load(object sender, EventArgs e)
        {

            this.rvRelatorioContaReceber.RefreshReport();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var contaR = new Frm_ContaReceber(frmprincipal);
            this.Hide();
        }

        public void UpdateReportViewer()
        {
            serviceV = new VendaService();
            service = new ContaReceberService();
            serviceItemV = new ItemVendaService();

            if (cmbSituacao.Text.Equals("Vendido"))
            {
                CreateContasReceberDataTable();
            }
            else
            {
                CreateItemVendaDataTable();
            }

            CreateReportViewer();
        }

        public void CreateContasReceberDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("DataLancamento", typeof(string));
            dt.Columns.Add("DataVencimento", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("Recebido", typeof(string));
            dt.Columns.Add("DataRecebimento", typeof(string));
            dt.Columns.Add("ValorRecebimento", typeof(string));
            dt.Columns.Add("FormaPagamento", typeof(string));
            dt.Columns.Add("Parcelamento", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));

            if (contasReceber == null)
                contasReceber = service.GetAllContaReceber();

            foreach (var contaReceber in contasReceber)
            {
                var FormRelatorioCR = new FormRelatorioContaReceber(contaReceber);

                dt.Rows.Add(new object[]
                {
                    FormRelatorioCR.Id,
                    "Vendido",
                    FormRelatorioCR.Descricao,
                    FormRelatorioCR.DataLancamento,
                    FormRelatorioCR.DataVencimento,
                    FormRelatorioCR.Valor,
                    FormRelatorioCR.Recebido,
                    FormRelatorioCR.DataRecebimento,
                    FormRelatorioCR.ValorRecebimento,
                    FormRelatorioCR.FormaPagamento,
                    FormRelatorioCR.Parcelamento,
                    FormRelatorioCR.Cliente,
                });
            }

            totalConta = contasReceber.Count.ToString();

        }

        public void CreateReportViewer()
        {
            rvRelatorioContaReceber.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ContasReceber", dt);
            rvRelatorioContaReceber.LocalReport.ReportPath = "RelatorioContaReceber.rdlc";
            rvRelatorioContaReceber.LocalReport.DataSources.Add(reportDataSource);

            AddParameter("TotalContaReceber", totalConta);
            rvRelatorioContaReceber.LocalReport.Refresh();
        }

        public void AddParameter(string parameter, string value)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter(parameter, value);
            rvRelatorioContaReceber.LocalReport.SetParameters(parameters);
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            serviceItemV = new ItemVendaService();
            UpdateSituationReportViewer();

            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioContaReceber.RefreshReport();
        }


        public void UpdateSituationReportViewer()
        {
            var item = serviceItemV.GetAllItemVenda();

            if (cmbSituacao.Text.Equals("A Receber"))
            {
                itemVendas = item.Where(x => x.Venda.Situacao_Venda.Equals("Aguardando Pagamento")).ToList();
            }

            if (cmbSituacao.Text.Equals("Em Atraso"))
            {
                itemVendas = new List<ItemVenda>();
                foreach (var itemVenda in item)
                {
                    var dataVencimento = Convert.ToDateTime(itemVenda.Venda.Data).AddDays(2);
                    int result = DateTime.Compare(DateTime.Now.Date, dataVencimento);

                    if (result > 0 && itemVenda.Venda.Situacao_Venda != "Pago")
                    {
                        itemVenda.Venda.Situacao_Venda = "Em Atraso";
                        itemVendas.Add(itemVenda);
                        serviceItemV.UpdateItemVenda(itemVenda);
                    }
                }
            }

            if (cmbSituacao.Text.Equals("A Vencer"))
            {
                itemVendas = new List<ItemVenda>();

                foreach (var itemVenda in item)
                {
                    var dataVencimento = Convert.ToDateTime(itemVenda.Venda.Data).AddDays(2).ToString("dd-MM-yyyy");
                    var date = DateTime.Now.ToString("dd-MM-yyyy");

                    if (dataVencimento.Equals(date) && itemVenda.Venda.Situacao_Venda != "Pago")
                    {
                        itemVenda.Venda.Situacao_Venda = "A Vencer";
                        itemVendas.Add(itemVenda);
                        serviceItemV.UpdateItemVenda(itemVenda);
                    }
                }
            }
        }


        private void ClearReportViewer()
        {
            rvRelatorioContaReceber.ResetPageSettings();
            rvRelatorioContaReceber.LocalReport.Refresh();
            this.rvRelatorioContaReceber.LocalReport.DataSources.Clear();
        }

        private void rvRelatorioContaReceber_ReportRefresh(object sender, CancelEventArgs e)
        {
            CreateReportViewer();
        }

        public void CreateItemVendaDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Status", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("DataLancamento", typeof(string));
            dt.Columns.Add("DataVencimento", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("Recebido", typeof(string));
            dt.Columns.Add("DataRecebimento", typeof(string));
            dt.Columns.Add("ValorRecebimento", typeof(string));
            dt.Columns.Add("FormaPagamento", typeof(string));
            dt.Columns.Add("Parcelamento", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));

            foreach (var itemVenda in itemVendas)
            {
                //CRIAR OUTRO CONSTRUTOR
                var FormRelatorioCR = new FormRelatorioContaReceber(itemVenda);

                dt.Rows.Add(new object[]
                {
                   FormRelatorioCR.Id,
                   FormRelatorioCR.Status,
                    FormRelatorioCR.Descricao,
                    FormRelatorioCR.DataLancamento,
                    FormRelatorioCR.DataVencimento,
                    FormRelatorioCR.Valor,
                    FormRelatorioCR.Recebido,
                    FormRelatorioCR.DataRecebimento,
                    FormRelatorioCR.ValorRecebimento,
                    FormRelatorioCR.FormaPagamento,
                    FormRelatorioCR.Parcelamento,
                    FormRelatorioCR.Cliente,
                });
            }
            totalConta = itemVendas.Count.ToString();
        }
    }
}
