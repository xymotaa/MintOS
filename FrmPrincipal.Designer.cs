namespace MintOs
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroFuncionários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroUsuários = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroCargos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProdutosEstoque = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentaçõesFluxoDeCaixa = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentaçõesLançamentoDeVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentaçõesEntradaSaídas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentaçõesDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatóriosProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórioVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatóriosMovimentos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatóriosEntradaSaídas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatóriosDespesas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.Img03 = new System.Windows.Forms.PictureBox();
            this.Img04 = new System.Windows.Forms.PictureBox();
            this.Img02 = new System.Windows.Forms.PictureBox();
            this.Img01 = new System.Windows.Forms.PictureBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img03)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img04)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img02)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img01)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuProdutos,
            this.MenuMovimentações,
            this.MenuRelatorios,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(894, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastroFuncionários,
            this.MenuCadastroClientes,
            this.MenuCadastroUsuários,
            this.MenuCadastroCargos,
            this.MenuCadastroFornecedores});
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(66, 20);
            this.MenuCadastro.Text = "Cadastro";
            // 
            // MenuCadastroFuncionários
            // 
            this.MenuCadastroFuncionários.Name = "MenuCadastroFuncionários";
            this.MenuCadastroFuncionários.Size = new System.Drawing.Size(145, 22);
            this.MenuCadastroFuncionários.Text = "Funcionários";
            this.MenuCadastroFuncionários.Click += new System.EventHandler(this.MenuCadastroFuncionários_Click);
            // 
            // MenuCadastroClientes
            // 
            this.MenuCadastroClientes.Name = "MenuCadastroClientes";
            this.MenuCadastroClientes.Size = new System.Drawing.Size(145, 22);
            this.MenuCadastroClientes.Text = "Clientes";
            // 
            // MenuCadastroUsuários
            // 
            this.MenuCadastroUsuários.Name = "MenuCadastroUsuários";
            this.MenuCadastroUsuários.Size = new System.Drawing.Size(145, 22);
            this.MenuCadastroUsuários.Text = "Usuários";
            // 
            // MenuCadastroCargos
            // 
            this.MenuCadastroCargos.Name = "MenuCadastroCargos";
            this.MenuCadastroCargos.Size = new System.Drawing.Size(145, 22);
            this.MenuCadastroCargos.Text = "Cargos";
            // 
            // MenuCadastroFornecedores
            // 
            this.MenuCadastroFornecedores.Name = "MenuCadastroFornecedores";
            this.MenuCadastroFornecedores.Size = new System.Drawing.Size(145, 22);
            this.MenuCadastroFornecedores.Text = "Fornecedores";
            // 
            // MenuProdutos
            // 
            this.MenuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProdutosProdutos,
            this.MenuProdutosEstoque});
            this.MenuProdutos.Name = "MenuProdutos";
            this.MenuProdutos.Size = new System.Drawing.Size(67, 20);
            this.MenuProdutos.Text = "Produtos";
            // 
            // MenuProdutosProdutos
            // 
            this.MenuProdutosProdutos.Name = "MenuProdutosProdutos";
            this.MenuProdutosProdutos.Size = new System.Drawing.Size(122, 22);
            this.MenuProdutosProdutos.Text = "Produtos";
            // 
            // MenuProdutosEstoque
            // 
            this.MenuProdutosEstoque.Name = "MenuProdutosEstoque";
            this.MenuProdutosEstoque.Size = new System.Drawing.Size(122, 22);
            this.MenuProdutosEstoque.Text = "Estoque";
            // 
            // MenuMovimentações
            // 
            this.MenuMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMovimentaçõesFluxoDeCaixa,
            this.MenuMovimentaçõesLançamentoDeVendas,
            this.MenuMovimentaçõesEntradaSaídas,
            this.MenuMovimentaçõesDespesas});
            this.MenuMovimentações.Name = "MenuMovimentações";
            this.MenuMovimentações.Size = new System.Drawing.Size(104, 20);
            this.MenuMovimentações.Text = "Movimentações";
            // 
            // MenuMovimentaçõesFluxoDeCaixa
            // 
            this.MenuMovimentaçõesFluxoDeCaixa.Name = "MenuMovimentaçõesFluxoDeCaixa";
            this.MenuMovimentaçõesFluxoDeCaixa.Size = new System.Drawing.Size(189, 22);
            this.MenuMovimentaçõesFluxoDeCaixa.Text = "Fluxo de caixa";
            // 
            // MenuMovimentaçõesLançamentoDeVendas
            // 
            this.MenuMovimentaçõesLançamentoDeVendas.Name = "MenuMovimentaçõesLançamentoDeVendas";
            this.MenuMovimentaçõesLançamentoDeVendas.Size = new System.Drawing.Size(189, 22);
            this.MenuMovimentaçõesLançamentoDeVendas.Text = "Laçamento de vendas";
            // 
            // MenuMovimentaçõesEntradaSaídas
            // 
            this.MenuMovimentaçõesEntradaSaídas.Name = "MenuMovimentaçõesEntradaSaídas";
            this.MenuMovimentaçõesEntradaSaídas.Size = new System.Drawing.Size(189, 22);
            this.MenuMovimentaçõesEntradaSaídas.Text = "Entrada / Saídas";
            // 
            // MenuMovimentaçõesDespesas
            // 
            this.MenuMovimentaçõesDespesas.Name = "MenuMovimentaçõesDespesas";
            this.MenuMovimentaçõesDespesas.Size = new System.Drawing.Size(189, 22);
            this.MenuMovimentaçõesDespesas.Text = "Despesas";
            // 
            // MenuRelatorios
            // 
            this.MenuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuRelatóriosProdutos,
            this.MenuRelatórioVendas,
            this.MenuRelatóriosMovimentos,
            this.MenuRelatóriosEntradaSaídas,
            this.MenuRelatóriosDespesas});
            this.MenuRelatorios.Name = "MenuRelatorios";
            this.MenuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.MenuRelatorios.Text = "Relatórios";
            // 
            // MenuRelatóriosProdutos
            // 
            this.MenuRelatóriosProdutos.Name = "MenuRelatóriosProdutos";
            this.MenuRelatóriosProdutos.Size = new System.Drawing.Size(158, 22);
            this.MenuRelatóriosProdutos.Text = "Produtos";
            // 
            // MenuRelatórioVendas
            // 
            this.MenuRelatórioVendas.Name = "MenuRelatórioVendas";
            this.MenuRelatórioVendas.Size = new System.Drawing.Size(158, 22);
            this.MenuRelatórioVendas.Text = "Vendas";
            // 
            // MenuRelatóriosMovimentos
            // 
            this.MenuRelatóriosMovimentos.Name = "MenuRelatóriosMovimentos";
            this.MenuRelatóriosMovimentos.Size = new System.Drawing.Size(158, 22);
            this.MenuRelatóriosMovimentos.Text = "Movimentos";
            // 
            // MenuRelatóriosEntradaSaídas
            // 
            this.MenuRelatóriosEntradaSaídas.Name = "MenuRelatóriosEntradaSaídas";
            this.MenuRelatóriosEntradaSaídas.Size = new System.Drawing.Size(158, 22);
            this.MenuRelatóriosEntradaSaídas.Text = "Entrada / Saídas";
            // 
            // MenuRelatóriosDespesas
            // 
            this.MenuRelatóriosDespesas.Name = "MenuRelatóriosDespesas";
            this.MenuRelatóriosDespesas.Size = new System.Drawing.Size(158, 22);
            this.MenuRelatóriosDespesas.Text = "Despesas";
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // Img03
            // 
            this.Img03.Location = new System.Drawing.Point(335, 73);
            this.Img03.Name = "Img03";
            this.Img03.Size = new System.Drawing.Size(132, 84);
            this.Img03.TabIndex = 4;
            this.Img03.TabStop = false;
            // 
            // Img04
            // 
            this.Img04.Location = new System.Drawing.Point(496, 73);
            this.Img04.Name = "Img04";
            this.Img04.Size = new System.Drawing.Size(132, 84);
            this.Img04.TabIndex = 3;
            this.Img04.TabStop = false;
            // 
            // Img02
            // 
            this.Img02.Location = new System.Drawing.Point(181, 73);
            this.Img02.Name = "Img02";
            this.Img02.Size = new System.Drawing.Size(132, 84);
            this.Img02.TabIndex = 2;
            this.Img02.TabStop = false;
            // 
            // Img01
            // 
            this.Img01.Image = global::MintOs.Properties.Resources.icon_icons__1_1;
            this.Img01.Location = new System.Drawing.Point(24, 73);
            this.Img01.Name = "Img01";
            this.Img01.Size = new System.Drawing.Size(132, 84);
            this.Img01.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img01.TabIndex = 1;
            this.Img01.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 508);
            this.Controls.Add(this.Img03);
            this.Controls.Add(this.Img04);
            this.Controls.Add(this.Img02);
            this.Controls.Add(this.Img01);
            this.Controls.Add(this.MenuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuPrincipal;
            this.Name = "FormPrincipal";
            this.Text = "Menu Principal";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img03)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img04)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img02)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img01)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentações;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.PictureBox Img01;
        private System.Windows.Forms.PictureBox Img02;
        private System.Windows.Forms.PictureBox Img04;
        private System.Windows.Forms.PictureBox Img03;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroFuncionários;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroUsuários;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroCargos;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuProdutosEstoque;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentaçõesFluxoDeCaixa;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentaçõesLançamentoDeVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentaçõesEntradaSaídas;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentaçõesDespesas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatóriosProdutos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórioVendas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatóriosMovimentos;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatóriosEntradaSaídas;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatóriosDespesas;
    }
}

