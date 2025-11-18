using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPetCare
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Senha;

            Usuario = txt_usuario.Text;
            Senha = txt_senha.Text;
            
            if(Usuario == "admin" && Senha == "1234")
            {
                frmMenuPrincipal abrir = new frmMenuPrincipal();
                abrir.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario ou senha inválidos");
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_usuario.Clear();
            txt_senha.Clear();
        }
    }
}
