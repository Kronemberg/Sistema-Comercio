using Microsoft.Reporting.WinForms;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_RelatorioCaixa : Form
    {
        private IMovimentoCaixaPort service;
        private List<MovimentoCaixa> movimentos;
        private MovimentoCaixa movimento;
        private DataTable dt = new DataTable();

        public Frm_RelatorioCaixa()
        {
            InitializeComponent();
            UpdateReportViewer();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Frm_RelatorioCaixa_Load(object sender, EventArgs e)
        {
            this.rvRelatorioCaixa.RefreshReport();
        }

        public void UpdateReportViewer()
        {
            service = new MovimentoCaixaService();

            CreateDataTable();
            CreateReportViewer();
        }

        public void CreateDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("TipoMovimento", typeof(string));
            dt.Columns.Add("Descricao", typeof(string));
            dt.Columns.Add("Valor", typeof(string));
            dt.Columns.Add("FormaPagamento", typeof(string));
            dt.Columns.Add("Parcelamento", typeof(string));


            if (movimentos == null)
                movimentos = service.GetAllMovimentoCaixa();

            foreach (var movimento in movimentos)
            {
                var FormRelatorioCaixa = new FormRelatorioCaixa(movimento);

                dt.Rows.Add(new object[]
                {
                    FormRelatorioCaixa.Id,
                    FormRelatorioCaixa.TipoMovimento,
                    FormRelatorioCaixa.Descricao,
                    FormRelatorioCaixa.Valor,
                    FormRelatorioCaixa.FormaPagamento,
                    FormRelatorioCaixa.Parcelamento,

                }); ;
            }

        }

        public void CreateReportViewer()
        {
            rvRelatorioCaixa.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSetCaixa", dt);
            rvRelatorioCaixa.LocalReport.ReportPath = "RelatorioCaixa.rdlc";
            rvRelatorioCaixa.LocalReport.DataSources.Add(reportDataSource);

            //AddParameter("TotalCompra", movimentos.Count.ToString());
            rvRelatorioCaixa.LocalReport.Refresh();
        }

        public void AddParameter(string parameter, string value)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter(parameter, value);
            rvRelatorioCaixa.LocalReport.SetParameters(parameters);
        }

        private void ClearReportViewer()
        {
            rvRelatorioCaixa.ResetPageSettings();
            rvRelatorioCaixa.LocalReport.Refresh();
            this.rvRelatorioCaixa.LocalReport.DataSources.Clear();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var caixa = new Frm_Caixa();
            this.Hide();
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = service.GetAllMovimentoCaixa();

            movimentos = item.Where(x => x.FormaPagamento.Equals(cmbFiltro.Text)).ToList();
            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioCaixa.RefreshReport();
        }
    }
}
