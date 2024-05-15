using Microsoft.Reporting.WinForms;
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
    public partial class Frm_RelatorioVenda : Form
    {

        private IVendaPort serviceV;
        private IItemVendaPort serviceItemV;
        private List<ItemVenda> itemVendas;
        private ItemVenda itemVenda;
        private DataTable dt = new DataTable();
        private Frm_Principal frmprincipal;


        public Frm_RelatorioVenda(Frm_Principal formprincipal)
        {
            InitializeComponent();
            frmprincipal = formprincipal;
            UpdateReportViewer();
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy");
            AddComboBoxPeriodo();
        }

        private void Frm_RelatorioVenda_Load(object sender, EventArgs e)
        {
            this.rvRelatorioVenda.RefreshReport();
        }

        public void UpdateReportViewer()
        {
            serviceItemV = new ItemVendaService();
            serviceV = new VendaService();

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
            dt.Columns.Add("Cliente", typeof(string));

            if (itemVendas == null)
                itemVendas = serviceItemV.GetAllItemVenda();

            foreach (var itemVenda in itemVendas)
            {
                var FormRelatorioV = new FormRelatorioVenda(itemVenda);

                dt.Rows.Add(new object[]
                {
                    FormRelatorioV.Id,
                    FormRelatorioV.Produto,
                    FormRelatorioV.Quantidade,
                    FormRelatorioV.ValorUnitario,
                    FormRelatorioV.Total,
                    FormRelatorioV.Situacao,
                    FormRelatorioV.Data,
                    FormRelatorioV.Hora,
                    FormRelatorioV.Cliente,
                });
            }
        }
        private void AddComboBoxPeriodo()
        {
            var list = new List<string>();


            foreach (var item in itemVendas)
            {
                var date = item.Venda.Data;
                if (!list.Contains(date))
                    list.Add(date);
            }

            foreach (var data in list)
            {
                this.cmbPeriodo.Items.AddRange(new object[] {
                data
                });
            }
        }

        public void CreateReportViewer()
        {
            rvRelatorioVenda.LocalReport.DataSources.Clear();
            ReportDataSource reportDataSource = new ReportDataSource("DataSetVendas", dt);
            rvRelatorioVenda.LocalReport.ReportPath = "RelatorioVendas.rdlc";
            rvRelatorioVenda.LocalReport.DataSources.Add(reportDataSource);

            AddParameter("TotalVendas", itemVendas.Count.ToString());
            rvRelatorioVenda.LocalReport.Refresh();
        }

        public void AddParameter(string parameter, string value)
        {
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter(parameter, value);
            rvRelatorioVenda.LocalReport.SetParameters(parameters);
        }

        private void cmbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = serviceItemV.GetAllItemVenda();

            if (cmbPeriodo.SelectedIndex != -1)
            {
                itemVendas = item.Where(x => x.Venda.Situacao_Venda.Equals(cmbSituacao.Text) &&
                x.Venda.Data.Equals(cmbPeriodo.Text)).ToList();
            }
            else
            {
                itemVendas = item.Where(x => x.Venda.Situacao_Venda.Equals(cmbSituacao.Text)).ToList();
            }

            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioVenda.RefreshReport();
        }

        private void ClearReportViewer()
        {
            rvRelatorioVenda.ResetPageSettings();
            rvRelatorioVenda.LocalReport.Refresh();
            this.rvRelatorioVenda.LocalReport.DataSources.Clear();
        }

        private void rvRelatorioVenda_ReportRefresh(object sender, CancelEventArgs e)
        {
            CreateReportViewer();
        }

        private void cmbPeriodo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = serviceItemV.GetAllItemVenda();

            //Utilizando o filtro de pesquisa por periodo e situação
            if (cmbSituacao.SelectedIndex !=-1)
            {
                itemVendas = item.Where(x => x.Venda.Data.Equals(cmbPeriodo.Text) && 
                x.Venda.Situacao_Venda.Equals(cmbSituacao.Text) ).ToList();
            }
            else
            {
                itemVendas = item.Where(x => x.Venda.Data.Equals(cmbPeriodo.Text)).ToList();
            }

            ClearReportViewer();
            UpdateReportViewer();
            rvRelatorioVenda.RefreshReport();
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var venda = new Frm_Venda(frmprincipal);
            this.Hide();
        }
    }
}
