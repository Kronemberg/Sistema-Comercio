using SistemaComercioBiblioteca.Classes;
using SistemaComercioLibrary.Classes;
using SistemaComercioLibrary.Port;
using SistemaComercioLibrary.Service;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaComercio.Gui
{
    public partial class Frm_Fornecedor : Form
    {
        private IFornecedorPort service = new FornecedorService();
        DataTable dt = new DataTable();
        Fornecedor forne = null;
        private Frm_Principal formPrincipal;

        public Frm_Fornecedor(Frm_Principal frm_Principal)
        {
            InitializeComponent();
            formPrincipal = frm_Principal;
            UpdateProviderInDataGrid();
            dataGridViewForne.ReadOnly = true;
        }
        private void Frm_Fornecedor_Load(object sender, EventArgs e)
        {
          dataGridViewForne.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
          dataGridViewForne.DataSource = service.GetAllFornecedor();
        }


        #region DataGridView
        private void UpdateProviderInDataGrid()
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

            var fornecedores = service.GetAllFornecedor();

            foreach (var fornecedor in fornecedores)
            {
                dt.Rows.Add(new object[]
                {
                    fornecedor.Id,
                    fornecedor.Nome,
                    fornecedor.Cpf_Cnpj,
                    fornecedor.Logradouro,
                    fornecedor.Numero,
                    fornecedor.Complemento,
                    fornecedor.Bairro,
                    fornecedor.Cidade,
                    fornecedor.Estado,
                    fornecedor.Cep,
                    fornecedor.Telefone,
                    fornecedor.Email,
                });

            }

            dataGridViewForne.DataSource = dt;
            formPrincipal.GetCount();
        }

        private void FormattingCollumns(object sender, DataGridViewCellEventArgs e)
        {
            //quando clica em editar pega ele
            if (dataGridViewForne.Columns[e.ColumnIndex] == dataGridViewForne.Columns["Editar"])
            {
                //preciso pegar o id dele pra saber qm é
                var id = dataGridViewForne.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                forne = service.GetByIdFornecedor(Convert.ToInt32(id));

                txtNome.Text = forne.Nome;
                txtCPF.Text = forne.Cpf_Cnpj;
                txtLogra.Text = forne.Logradouro;
                txtNum.Text = forne.Numero;
                txtComple.Text = forne.Complemento;
                txtBairro.Text = forne.Bairro;
                txtCidade.Text = forne.Cidade;
                txtEstado.Text = forne.Estado;
                txtCEP.Text = forne.Cep;
                txtTel.Text = forne.Telefone;
                txtEmail.Text = forne.Email;

                btnSalvar.Enabled = true;
                btnCad.Enabled = false;
            }

            //quando clica em excluir pega ele
            if (dataGridViewForne.Columns[e.ColumnIndex] == dataGridViewForne.Columns["Excluir"])
            {
                if (MessageBox.Show("Deseja mesmo remover este fornecedor?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //preciso pegar o id dele pra saber qm é
                    var id = Convert.ToInt32(dataGridViewForne.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                    RemoveProvider(id);
                }
            }
        } //CellContentClick

        private void FormattingRows(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //centraliza os dados da coluna
            dataGridViewForne.Columns["Id"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Nome"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Cpf_Cnpj"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Logradouro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Numero"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Complemento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Bairro"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Cidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["CEP"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Telefone"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewForne.Columns["Email"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            foreach (DataGridViewColumn coluna in dataGridViewForne.Columns)
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
                        coluna.Width = 115;
                        break;
                

                    //A
                }
            }
        } //DataBindingComplete

        private void FormatttingMensageRows(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //e -> PEGA TODA A LINHA 
            dataGridViewForne.Rows[e.RowIndex].Cells["Editar"].ToolTipText = "Editar Fornecedor";
            dataGridViewForne.Rows[e.RowIndex].Cells["Excluir"].ToolTipText = "Excluir Fornecedor";
        } //CellFormatting

        #endregion

        #region Clicks Botões Form

        private void ClickLimpar(object sender, EventArgs e)
        {
            LimparCampos();
            MessageBox.Show("Campos resetados!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClickPesquisar(object sender, EventArgs e)
        {
            UpdateProviderInDataGrid();
            dt.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", "Nome", txtProcurar.Text);
            dataGridViewForne.DataSource = dt;
        }

        private void ClickSalvar(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                Id = forne.Id,
                Nome = txtNome.Text,
                Cpf_Cnpj = txtCPF.Text,
                Telefone = txtTel.Text,
                Cep = txtCEP.Text,
                Cidade = txtCidade.Text,
                Complemento = txtComple.Text,
                Email = txtEmail.Text,
                Estado = txtEstado.Text,
                Logradouro = txtLogra.Text,
                Numero = txtNum.Text,
                Bairro = txtBairro.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.UpdateFornecedor(fornecedor);
                    UpdateProviderInDataGrid(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
                    MessageBox.Show("Fornecedor editado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao editar fornecedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickCadastrar(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
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
                Numero = txtNum.Text,
                Bairro = txtBairro.Text,
            };

            try
            {
                //FAZER COM TODOS OS CAMPOS
                if (ValidarCampos())
                {
                    service.AddFornecedor(fornecedor);
                    dataGridViewForne.DataSource = service.GetAllFornecedor(); //trazer o fornecedor q acabamos de cadastrar no dataGrid
                    LimparCampos();
                    MessageBox.Show("Fornecedor cadastrado!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Você deve preencher todos os campos!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao cadastrar fornecedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClickSair(object sender, EventArgs e)
        {
            var principal = new Frm_Principal();
            this.Hide();
        }

        #endregion


        #region Funções


        private void RemoveProvider(int id)
        {
            forne = service.GetByIdFornecedor(id);
            try
            {
                service.DelFornecedor(forne);
                UpdateProviderInDataGrid();
                MessageBox.Show("Fornecedor excluido!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao excluir fornecedor!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

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
            btnCad.Enabled = true;
            btnSalvar.Enabled = false;
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

        #endregion

    }
}
