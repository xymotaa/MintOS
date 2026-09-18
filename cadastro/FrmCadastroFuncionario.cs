using System;
using System.Windows.Forms;
using System.IO;
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
                        (nome, cpf, telefone, cargo, endereco, foto)
                        VALUES
                        (@nome, @cpf, @telefone, @cargo, @endereco, @foto);
                    ";

                    using (MySqlCommand comando = new MySqlCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@nome", textNome.Text);
                        comando.Parameters.AddWithValue("@cpf", textCpf.Text);
                        comando.Parameters.AddWithValue("@telefone", textTelefone.Text);
                        comando.Parameters.AddWithValue("@cargo", comboBoxCargo.Text);
                        comando.Parameters.AddWithValue("@endereco", textEndereco.Text);
                        // Ler os bytes da imagem (ou DBNull se não houver imagem)
                        var fotoBytes = LerImagemComoBytes();
                        comando.Parameters.AddWithValue("@foto", (object)fotoBytes ?? DBNull.Value);

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
                // Caminho selecionado pelo usuário
                var caminhoSelecionado = dialog.FileName;

                try
                {
                    // Diretório de armazenamento das imagens da aplicação (AppData) para não depender de caminhos locais do usuário
                    // Usar AppData evita problemas de permissões e mantém todas as imagens centralizadas
                    var pastaImagens = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MintOs", "images");
                    if (!Directory.Exists(pastaImagens))
                        Directory.CreateDirectory(pastaImagens);

                    // Gerar nome único para evitar colisões (GUID) e preservar extensão original
                    var extensao = Path.GetExtension(caminhoSelecionado);
                    var nomeArquivo = Guid.NewGuid().ToString() + extensao;
                    var destino = Path.Combine(pastaImagens, nomeArquivo);

                    // Copiar o arquivo selecionado para a pasta da aplicação
                    File.Copy(caminhoSelecionado, destino, overwrite: true);

                    // Armazenamos no campo 'foto' o caminho completo (poderíamos armazenar relativo conforme necessidade)
                    foto = destino;

                    // Exibir no PictureBox a imagem copiada
                    pictureBoxFoto.ImageLocation = foto;
                }
                catch (Exception ex)
                {
                    // Em caso de falha ao copiar/abrir a imagem, informar o usuário e não setar o caminho
                    MessageBox.Show($"Erro ao processar a imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    foto = null;
                }
            }
        }

        /// <summary>
        /// Lê o arquivo de imagem selecionado (campo 'foto') e retorna um array de bytes.
        /// Motivos das verificações/implementação:
        /// - Verifica se a variável 'foto' é nula/whitespace e se o arquivo existe para evitar exceções.
        /// - Usa File.ReadAllBytes para ler o arquivo de forma atômica e garantir o fechamento do stream.
        /// - Captura exceções e retorna null em falha; o código que chama converte null para DBNull para o banco.
        /// </summary>
        private byte[] LerImagemComoBytes()
        {
            // Se não houver caminho definido, retorna null (será traduzido para DBNull no parâmetro SQL)
            if (string.IsNullOrWhiteSpace(foto))
                return null;

            // Evita tentar abrir um arquivo inexistente
            if (!File.Exists(foto))
                return null;

            try
            {
                // File.ReadAllBytes abre o arquivo, lê tudo e fecha automaticamente
                return File.ReadAllBytes(foto);
            }
            catch (Exception)
            {
                // Em caso de erro ao ler o arquivo, retorna null para que o código que chama lide com isso
                // (p.ex. gravar DBNull no banco). Poderíamos também logar o erro ou exibir mensagem ao usuário.
                return null;
            }
        }
    }
}