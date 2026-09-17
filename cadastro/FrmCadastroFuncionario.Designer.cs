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
            this.SuspendLayout();
            // 
            // labelnome
            // 
            this.labelnome.AutoSize = true;
            this.labelnome.Location = new System.Drawing.Point(12, 41);
            this.labelnome.Name = "labelnome";
            this.labelnome.Size = new System.Drawing.Size(35, 13);
            this.labelnome.TabIndex = 0;
            this.labelnome.Text = "Nome";
            // 
            // labelcpf
            // 
            this.labelcpf.AutoSize = true;
            this.labelcpf.Location = new System.Drawing.Point(366, 41);
            this.labelcpf.Name = "labelcpf";
            this.labelcpf.Size = new System.Drawing.Size(27, 13);
            this.labelcpf.TabIndex = 1;
            this.labelcpf.Text = "CPF";
            // 
            // labeltelefone
            // 
            this.labeltelefone.AutoSize = true;
            this.labeltelefone.Location = new System.Drawing.Point(12, 124);
            this.labeltelefone.Name = "labeltelefone";
            this.labeltelefone.Size = new System.Drawing.Size(49, 13);
            this.labeltelefone.TabIndex = 2;
            this.labeltelefone.Text = "Telefone";
            // 
            // labelendereco
            // 
            this.labelendereco.AutoSize = true;
            this.labelendereco.Location = new System.Drawing.Point(12, 198);
            this.labelendereco.Name = "labelendereco";
            this.labelendereco.Size = new System.Drawing.Size(53, 13);
            this.labelendereco.TabIndex = 3;
            this.labelendereco.Text = "Endereço";
            // 
            // labelcargo
            // 
            this.labelcargo.AutoSize = true;
            this.labelcargo.Location = new System.Drawing.Point(366, 124);
            this.labelcargo.Name = "labelcargo";
            this.labelcargo.Size = new System.Drawing.Size(35, 13);
            this.labelcargo.TabIndex = 4;
            this.labelcargo.Text = "Cargo";
            // 
            // labelfoto
            // 
            this.labelfoto.AutoSize = true;
            this.labelfoto.Location = new System.Drawing.Point(540, 41);
            this.labelfoto.Name = "labelfoto";
            this.labelfoto.Size = new System.Drawing.Size(28, 13);
            this.labelfoto.TabIndex = 5;
            this.labelfoto.Text = "Foto";
            // 
            // FrmCadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 508);
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
    }
}