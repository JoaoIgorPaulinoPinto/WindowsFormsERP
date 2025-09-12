namespace Projeto0307.View
{
    partial class CadEndereco
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
            this.txtb_complemento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtb_logradouro = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtxtb_numero = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_uf = new System.Windows.Forms.ComboBox();
            this.mtxtb_cep = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtb_cidade = new System.Windows.Forms.TextBox();
            this.txtb_bairro = new System.Windows.Forms.TextBox();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtb_complemento
            // 
            this.txtb_complemento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_complemento.Location = new System.Drawing.Point(256, 102);
            this.txtb_complemento.Name = "txtb_complemento";
            this.txtb_complemento.Size = new System.Drawing.Size(200, 22);
            this.txtb_complemento.TabIndex = 97;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(462, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 23);
            this.label12.TabIndex = 99;
            this.label12.Text = "NUMERO";
            // 
            // txtb_logradouro
            // 
            this.txtb_logradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_logradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_logradouro.Location = new System.Drawing.Point(10, 102);
            this.txtb_logradouro.Name = "txtb_logradouro";
            this.txtb_logradouro.Size = new System.Drawing.Size(232, 22);
            this.txtb_logradouro.TabIndex = 96;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(7, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 95;
            this.label4.Text = "LOGRADOURO";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtb_numero
            // 
            this.mtxtb_numero.Location = new System.Drawing.Point(461, 105);
            this.mtxtb_numero.Mask = "00000000000";
            this.mtxtb_numero.Name = "mtxtb_numero";
            this.mtxtb_numero.Size = new System.Drawing.Size(85, 22);
            this.mtxtb_numero.TabIndex = 98;
            this.mtxtb_numero.ValidatingType = typeof(int);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(253, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 23);
            this.label13.TabIndex = 100;
            this.label13.Text = "COMPLEMENTO";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label15.Location = new System.Drawing.Point(108, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 23);
            this.label15.TabIndex = 101;
            this.label15.Text = "UF";
            // 
            // cb_uf
            // 
            this.cb_uf.FormattingEnabled = true;
            this.cb_uf.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cb_uf.Location = new System.Drawing.Point(100, 49);
            this.cb_uf.Name = "cb_uf";
            this.cb_uf.Size = new System.Drawing.Size(48, 24);
            this.cb_uf.TabIndex = 94;
            // 
            // mtxtb_cep
            // 
            this.mtxtb_cep.Location = new System.Drawing.Point(10, 51);
            this.mtxtb_cep.Mask = "99.999-999";
            this.mtxtb_cep.Name = "mtxtb_cep";
            this.mtxtb_cep.Size = new System.Drawing.Size(85, 22);
            this.mtxtb_cep.TabIndex = 93;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label17.Location = new System.Drawing.Point(7, 25);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 23);
            this.label17.TabIndex = 102;
            this.label17.Text = "CEP";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(155, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(199, 23);
            this.label5.TabIndex = 105;
            this.label5.Text = "CIDADE";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(401, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 23);
            this.label9.TabIndex = 106;
            this.label9.Text = "BAIRRO";
            // 
            // txtb_cidade
            // 
            this.txtb_cidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_cidade.Location = new System.Drawing.Point(155, 51);
            this.txtb_cidade.Name = "txtb_cidade";
            this.txtb_cidade.Size = new System.Drawing.Size(235, 22);
            this.txtb_cidade.TabIndex = 103;
            // 
            // txtb_bairro
            // 
            this.txtb_bairro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_bairro.Location = new System.Drawing.Point(402, 51);
            this.txtb_bairro.Name = "txtb_bairro";
            this.txtb_bairro.Size = new System.Drawing.Size(172, 22);
            this.txtb_bairro.TabIndex = 104;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_cadastrar.Location = new System.Drawing.Point(465, 135);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(106, 30);
            this.btn_cadastrar.TabIndex = 107;
            this.btn_cadastrar.Text = "Adicionar";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_excluir.Location = new System.Drawing.Point(249, 135);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(106, 30);
            this.btn_excluir.TabIndex = 108;
            this.btn_excluir.Text = "Excluir";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_salvar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_salvar.Location = new System.Drawing.Point(357, 135);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(106, 30);
            this.btn_salvar.TabIndex = 109;
            this.btn_salvar.Text = "Salvar";
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.Controls.Add(this.btn_salvar);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.txtb_bairro);
            this.groupBox1.Controls.Add(this.txtb_cidade);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.mtxtb_cep);
            this.groupBox1.Controls.Add(this.cb_uf);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.mtxtb_numero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtb_logradouro);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtb_complemento);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(604, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereco";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_cancelar.Location = new System.Drawing.Point(137, 135);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(106, 30);
            this.btn_cancelar.TabIndex = 110;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // CadEndereco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 209);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadEndereco";
            this.Text = "CadEndereco";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_complemento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtb_logradouro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtxtb_numero;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_uf;
        private System.Windows.Forms.MaskedTextBox mtxtb_cep;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtb_cidade;
        private System.Windows.Forms.TextBox txtb_bairro;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancelar;
    }
}