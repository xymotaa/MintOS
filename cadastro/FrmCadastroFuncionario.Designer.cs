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
            this.labelnome = new System.Windows.Forms.Label();
            this.labelcpf = new System.Windows.Forms.Label();
            this.labeltelefone = new System.Windows.Forms.Label();
            this.labelendereco = new System.Windows.Forms.Label();
            this.labelcargo = new System.Windows.Forms.Label();
            this.labelfoto = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.comboBoxCargo = new System.Windows.Forms.ComboBox();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelnome.Location = new System.Drawing.Point(55, 114);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(44, 16);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcpf.Location = new System.Drawing.Point(252, 191);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(33, 16);
            this.labelcpf.TabIndex = 1;
            this.labelcpf.Text = "CPF";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltelefone.Location = new System.Drawing.Point(55, 189);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(61, 16);
            this.labeltelefone.TabIndex = 2;
            this.labeltelefone.Text = "Telefone";
            // 
            // labelendereco
            // 
            this.labelendereco.AutoSize = true;
            this.labelendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelendereco.Location = new System.Drawing.Point(55, 266);
            this.labelendereco.Name = "labelendereco";
            this.labelendereco.Size = new System.Drawing.Size(66, 16);
            this.labelendereco.TabIndex = 3;
            this.labelendereco.Text = "Endereço";
            // 
            // labelcargo
            // 
            this.labelcargo.AutoSize = true;
            this.labelcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcargo.Location = new System.Drawing.Point(55, 338);
            this.labelcargo.Name = "labelcargo";
            this.labelcargo.Size = new System.Drawing.Size(44, 16);
            this.labelcargo.TabIndex = 4;
            this.labelcargo.Text = "Cargo";
            // 
            // labelfoto
            // 
            this.labelfoto.AutoSize = true;
            this.labelfoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfoto.Location = new System.Drawing.Point(252, 364);
            this.labelfoto.Name = "labelfoto";
            this.labelfoto.Size = new System.Drawing.Size(34, 16);
            this.labelfoto.TabIndex = 5;
            this.labelfoto.Text = "Foto";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(58, 142);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(344, 20);
            this.textNome.TabIndex = 6;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(58, 215);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(156, 20);
            this.textTelefone.TabIndex = 7;
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(58, 293);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(344, 20);
            this.textEndereco.TabIndex = 8;
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(255, 215);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(147, 20);
            this.textCpf.TabIndex = 9;
            // 
            // comboBoxCargo
            // 
            this.comboBoxCargo.FormattingEnabled = true;
            this.comboBoxCargo.Items.AddRange(new object[] {
            "Gerente",
            "Atendente"});
            this.comboBoxCargo.Location = new System.Drawing.Point(58, 364);
            this.comboBoxCargo.Name = "comboBoxCargo";
            this.comboBoxCargo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCargo.TabIndex = 10;
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.Location = new System.Drawing.Point(488, 114);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(210, 199);
            this.pictureBoxFoto.TabIndex = 11;
            this.pictureBoxFoto.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(820, 46);
            this.dataGridView1.TabIndex = 12;
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 508);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.comboBoxCargo);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.textTelefone);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelfoto);
            this.Controls.Add(this.labelcargo);
            this.Controls.Add(this.labelendereco);
            this.Controls.Add(this.labeltelefone);
            this.Controls.Add(this.labelcpf);
            this.Controls.Add(this.labelnome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Funcionário";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}