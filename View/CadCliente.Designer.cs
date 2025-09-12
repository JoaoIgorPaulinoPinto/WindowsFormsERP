using System.Data.Common;

namespace Projeto0307
{
    partial class CadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        /// 
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vENDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEDIDOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATÓRIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTEToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUTOToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.lISTARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cADASTRARToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pEDIDOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fORNECEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rELATORIOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.mtxtb_celular = new System.Windows.Forms.MaskedTextBox();
            this.mtxtb_alternativo = new System.Windows.Forms.MaskedTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.mtxtb_telefoneRes = new System.Windows.Forms.MaskedTextBox();
            this.mtxtb_telefoneCom = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtb_email = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cb_sexo = new System.Windows.Forms.ComboBox();
            this.txtb_nome = new System.Windows.Forms.TextBox();
            this.mtxtb_datanascimento = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtxtb_cpf = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.DataGridViewEnderecos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnderecos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.AutoSize = false;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.cONSULTARToolStripMenuItem,
            this.rELATÓRIOSToolStripMenuItem,
            this.fORNECEDORToolStripMenuItem3});
            this.menuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip2.Size = new System.Drawing.Size(1361, 60);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRASToolStripMenuItem,
            this.vENDASToolStripMenuItem,
            this.rELATORIOToolStripMenuItem});
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(72, 56);
            this.cADASTRARToolStripMenuItem.Text = "VENDA";
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.cOMPRASToolStripMenuItem.Text = "LISTAR";
            // 
            // vENDASToolStripMenuItem
            // 
            this.vENDASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENDAToolStripMenuItem,
            this.pEDIDOToolStripMenuItem1});
            this.vENDASToolStripMenuItem.Name = "vENDASToolStripMenuItem";
            this.vENDASToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.vENDASToolStripMenuItem.Text = "CADASTRAR";
            // 
            // vENDAToolStripMenuItem
            // 
            this.vENDAToolStripMenuItem.Name = "vENDAToolStripMenuItem";
            this.vENDAToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.vENDAToolStripMenuItem.Text = "VENDA";
            // 
            // pEDIDOToolStripMenuItem1
            // 
            this.pEDIDOToolStripMenuItem1.Name = "pEDIDOToolStripMenuItem1";
            this.pEDIDOToolStripMenuItem1.Size = new System.Drawing.Size(145, 26);
            this.pEDIDOToolStripMenuItem1.Text = "PEDIDO";
            // 
            // rELATORIOToolStripMenuItem
            // 
            this.rELATORIOToolStripMenuItem.Name = "rELATORIOToolStripMenuItem";
            this.rELATORIOToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.rELATORIOToolStripMenuItem.Text = "RELATORIO";
            // 
            // cONSULTARToolStripMenuItem
            // 
            this.cONSULTARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORNECEDORToolStripMenuItem1,
            this.cLIENTEToolStripMenuItem1,
            this.pRODUTOToolStripMenuItem1});
            this.cONSULTARToolStripMenuItem.Name = "cONSULTARToolStripMenuItem";
            this.cONSULTARToolStripMenuItem.Size = new System.Drawing.Size(90, 56);
            this.cONSULTARToolStripMenuItem.Text = "PRODUTO";
            // 
            // fORNECEDORToolStripMenuItem1
            // 
            this.fORNECEDORToolStripMenuItem1.Name = "fORNECEDORToolStripMenuItem1";
            this.fORNECEDORToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.fORNECEDORToolStripMenuItem1.Text = "LISTAR";
            // 
            // cLIENTEToolStripMenuItem1
            // 
            this.cLIENTEToolStripMenuItem1.Name = "cLIENTEToolStripMenuItem1";
            this.cLIENTEToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.cLIENTEToolStripMenuItem1.Text = "CADASTRAR";
            // 
            // pRODUTOToolStripMenuItem1
            // 
            this.pRODUTOToolStripMenuItem1.Name = "pRODUTOToolStripMenuItem1";
            this.pRODUTOToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.pRODUTOToolStripMenuItem1.Text = "RELATORIO";
            // 
            // rELATÓRIOSToolStripMenuItem
            // 
            this.rELATÓRIOSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fORNECEDORToolStripMenuItem2,
            this.cLIENTEToolStripMenuItem2,
            this.pRODUTOToolStripMenuItem2});
            this.rELATÓRIOSToolStripMenuItem.Name = "rELATÓRIOSToolStripMenuItem";
            this.rELATÓRIOSToolStripMenuItem.Size = new System.Drawing.Size(78, 56);
            this.rELATÓRIOSToolStripMenuItem.Text = "CLIENTE";
            // 
            // fORNECEDORToolStripMenuItem2
            // 
            this.fORNECEDORToolStripMenuItem2.Name = "fORNECEDORToolStripMenuItem2";
            this.fORNECEDORToolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this.fORNECEDORToolStripMenuItem2.Text = "LISTAR";
            // 
            // cLIENTEToolStripMenuItem2
            // 
            this.cLIENTEToolStripMenuItem2.Name = "cLIENTEToolStripMenuItem2";
            this.cLIENTEToolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this.cLIENTEToolStripMenuItem2.Text = "CADASTRAR";
            // 
            // pRODUTOToolStripMenuItem2
            // 
            this.pRODUTOToolStripMenuItem2.Name = "pRODUTOToolStripMenuItem2";
            this.pRODUTOToolStripMenuItem2.Size = new System.Drawing.Size(176, 26);
            this.pRODUTOToolStripMenuItem2.Text = "RELATORIO";
            // 
            // fORNECEDORToolStripMenuItem3
            // 
            this.fORNECEDORToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lISTARToolStripMenuItem,
            this.cADASTRARToolStripMenuItem1,
            this.rELATORIOSToolStripMenuItem});
            this.fORNECEDORToolStripMenuItem3.Name = "fORNECEDORToolStripMenuItem3";
            this.fORNECEDORToolStripMenuItem3.Size = new System.Drawing.Size(117, 56);
            this.fORNECEDORToolStripMenuItem3.Text = "FORNECEDOR";
            // 
            // lISTARToolStripMenuItem
            // 
            this.lISTARToolStripMenuItem.Name = "lISTARToolStripMenuItem";
            this.lISTARToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.lISTARToolStripMenuItem.Text = "LISTAR";
            // 
            // cADASTRARToolStripMenuItem1
            // 
            this.cADASTRARToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cOMPRAToolStripMenuItem,
            this.pEDIDOToolStripMenuItem,
            this.fORNECEDORToolStripMenuItem});
            this.cADASTRARToolStripMenuItem1.Name = "cADASTRARToolStripMenuItem1";
            this.cADASTRARToolStripMenuItem1.Size = new System.Drawing.Size(176, 26);
            this.cADASTRARToolStripMenuItem1.Text = "CADASTRAR";
            // 
            // cOMPRAToolStripMenuItem
            // 
            this.cOMPRAToolStripMenuItem.Name = "cOMPRAToolStripMenuItem";
            this.cOMPRAToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.cOMPRAToolStripMenuItem.Text = "COMPRA";
            // 
            // pEDIDOToolStripMenuItem
            // 
            this.pEDIDOToolStripMenuItem.Name = "pEDIDOToolStripMenuItem";
            this.pEDIDOToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.pEDIDOToolStripMenuItem.Text = "PEDIDO";
            // 
            // fORNECEDORToolStripMenuItem
            // 
            this.fORNECEDORToolStripMenuItem.Name = "fORNECEDORToolStripMenuItem";
            this.fORNECEDORToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.fORNECEDORToolStripMenuItem.Text = "FORNECEDOR";
            // 
            // rELATORIOSToolStripMenuItem
            // 
            this.rELATORIOSToolStripMenuItem.Name = "rELATORIOSToolStripMenuItem";
            this.rELATORIOSToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.rELATORIOSToolStripMenuItem.Text = "RELATORIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btn_excluir);
            this.groupBox1.Controls.Add(this.cb_status);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_cadastrar);
            this.groupBox1.Controls.Add(this.btn_editar);
            this.groupBox1.Controls.Add(this.btn_cancelar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(13, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(634, 566);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Cliente";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Location = new System.Drawing.Point(15, 96);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(590, 67);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Endereço";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(9, 23);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(222, 36);
            this.button3.TabIndex = 56;
            this.button3.Text = "CADASTRAR ENDERECO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_excluir
            // 
            this.btn_excluir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_excluir.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_excluir.Location = new System.Drawing.Point(15, 520);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(124, 36);
            this.btn_excluir.TabIndex = 54;
            this.btn_excluir.Text = "EXCLUIR";
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // cb_status
            // 
            this.cb_status.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cb_status.Location = new System.Drawing.Point(470, 322);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(135, 26);
            this.cb_status.Sorted = true;
            this.cb_status.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(391, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 23);
            this.label3.TabIndex = 53;
            this.label3.Text = "STATUS";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.mtxtb_celular);
            this.groupBox5.Controls.Add(this.mtxtb_alternativo);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.mtxtb_telefoneRes);
            this.groupBox5.Controls.Add(this.mtxtb_telefoneCom);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtb_email);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(15, 169);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(590, 147);
            this.groupBox5.TabIndex = 51;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Contato";
            // 
            // mtxtb_celular
            // 
            this.mtxtb_celular.Location = new System.Drawing.Point(9, 52);
            this.mtxtb_celular.Mask = "(00) 00000-0000";
            this.mtxtb_celular.Name = "mtxtb_celular";
            this.mtxtb_celular.Size = new System.Drawing.Size(202, 24);
            this.mtxtb_celular.TabIndex = 12;
            // 
            // mtxtb_alternativo
            // 
            this.mtxtb_alternativo.Location = new System.Drawing.Point(415, 52);
            this.mtxtb_alternativo.Name = "mtxtb_alternativo";
            this.mtxtb_alternativo.Size = new System.Drawing.Size(161, 24);
            this.mtxtb_alternativo.TabIndex = 16;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label16.Location = new System.Drawing.Point(412, 26);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 23);
            this.label16.TabIndex = 43;
            this.label16.Text = "ALTERNATIVO";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtb_telefoneRes
            // 
            this.mtxtb_telefoneRes.Location = new System.Drawing.Point(9, 108);
            this.mtxtb_telefoneRes.Name = "mtxtb_telefoneRes";
            this.mtxtb_telefoneRes.Size = new System.Drawing.Size(202, 24);
            this.mtxtb_telefoneRes.TabIndex = 14;
            // 
            // mtxtb_telefoneCom
            // 
            this.mtxtb_telefoneCom.Location = new System.Drawing.Point(217, 52);
            this.mtxtb_telefoneCom.Name = "mtxtb_telefoneCom";
            this.mtxtb_telefoneCom.Size = new System.Drawing.Size(192, 24);
            this.mtxtb_telefoneCom.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(217, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 23);
            this.label2.TabIndex = 41;
            this.label2.Text = "EMAIL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtb_email
            // 
            this.txtb_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_email.Location = new System.Drawing.Point(217, 108);
            this.txtb_email.Name = "txtb_email";
            this.txtb_email.Size = new System.Drawing.Size(268, 24);
            this.txtb_email.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(6, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(213, 23);
            this.label11.TabIndex = 31;
            this.label11.Text = "TELEFONE RESIDENCIAL";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(214, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(213, 23);
            this.label10.TabIndex = 33;
            this.label10.Text = "TELEFONE COMERCIAL";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 23);
            this.label8.TabIndex = 31;
            this.label8.Text = "CELULAR";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.cb_sexo);
            this.groupBox3.Controls.Add(this.txtb_nome);
            this.groupBox3.Controls.Add(this.mtxtb_datanascimento);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.mtxtb_cpf);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(15, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(586, 75);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pessoa";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(484, 18);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 23);
            this.label14.TabIndex = 48;
            this.label14.Text = "SEXO";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_sexo
            // 
            this.cb_sexo.FormattingEnabled = true;
            this.cb_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino",
            "Não Binario"});
            this.cb_sexo.Location = new System.Drawing.Point(487, 43);
            this.cb_sexo.Name = "cb_sexo";
            this.cb_sexo.Size = new System.Drawing.Size(93, 26);
            this.cb_sexo.TabIndex = 48;
            // 
            // txtb_nome
            // 
            this.txtb_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtb_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtb_nome.Location = new System.Drawing.Point(9, 45);
            this.txtb_nome.Name = "txtb_nome";
            this.txtb_nome.Size = new System.Drawing.Size(222, 24);
            this.txtb_nome.TabIndex = 1;
            // 
            // mtxtb_datanascimento
            // 
            this.mtxtb_datanascimento.Location = new System.Drawing.Point(364, 45);
            this.mtxtb_datanascimento.Mask = "00/00/0000";
            this.mtxtb_datanascimento.Name = "mtxtb_datanascimento";
            this.mtxtb_datanascimento.Size = new System.Drawing.Size(97, 24);
            this.mtxtb_datanascimento.TabIndex = 3;
            this.mtxtb_datanascimento.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(361, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "DT. NASCIM";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mtxtb_cpf
            // 
            this.mtxtb_cpf.Location = new System.Drawing.Point(234, 45);
            this.mtxtb_cpf.Mask = "000.000.000-00";
            this.mtxtb_cpf.Name = "mtxtb_cpf";
            this.mtxtb_cpf.Size = new System.Drawing.Size(125, 24);
            this.mtxtb_cpf.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(236, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 23);
            this.label7.TabIndex = 29;
            this.label7.Text = "CPF";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "NOME";
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cadastrar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_cadastrar.Location = new System.Drawing.Point(426, 501);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(179, 50);
            this.btn_cadastrar.TabIndex = 18;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click_1);
            // 
            // btn_editar
            // 
            this.btn_editar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_editar.Location = new System.Drawing.Point(15, 439);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(124, 36);
            this.btn_editar.TabIndex = 20;
            this.btn_editar.Text = "SALVAR";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancelar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_cancelar.Location = new System.Drawing.Point(15, 481);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(124, 36);
            this.btn_cancelar.TabIndex = 19;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Location = new System.Drawing.Point(574, 526);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(0, 30);
            this.button5.TabIndex = 44;
            this.button5.Text = "ATUALIZAR";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(817, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(531, 417);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clientes Cadastrados";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CausesValidation = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome,
            this.CPF,
            this.Celular,
            this.Cidade});
            this.dataGridView1.Location = new System.Drawing.Point(4, 21);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(523, 386);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Visible = false;
            this.Nome.Width = 125;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Visible = false;
            this.CPF.Width = 125;
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.MinimumWidth = 6;
            this.Celular.Name = "Celular";
            this.Celular.ReadOnly = true;
            this.Celular.Visible = false;
            this.Celular.Width = 125;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.MinimumWidth = 6;
            this.Cidade.Name = "Cidade";
            this.Cidade.ReadOnly = true;
            this.Cidade.Visible = false;
            this.Cidade.Width = 125;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(654, 131);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(156, 310);
            this.checkedListBox1.TabIndex = 7;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_atualizar.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_atualizar.Location = new System.Drawing.Point(654, 447);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(156, 36);
            this.btn_atualizar.TabIndex = 55;
            this.btn_atualizar.Text = "ATUALIZAR";
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox6.Controls.Add(this.DataGridViewEnderecos);
            this.groupBox6.Controls.Add(this.button1);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(817, 501);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(531, 141);
            this.groupBox6.TabIndex = 45;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Endereços Cadastrados";
            // 
            // DataGridViewEnderecos
            // 
            this.DataGridViewEnderecos.AllowUserToAddRows = false;
            this.DataGridViewEnderecos.AllowUserToDeleteRows = false;
            this.DataGridViewEnderecos.AllowUserToOrderColumns = true;
            this.DataGridViewEnderecos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridViewEnderecos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.DataGridViewEnderecos.CausesValidation = false;
            this.DataGridViewEnderecos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewEnderecos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.DataGridViewEnderecos.Location = new System.Drawing.Point(7, 24);
            this.DataGridViewEnderecos.MultiSelect = false;
            this.DataGridViewEnderecos.Name = "DataGridViewEnderecos";
            this.DataGridViewEnderecos.ReadOnly = true;
            this.DataGridViewEnderecos.RowHeadersWidth = 51;
            this.DataGridViewEnderecos.RowTemplate.Height = 24;
            this.DataGridViewEnderecos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridViewEnderecos.ShowCellToolTips = false;
            this.DataGridViewEnderecos.ShowEditingIcon = false;
            this.DataGridViewEnderecos.Size = new System.Drawing.Size(517, 110);
            this.DataGridViewEnderecos.TabIndex = 0;
            this.DataGridViewEnderecos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewEnderecos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "CPF";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Celular";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Cidade";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Location = new System.Drawing.Point(574, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 30);
            this.button1.TabIndex = 44;
            this.button1.Text = "ATUALIZAR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // CadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1361, 655);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewEnderecos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vENDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem rELATÓRIOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem pRODUTOToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem lISTARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cOMPRAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pEDIDOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fORNECEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rELATORIOSToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtb_email;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.MaskedTextBox mtxtb_cpf;
        private System.Windows.Forms.MaskedTextBox mtxtb_datanascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox mtxtb_telefoneRes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox mtxtb_telefoneCom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtb_nome;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cb_sexo;
        private System.Windows.Forms.MaskedTextBox mtxtb_alternativo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox mtxtb_celular;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView DataGridViewEnderecos;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button button1;
    }
}