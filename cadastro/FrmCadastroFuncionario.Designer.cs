namespace MintOs.cadastro
{
    partial class FrmCadastroFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroFuncionario));
            labelnome = new Label();
            labelcpf = new Label();
            labeltelefone = new Label();
            labelendereco = new Label();
            labelcargo = new Label();
            labelfoto = new Label();
            textNome = new TextBox();
            textTelefone = new TextBox();
            textEndereco = new TextBox();
            textCpf = new TextBox();
            comboBoxCargo = new ComboBox();
            pictureBoxFoto = new PictureBox();
            dataGridView1 = new DataGridView();
            btnNovo = new Button();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnFoto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // labelnome
            // 
            labelnome.AutoSize = true;
            labelnome.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelnome.Location = new Point(58, 195);
            labelnome.Margin = new Padding(4, 0, 4, 0);
            labelnome.Name = "labelnome";
            labelnome.Size = new Size(44, 16);
            labelnome.TabIndex = 0;
            labelnome.Text = "Nome";
            // 
            // labelcpf
            // 
            labelcpf.AutoSize = true;
            labelcpf.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcpf.Location = new Point(288, 276);
            labelcpf.Margin = new Padding(4, 0, 4, 0);
            labelcpf.Name = "labelcpf";
            labelcpf.Size = new Size(33, 16);
            labelcpf.TabIndex = 1;
            labelcpf.Text = "CPF";
            // 
            // labeltelefone
            // 
            labeltelefone.AutoSize = true;
            labeltelefone.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltelefone.Location = new Point(58, 274);
            labeltelefone.Margin = new Padding(4, 0, 4, 0);
            labeltelefone.Name = "labeltelefone";
            labeltelefone.Size = new Size(61, 16);
            labeltelefone.TabIndex = 2;
            labeltelefone.Text = "Telefone";
            // 
            // labelendereco
            // 
            labelendereco.AutoSize = true;
            labelendereco.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelendereco.Location = new Point(58, 355);
            labelendereco.Margin = new Padding(4, 0, 4, 0);
            labelendereco.Name = "labelendereco";
            labelendereco.Size = new Size(66, 16);
            labelendereco.TabIndex = 3;
            labelendereco.Text = "Endereço";
            // 
            // labelcargo
            // 
            labelcargo.AutoSize = true;
            labelcargo.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcargo.Location = new Point(61, 433);
            labelcargo.Margin = new Padding(4, 0, 4, 0);
            labelcargo.Name = "labelcargo";
            labelcargo.Size = new Size(44, 16);
            labelcargo.TabIndex = 4;
            labelcargo.Text = "Cargo";
            // 
            // labelfoto
            // 
            labelfoto.AutoSize = true;
            labelfoto.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelfoto.Location = new Point(291, 433);
            labelfoto.Margin = new Padding(4, 0, 4, 0);
            labelfoto.Name = "labelfoto";
            labelfoto.Size = new Size(34, 16);
            labelfoto.TabIndex = 5;
            labelfoto.Text = "Foto";
            // 
            // textNome
            // 
            textNome.Location = new Point(61, 227);
            textNome.Margin = new Padding(4, 3, 4, 3);
            textNome.Name = "textNome";
            textNome.Size = new Size(401, 23);
            textNome.TabIndex = 6;
            // 
            // textTelefone
            // 
            textTelefone.Location = new Point(61, 304);
            textTelefone.Margin = new Padding(4, 3, 4, 3);
            textTelefone.Name = "textTelefone";
            textTelefone.Size = new Size(181, 23);
            textTelefone.TabIndex = 7;
            // 
            // textEndereco
            // 
            textEndereco.Location = new Point(61, 387);
            textEndereco.Margin = new Padding(4, 3, 4, 3);
            textEndereco.Name = "textEndereco";
            textEndereco.Size = new Size(401, 23);
            textEndereco.TabIndex = 8;
            // 
            // textCpf
            // 
            textCpf.Location = new Point(291, 304);
            textCpf.Margin = new Padding(4, 3, 4, 3);
            textCpf.Name = "textCpf";
            textCpf.Size = new Size(171, 23);
            textCpf.TabIndex = 9;
            // 
            // comboBoxCargo
            // 
            comboBoxCargo.FormattingEnabled = true;
            comboBoxCargo.Items.AddRange(new object[] { "Gerente", "Atendente" });
            comboBoxCargo.Location = new Point(61, 462);
            comboBoxCargo.Margin = new Padding(4, 3, 4, 3);
            comboBoxCargo.Name = "comboBoxCargo";
            comboBoxCargo.Size = new Size(181, 23);
            comboBoxCargo.TabIndex = 10;
            // 
            // pictureBoxFoto
            // 
            pictureBoxFoto.Location = new Point(196, 79);
            pictureBoxFoto.Margin = new Padding(4, 3, 4, 3);
            pictureBoxFoto.Name = "pictureBoxFoto";
            pictureBoxFoto.Size = new Size(107, 101);
            pictureBoxFoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxFoto.TabIndex = 11;
            pictureBoxFoto.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.ActiveCaptionText;
            dataGridView1.Location = new Point(555, 79);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(435, 406);
            dataGridView1.TabIndex = 12;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(680, 517);
            btnNovo.Margin = new Padding(4, 3, 4, 3);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(103, 27);
            btnNovo.TabIndex = 13;
            btnNovo.Text = "Novo Usuário";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(555, 517);
            btnSalvar.Margin = new Padding(4, 3, 4, 3);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(117, 27);
            btnSalvar.TabIndex = 14;
            btnSalvar.Text = "Salvar Alterações";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(791, 517);
            btnEditar.Margin = new Padding(4, 3, 4, 3);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 27);
            btnEditar.TabIndex = 15;
            btnEditar.Text = "Editar Usuário";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(893, 517);
            btnExcluir.Margin = new Padding(4, 3, 4, 3);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(97, 27);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir Usuário";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnFoto
            // 
            btnFoto.Location = new Point(291, 462);
            btnFoto.Name = "btnFoto";
            btnFoto.Size = new Size(174, 23);
            btnFoto.TabIndex = 17;
            btnFoto.Text = "Adicionar Foto";
            btnFoto.UseVisualStyleBackColor = true;
            btnFoto.Click += btnFoto_Click;
            // 
            // FrmCadastroFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 586);
            Controls.Add(btnFoto);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnSalvar);
            Controls.Add(btnNovo);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxFoto);
            Controls.Add(comboBoxCargo);
            Controls.Add(textCpf);
            Controls.Add(textEndereco);
            Controls.Add(textTelefone);
            Controls.Add(textNome);
            Controls.Add(labelfoto);
            Controls.Add(labelcargo);
            Controls.Add(labelendereco);
            Controls.Add(labeltelefone);
            Controls.Add(labelcpf);
            Controls.Add(labelnome);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmCadastroFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar Funcionário";
            ((System.ComponentModel.ISupportInitialize)pictureBoxFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelnome;
        private System.Windows.Forms.Label labelcpf;
        private System.Windows.Forms.Label labeltelefone;
        private System.Windows.Forms.Label labelendereco;
        private System.Windows.Forms.Label labelcargo;
        private System.Windows.Forms.Label labelfoto;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.TextBox textCpf;
        private System.Windows.Forms.ComboBox comboBoxCargo;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private Button btnFoto;
    }
}