namespace Projeto0307
{
    partial class TelaLogin
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
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_telalogin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtb_senha = new System.Windows.Forms.TextBox();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(408, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Entrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbl_telalogin
            // 
            this.lbl_telalogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_telalogin.Location = new System.Drawing.Point(12, 9);
            this.lbl_telalogin.Name = "lbl_telalogin";
            this.lbl_telalogin.Size = new System.Drawing.Size(408, 33);
            this.lbl_telalogin.TabIndex = 2;
            this.lbl_telalogin.Text = "TELA DE LOGIN";
            this.lbl_telalogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(13, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(405, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(13, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // txtb_senha
            // 
            this.txtb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtb_senha.Location = new System.Drawing.Point(12, 194);
            this.txtb_senha.Name = "txtb_senha";
            this.txtb_senha.PasswordChar = '*';
            this.txtb_senha.Size = new System.Drawing.Size(408, 22);
            this.txtb_senha.TabIndex = 5;
            this.txtb_senha.UseSystemPasswordChar = true;
            // 
            // txtb_email
            // 
            this.txtb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtb_email.Location = new System.Drawing.Point(12, 129);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(408, 22);
            this.txtb_email.TabIndex = 3;
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(432, 353);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtb_senha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtb_email);
            this.Controls.Add(this.lbl_telalogin);
            this.Controls.Add(this.button2);
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_telalogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtb_senha;
        private System.Windows.Forms.TextBox txtb_email;
    }
}

