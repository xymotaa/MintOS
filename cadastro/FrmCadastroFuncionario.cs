using System;
using System.Windows.Forms;
using System.IO;
using System.Data;
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
            // Associa eventos que não foram configurados no Designer
            this.Load += FrmCadastroFuncionario_Load;
            btnExcluir.Click += btnExcluir_Click;
        }

        /// <summary>
        /// Exclui o funcionário selecionado no DataGridView e remove a imagem associada do disco.
        /// Procedimento:
        /// 1. Verifica seleção
        /// 2. Pede confirmação ao usuário
        /// 3. Lê o nome do arquivo da coluna 'foto'
        /// 4. Executa DELETE no banco
        /// 5. Se DELETE bem-sucedido, remove o arquivo físico (DeleteImageFile) e recarrega grid
        /// </summary>
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecione um funcionário para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tentar obter o id (coluna 'id') da linha selecionada; fallback para célula 0
            var row = dataGridView1.CurrentRow;
            object idObj = null;
            try { idObj = row.Cells["id"].Value; } catch { idObj = row.Cells[0].Value; }

            if (idObj == null)
            {
                MessageBox.Show("Não foi possível determinar o id do funcionário selecionado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(idObj.ToString(), out int id))
            {
                MessageBox.Show("Id do funcionário inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show("Confirma exclusão do funcionário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // Obter nome do arquivo da coluna 'foto' (se existir)
            string fotoNome = null;
            try { fotoNome = row.Cells["foto"].Value?.ToString(); } catch { fotoNome = null; }

            try
            {
                using var conexao = Conexao.Criar();
                conexao.Open();

                using var cmd = new MySqlCommand("DELETE FROM funcionarios WHERE id = @id", conexao);
                cmd.Parameters.AddWithValue("@id", id);
                var afetadas = cmd.ExecuteNonQuery();

                if (afetadas > 0)
                {
                    // Apagar arquivo de imagem referente (se houver)
                    if (!string.IsNullOrWhiteSpace(fotoNome))
                        DeleteImageFile(fotoNome);

                    MessageBox.Show("Funcionário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadFuncionarios();
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi excluído. Verifique se o item existe.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir funcionário: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Carrega os funcionários do banco e popula o DataGridView.
        /// Método simples que busca colunas essenciais e atribui um DataTable como DataSource.
        /// </summary>
        private void LoadFuncionarios()
        {
            try
            {
                using var conexao = Conexao.Criar();
                conexao.Open();

                var sql = "SELECT id, nome, cpf, telefone, cargo, endereco, foto FROM funcionarios ORDER BY id DESC";
                using var cmd = new MySqlCommand(sql, conexao);
                using var adapter = new MySqlConnector.MySqlDataAdapter(cmd);
                var dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCadastroFuncionario_Load(object? sender, EventArgs e)
        {
            // Carrega lista de funcionários ao abrir o formulário
            LoadFuncionarios();
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

        /// <summary>
        /// Retorna o caminho completo da pasta onde as imagens são armazenadas.
        /// Usamos %APPDATA%\MintOs\images para centralizar e evitar problemas de permissão.
        /// </summary>
        private string GetImagesFolderPath()
        {
            return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MintOs", "images");
        }

        /// <summary>
        /// Retorna o caminho completo do arquivo de imagem a partir do nome armazenado no banco.
        /// Retorna null se o nome for nulo/whitespace.
        /// </summary>
        public string GetImageFullPath(string imageFileName)
        {
            if (string.IsNullOrWhiteSpace(imageFileName))
                return null;

            return Path.Combine(GetImagesFolderPath(), imageFileName);
        }

        /// <summary>
        /// Remove o arquivo de imagem do disco se existir. Usar quando for excluir/atualizar um registro
        /// que referencia a imagem para evitar arquivos órfãos.
        /// </summary>
        public void DeleteImageFile(string imageFileName)
        {
            if (string.IsNullOrWhiteSpace(imageFileName))
                return;

            try
            {
                var fullPath = GetImageFullPath(imageFileName);
                if (fullPath != null && File.Exists(fullPath))
                    File.Delete(fullPath);
            }
            catch
            {
                // Falhas ao deletar não devem quebrar a aplicação; podemos logar se necessário.
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

                    // Armazenamos apenas o NOME do arquivo no campo 'foto' (mais portátil e economiza espaço no DB)
                    foto = nomeArquivo;

                    // Exibir no PictureBox a imagem copiada usando o caminho completo
                    pictureBoxFoto.ImageLocation = destino;
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