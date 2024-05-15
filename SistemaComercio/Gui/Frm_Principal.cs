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
    public partial class Frm_Principal : Form
    {
        IFornecedorPort serviceForne = new FornecedorService();
        IClientePort serviceCli = new ClienteService();
        IVendaPort serviceVenda = new VendaService();
        ICompraPort serviceCompra = new CompraService();
        IProdutoPort serviceProduto = new ProdutoService();
        IAdmPort serviceAdm = new AdmService();
        public Adm user;

        public Frm_Principal(Adm usuario)
        {
            InitializeComponent();
            user = usuario;
            LblNomeAdm.Text = usuario.Usuario;
            GetCount();

        }

        public Frm_Principal()
        {
        }

        public void GetCount()
        {
            LblQuantForne.Text = serviceForne.Count().ToString();
            LblQuantCli.Text = serviceCli.Count().ToString();
            LblVend.Text = serviceVenda.Count().ToString();
            LblCmpr.Text = serviceCompra.Count().ToString();
            LblQuantProd.Text = serviceProduto.Count().ToString();
        }

        public void UpdateSalarioUser(double valor)
        {
            
        }

        private void ClickCliente(object sender, EventArgs e)
        {
            Frm_Cliente cliente = new Frm_Cliente(this);
            cliente.Show();
        }


        private void ClickFornecedor(object sender, EventArgs e)
        {
            Frm_Fornecedor fornecedor = new Frm_Fornecedor(this);
            fornecedor.Show();
        }
  

        private void ClickProduto(object sender, EventArgs e)
        {
            Frm_Produto produto = new Frm_Produto(this);
            produto.Show();
        }

        private void ClickCompra(object sender, EventArgs e)
        {
            Frm_Compra compra = new Frm_Compra(this);
            compra.Show();
        }

        private void ClickVenda(object sender, EventArgs e)
        {
            Frm_Venda venda = new Frm_Venda(this);
            venda.Show();
        }

        private void ClickContaPagar(object sender, EventArgs e)
        {
            Frm_ContaPagar contaP = new Frm_ContaPagar(this);
            contaP.Show();
        }

        private void ClickContaReceber(object sender, EventArgs e)
        {
            Frm_ContaReceber contaR = new Frm_ContaReceber(this);
            contaR.Show();
        }

        private void ClickCaixa(object sender, EventArgs e)
        {
            Frm_Caixa caixa = new Frm_Caixa();
            caixa.Show();
        }
    }
}
