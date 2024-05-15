using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Cliente : Form
    {
        private IClientePort service = new ClienteService();
        Frm_Principal telaPrincipal;
        DataTable dt = new DataTable();
        Cliente cli = null;

        public Frm_Cliente(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            UpdateClientInDataGrid();
            telaPrincipal = frm_Principal;
            dataGridViewCli.ReadOnly = true;
        }


        private void UpdateClientInDataGrid()
        {
            dt = new DataTable();
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Cpf_Cnpj", typeof(string));
            dt.Columns.Add("Logradouro", typeof(string));
            dt.Columns.Add("Numero", typeof(string));
            dt.Columns.Add("Complemento", typeof(string));
            dt.Columns.Add("Bairro", typeof(string));
            dt.Columns.Add("Cidade", typeof(string));
            dt.Columns.Add("Estado", typeof(string));
            dt.Columns.Add("CEP", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));
            dt.Columns.Add("Email", typeof(string));

            var clientes = service.GetAllCliente();

            foreach (var cliente in clientes)
            {
                dt.Rows.Add(new object[]
                {
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf_Cnpj,
                    cliente.Logradouro,
                    cliente.Numero,
                    cliente.Complemento,
                    cliente.Bairro,
                    cliente.Cidade,
                    cliente.Estado,
                    cliente.Cep,
                    cliente.Telefone,
                    cliente.Email,
                });

            }

            dataGridViewCli.DataSource = dt;
        }

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e) //DataBindingComplete
        {
            //centraliza os dados da coluna
            dataGridViewCli.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Cpf_Cnpj"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Cidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["CEP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCli.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewCli.Columns)
            {
                switch (coluna.Name)
                {
                    case "Excluir":
                        //coluna.DisplayIndex = 1; se quiser mudar a posição 
                        coluna.Width = 30;
                        break;
                    case "Editar":
                        coluna.Width = 30;
                        break;
                    case "Id":
                        coluna.Width = 30;
                        break;
                    case "Nome":
                        coluna.Width = 115;
                        break;
                    case "Cpf_Cnpj":
                        coluna.Width = 100;
                        break;
                    case "Logradouro":
                        coluna.Width = 115;
                        break;
                    case "Numero":
                        coluna.Width = 55;
                        break;
                    case "Complemento":
                        coluna.Width = 115;
                        break;
                    case "Bairro":
                        coluna.Width = 115;
                        break;
                    case "Cidade":
                        coluna.Width = 115;
                        break;
                    case "Estado":
                        coluna.Width = 115;
                        break;
                    case "CEP":
                        coluna.Width = 115;
                        break;
                    case "Telefone":
                        coluna.Width = 115;
                        break;
                    case "Email":
                        coluna.Width = 150;
                        break;
                }
            }
        }

        private void FormattingCollunms(object sender, DataGridViewCellEventArgs e)
        {
            //quando clica em editar pega ele
            if (dataGridViewCli.Columns[e.ColumnIndex] == dataGridViewCli.Columns["Editar"])
            {
                //preciso pegar o id dele pra saber qm é
                var id = dataGridViewCli.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                cli = service.GetByIdCliente(Convert.ToInt32(id));

                txtNome.Text = cli.Nome;
                txtCPF.Text = cli.Cpf_Cnpj;
                txtLogra.Text = cli.Logradouro;
                txtNum.Text = cli.Numero.ToString();
                txtComple.Text = cli.Complemento;
                txtBairro.Text = cli.Bairro;
                txtCidade.Text = cli.Cidade;
                txtEstado.Text = cli.Estado;
                txtCEP.Text = cli.Cep;
                txtTel.Text = cli.Telefone;
                txtEmail.Text = cli.Email;

                btnSalvar.Enabled = true;
                btnCadastrar.Enabled = false;
            }

            //quando clica em excluir pega ele
            if (dataGridViewCli.Columns[e.ColumnIndex] == dataGridViewCli.Columns["Excluir"])
            {
                if (MessageBox.Show("Deseja mesmo remover este cliente?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //preciso pegar o id dele pra saber qm é
                    var id = Convert.ToInt32(dataGridViewCli.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    RemoveClient(id);
                }
            }
        } //CellContentClick

        private void RemoveClient(int id)
        {
            cli = service.GetByIdCliente(id);
            try
            {
                service.DelCliente(cli);
                UpdateClientInDataGrid();
                MessageBox.Show("Cliente excluido!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormatttingMensageRows(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //e -> PEGA TODA A LINHA 
            dataGridViewCli.Rows[e.RowIndex].Cells["Editar"].ToolTipText = "Editar Cliente";
            dataGridViewCli.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Excluir Cliente";
        } //CellFormatting

        private void LimparCampos()
        {
            txtNome.Clear();
            txtTel.Clear();
            txtCidade.Clear();
            txtEmail.Clear();
            txtLogra.Clear();
            txtCPF.Clear();
            txtCEP.Clear();
            txtComple.Clear();
            txtEstado.Clear();
            txtNum.Clear();
            txtBairro.Clear();
            btnCadastrar.Enabled = true;
            btnSalvar.Enabled = false;
        }

        private void ClickLimpar(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickPesquisar(object sender, EventArgs e)
        {
            UpdateClientInDataGrid();
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", "Nome", txtPesquisa.Text);
            dataGridViewCli.DataSource = dt;
        }

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            dataGridViewCli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCli.DataSource = service.GetAllCliente();
        }

        private void ClickSalvar(object sender, EventArgs e)
        {
            //service.GetByNomeCliente(txtNome.Text);

            var cliente = new Cliente()
            {
                Id = cli.Id,
                Nome = txtNome.Text,
                Cpf_Cnpj = txtCPF.Text,
                Telefone = txtTel.Text,
                Cep = txtCEP.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComple.Text,
                Email = txtEmail.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogra.Text,
                Numero = Convert.ToInt32(txtNum.Text),
                Bairro = txtBairro.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.UpdateCliente(cliente);
                    UpdateClientInDataGrid(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
                    MessageBox.Show("Cliente editado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCadastrar(object sender, EventArgs e)
        {
            var cliente = new Cliente()
            {
                Nome = txtNome.Text,
                Cpf_Cnpj = txtCPF.Text,
                Telefone = txtTel.Text,
                Cep = txtCEP.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComple.Text,
                Email = txtEmail.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogra.Text,
                Numero = Convert.ToInt32(txtNum.Text),
                Bairro = txtBairro.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.AddCliente(cliente);
                    dataGridViewCli.DataSource = service.GetAllCliente();
                    LimparCampos();
                    telaPrincipal.GetCount();
                    MessageBox.Show("Cliente cadastrado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar cliente!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        bool ValidarCampos()
        {
            //FAZER COM TODOS OS CAMPOS
            if (String.IsNullOrEmpty(txtNome.Text) || String.IsNullOrEmpty(txtCPF.Text) ||
                String.IsNullOrEmpty(txtTel.Text) || String.IsNullOrEmpty(txtCEP.Text) ||
                String.IsNullOrEmpty(txtCidade.Text) || String.IsNullOrEmpty(txtComple.Text) ||
                String.IsNullOrEmpty(txtEmail.Text) || String.IsNullOrEmpty(txtEstado.Text) ||
                String.IsNullOrEmpty(txtLogra.Text) || String.IsNullOrEmpty(txtNum.Text) || String.IsNullOrEmpty(txtBairro.Text))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

    }
}


