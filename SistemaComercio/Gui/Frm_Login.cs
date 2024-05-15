using SistemaComercio.Gui;
using SistemaComercioLibrary.Classes;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SistemaComercio
{
    public partial class Frm_Login : Form
    {
        private IAdmPort service = new AdmService();
        private ICaixaPort serviceCaixa = new CaixaService();

        public Frm_Login()
        {
            InitializeComponent();
            CreateEntityCaixa();
        }

        private void ClickEntrar(object sender, EventArgs e)
        {

            var usuario = TxtUsuario.Text;
            var senha = TxtSenha.Text;

            var auth = service.Login(usuario, senha);


            if(auth)
            {
                var user = service.GetByUser(usuario);

                MessageBox.Show("Bem vindo " + TxtUsuario.Text + "!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var principal = new Frm_Principal(user);
                this.Hide();
                principal.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuário " + TxtUsuario.Text + " inválido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCancelar(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClickCadastre(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_Cadastro cadastro = new Frm_Cadastro();
            cadastro.Show();
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
        }
    }
}
