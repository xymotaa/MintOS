using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MintOs
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            // this em C# é chamado de "referência implícita" e se refere à instância atual da classe.
            // close() é um método que fecha a janela atual, liberando todos os recursos associados a ela.
            this.Close();
        }

        private void MenuCadastroFuncionários_Click(object sender, EventArgs e)
        {
            // Depois do duplo clique, primeiro se chama a pasta
            // Depois do duplo clique, se chaama o formulário de cadastro
            // Depois de chamar o formulário, cria uma estância do formulário e exibe ele como uma janela modal
            // O ShowDialog() exibe o formulário como uma janela modal, ou seja, o usuário não pode interagir com a janela principal até que a janela modal seja fechada.
            cadastro.FrmCadastro Frm = new cadastro.FrmCadastro();
            Frm.ShowDialog();
        }
    }
}

