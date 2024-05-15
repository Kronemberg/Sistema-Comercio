using SistemaComercioLibrary.Entity;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Windows.Forms;

namespace SistemaComercio
{
    public partial class Frm_Cadastro : Form
    {
        IAdmPort service = new AdmService();

        public Frm_Cadastro()
        {
            InitializeComponent();
        }


        private void ClickSalvar(object sender, EventArgs e)
        {
            var adm = new Adm()
            {
                Senha = TxtSenhaCad.Text,
                Usuario = TxtUsuarioCad.Text,
                Salario = 30000,
                
            };

            service.AddAdm(adm);
            MessageBox.Show("Cadastro realizado com sucesso", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            var login = new Frm_Login();
            this.Hide();
        }

        private void ClickCancelar(object sender, EventArgs e)
        {
            var login = new Frm_Login();
            this.Hide();
        }
    }
}
