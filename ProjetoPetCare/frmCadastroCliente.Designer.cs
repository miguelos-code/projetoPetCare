namespace ProjetoPetCare
{
    partial class frmCadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroCliente));
            this.gpb_dadosCliente = new System.Windows.Forms.GroupBox();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.lbl_codigo = new System.Windows.Forms.Label();
            this.lbl_idade = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_idade = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_voltar = new System.Windows.Forms.Button();
            this.gpb_dadosCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_dadosCliente
            // 
            this.gpb_dadosCliente.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpb_dadosCliente.Controls.Add(this.pictureBox1);
            this.gpb_dadosCliente.Controls.Add(this.txt_codigo);
            this.gpb_dadosCliente.Controls.Add(this.txt_idade);
            this.gpb_dadosCliente.Controls.Add(this.txt_nome);
            this.gpb_dadosCliente.Controls.Add(this.lbl_idade);
            this.gpb_dadosCliente.Controls.Add(this.lbl_codigo);
            this.gpb_dadosCliente.Controls.Add(this.lbl_nome);
            this.gpb_dadosCliente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_dadosCliente.Location = new System.Drawing.Point(82, 45);
            this.gpb_dadosCliente.Name = "gpb_dadosCliente";
            this.gpb_dadosCliente.Size = new System.Drawing.Size(627, 254);
            this.gpb_dadosCliente.TabIndex = 0;
            this.gpb_dadosCliente.TabStop = false;
            this.gpb_dadosCliente.Text = "Dados Clientes";
            // 
            // lbl_nome
            // 
            this.lbl_nome.AutoSize = true;
            this.lbl_nome.Location = new System.Drawing.Point(70, 67);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(70, 22);
            this.lbl_nome.TabIndex = 0;
            this.lbl_nome.Text = "Nome: ";
            // 
            // lbl_codigo
            // 
            this.lbl_codigo.AutoSize = true;
            this.lbl_codigo.Location = new System.Drawing.Point(70, 177);
            this.lbl_codigo.Name = "lbl_codigo";
            this.lbl_codigo.Size = new System.Drawing.Size(90, 22);
            this.lbl_codigo.TabIndex = 1;
            this.lbl_codigo.Text = "Código: ";
            // 
            // lbl_idade
            // 
            this.lbl_idade.AutoSize = true;
            this.lbl_idade.Location = new System.Drawing.Point(70, 122);
            this.lbl_idade.Name = "lbl_idade";
            this.lbl_idade.Size = new System.Drawing.Size(80, 22);
            this.lbl_idade.TabIndex = 2;
            this.lbl_idade.Text = "Idade: ";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(171, 64);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(193, 30);
            this.txt_nome.TabIndex = 0;
            // 
            // txt_idade
            // 
            this.txt_idade.Location = new System.Drawing.Point(171, 119);
            this.txt_idade.Name = "txt_idade";
            this.txt_idade.Size = new System.Drawing.Size(193, 30);
            this.txt_idade.TabIndex = 1;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(171, 174);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(193, 30);
            this.txt_codigo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(429, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_novo.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.Location = new System.Drawing.Point(82, 375);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(150, 50);
            this.btn_novo.TabIndex = 3;
            this.btn_novo.Text = "Novo";
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_limpar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(327, 375);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(150, 50);
            this.btn_limpar.TabIndex = 4;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = false;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_voltar
            // 
            this.btn_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_voltar.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltar.Location = new System.Drawing.Point(559, 375);
            this.btn_voltar.Name = "btn_voltar";
            this.btn_voltar.Size = new System.Drawing.Size(150, 50);
            this.btn_voltar.TabIndex = 5;
            this.btn_voltar.Text = "Voltar";
            this.btn_voltar.UseVisualStyleBackColor = false;
            this.btn_voltar.Click += new System.EventHandler(this.btn_voltar_Click);
            // 
            // frmCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_voltar);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.gpb_dadosCliente);
            this.Name = "frmCadastroCliente";
            this.Text = "frmCadastroCliente";
            this.gpb_dadosCliente.ResumeLayout(false);
            this.gpb_dadosCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_dadosCliente;
        private System.Windows.Forms.Label lbl_idade;
        private System.Windows.Forms.Label lbl_codigo;
        private System.Windows.Forms.Label lbl_nome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_idade;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_voltar;
    }
}