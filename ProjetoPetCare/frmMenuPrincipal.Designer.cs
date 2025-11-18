namespace ProjetoPetCare
{
    partial class frmMenuPrincipal
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
            this.btn_cadCliente = new System.Windows.Forms.Button();
            this.btn_cadAnimal = new System.Windows.Forms.Button();
            this.btn_cadVeterinario = new System.Windows.Forms.Button();
            this.btn_produtos = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_petCare = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cadCliente
            // 
            this.btn_cadCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cadCliente.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadCliente.Location = new System.Drawing.Point(261, 96);
            this.btn_cadCliente.Name = "btn_cadCliente";
            this.btn_cadCliente.Size = new System.Drawing.Size(250, 50);
            this.btn_cadCliente.TabIndex = 0;
            this.btn_cadCliente.Text = "Cadastro Cliente";
            this.btn_cadCliente.UseVisualStyleBackColor = false;
            this.btn_cadCliente.Click += new System.EventHandler(this.btn_cadCliente_Click);
            // 
            // btn_cadAnimal
            // 
            this.btn_cadAnimal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cadAnimal.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadAnimal.Location = new System.Drawing.Point(261, 152);
            this.btn_cadAnimal.Name = "btn_cadAnimal";
            this.btn_cadAnimal.Size = new System.Drawing.Size(250, 50);
            this.btn_cadAnimal.TabIndex = 1;
            this.btn_cadAnimal.Text = "Cadastro Animal";
            this.btn_cadAnimal.UseVisualStyleBackColor = false;
            this.btn_cadAnimal.Click += new System.EventHandler(this.btn_cadAnimal_Click);
            // 
            // btn_cadVeterinario
            // 
            this.btn_cadVeterinario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_cadVeterinario.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadVeterinario.Location = new System.Drawing.Point(261, 208);
            this.btn_cadVeterinario.Name = "btn_cadVeterinario";
            this.btn_cadVeterinario.Size = new System.Drawing.Size(250, 50);
            this.btn_cadVeterinario.TabIndex = 2;
            this.btn_cadVeterinario.Text = "Cadastro Veterinario";
            this.btn_cadVeterinario.UseVisualStyleBackColor = false;
            // 
            // btn_produtos
            // 
            this.btn_produtos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_produtos.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produtos.Location = new System.Drawing.Point(261, 264);
            this.btn_produtos.Name = "btn_produtos";
            this.btn_produtos.Size = new System.Drawing.Size(250, 50);
            this.btn_produtos.TabIndex = 3;
            this.btn_produtos.Text = "Produtos";
            this.btn_produtos.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sair.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(261, 320);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(250, 50);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_petCare
            // 
            this.lbl_petCare.AutoSize = true;
            this.lbl_petCare.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_petCare.Location = new System.Drawing.Point(349, 31);
            this.lbl_petCare.Name = "lbl_petCare";
            this.lbl_petCare.Size = new System.Drawing.Size(80, 22);
            this.lbl_petCare.TabIndex = 13;
            this.lbl_petCare.Text = "PetCare";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_petCare);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_produtos);
            this.Controls.Add(this.btn_cadVeterinario);
            this.Controls.Add(this.btn_cadAnimal);
            this.Controls.Add(this.btn_cadCliente);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cadCliente;
        private System.Windows.Forms.Button btn_cadAnimal;
        private System.Windows.Forms.Button btn_cadVeterinario;
        private System.Windows.Forms.Button btn_produtos;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_petCare;
    }
}