using System;
using System.Windows.Forms;
using MySqlConnector;
using MintOs.Banco;

namespace MintOs.cadastro
{
    public partial class FrmCadastroFuncionario : Form
    {
        string foto;

        public FrmCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Validação dos campos
            if (string.IsNullOrWhiteSpace(textNome.Text))
            {
                MessageBox.Show(
                    "Informe o nome do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textNome.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textCpf.Text))
            {
                MessageBox.Show(
                    "Informe o CPF do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textCpf.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textTelefone.Text))
            {
                MessageBox.Show(
                    "Informe o telefone do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textTelefone.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(textEndereco.Text))
            {
                MessageBox.Show(
                    "Informe o endereço do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                textEndereco.Focus();
                return;
            }

            if (comboBoxCargo.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Selecione o cargo do funcionário.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                comboBoxCargo.Focus();
                return;
            }

            try
            {
                using (MySqlConnection conexao = Conexao.Criar())
                {
                    conexao.Open();

                    string sql = @"
                        INSERT INTO funcionarios
                        (nome, cpf, telefone, cargo, endereco)
                        VALUES
                        (@nome, @cpf, @telefone, @cargo, @endereco);
                    ";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textNome.Text);
                        comando.Parameters.AddWithValue("@cpf", textCpf.Text);
                        comando.Parameters.AddWithValue("@telefone", textTelefone.Text);
                        comando.Parameters.AddWithValue("@cargo", comboBoxCargo.Text);
                        comando.Parameters.AddWithValue("@endereco", textEndereco.Text);

                        comando.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    "Funcionário cadastrado com sucesso!",
                    "MintOS",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Erro ao cadastrar funcionário:\n\n" + ex.Message,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void LimparCampos()
        {
            textNome.Clear();
            textCpf.Clear();
            textTelefone.Clear();
            textEndereco.Clear();

            comboBoxCargo.SelectedIndex = -1;

            pictureBoxFoto.Image = null;

            foto = null;

            textNome.Focus();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Imagens (*.jpg;*.png)|*.jpg;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foto = dialog.FileName;

                pictureBoxFoto.ImageLocation = foto;
            }
        }
    }
}