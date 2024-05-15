using Microsoft.Reporting.WinForms;
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
    public partial class Frm_RelatorioCompra : Form
    {
        private ICompraPort serviceC;
        private IItemCompraPort serviceItemC;
        private List<ItemCompra> itemCompras;
        private ItemCompra itemCompra;
        private DataTable dt = new DataTable();
        private Frm_Principal frmprincipal;


        public Frm_RelatorioCompra(Frm_Principal formprincipal)
        {
            InitializeComponent();
            frmprincipal = formprincipal;
            UpdateReportViewer();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Frm_RelatorioCompra_Load(object sender, EventArgs e)
        {
            this.rvRelatorioCompra.RefreshReport();
        }

        public void UpdateReportViewer()
        {
            serviceItemC = new ItemCompraService();
            serviceC = new CompraService();

            CreateDataTable();
            CreateReportViewer();
        }

        public void CreateDataTable()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Produto", typeof(string));
            dt.Columns.Add("Quantidade", typeof(string));
            dt.Columns.Add("ValorUnitario", typeof(string));
            dt.Columns.Add("Total", typeof(string));
            dt.Columns.Add("Situacao", typeof(string));
            dt.Columns.Add("Data", typeof(string));
            dt.Columns.Add("Hora", typeof(string));
            dt.Columns.Add("Fornecedor", typeof(string));

            if (itemCompras == null)
                itemCompras = serviceItemC.GetAllItemCompra();

            foreach (var itemCompra in itemCompras)
            {
                var FormRelatorioC = new FormRelatorioCompra(itemCompra);

                dt.Rows.Add(new object[]
                {
                    FormRelatorioC.Id,
                    FormRelatorioC.Produto,
                    FormRelatorioC.Quantidade,
                    FormRelatorioC.ValorUnitario,
                    FormRelatorioC.Total,
                    FormRelatorioC.Situacao,
                    FormRelatorioC.Data,
                    FormRelatorioC.Hora,
                    FormRelatorioC.Fornecedor,
                });
            }

        }

        public void CreateReportViewer()
        {
            rvRelatorioCompra.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("ItemCompras", dt);
            rvRelatorioCompra.LocalReport.ReportPath = "RelatorioCompras.rdlc";
            rvRelatorioCompra.LocalReport.DataSources.Add(reportDataSource);

            AddParameter("TotalCompra", itemCompras.Count.ToString());
            rvRelatorioCompra.LocalReport.Refresh();
        }


        public void AddParameter(string parameter, string value)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter(parameter, value);
            rvRelatorioCompra.LocalReport.SetParameters(parameters);
        }


        private void rvRelatorioCompra_Load(object sender, EventArgs e)
        {


        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = serviceItemC.GetAllItemCompra();
            itemCompras = item.Where(x => x.Compra.Situacao_Compra.Equals(cmbStatus.Text)).ToList();
            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioCompra.RefreshReport();
        }

        private void ClearReportViewer()
        {
            rvRelatorioCompra.ResetPageSettings();
            rvRelatorioCompra.LocalReport.Refresh();
            this.rvRelatorioCompra.LocalReport.DataSources.Clear();
        }

        private void rvRelatorioCompra_ReportRefresh(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CreateReportViewer();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var compra = new Frm_Compra(frmprincipal);
            this.Hide();
        }
    }
}
