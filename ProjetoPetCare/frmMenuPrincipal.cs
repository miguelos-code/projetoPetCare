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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            frmLogin abrir = new frmLogin();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadCliente_Click(object sender, EventArgs e)
        {
            frmCadastroCliente abrir = new frmCadastroCliente();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadAnimal_Click(object sender, EventArgs e)
        {
            frmCadastroAnimal abrir = new frmCadastroAnimal();
            abrir.Show();
            this.Hide();
        }

        private void btn_cadVeterinario_Click(object sender, EventArgs e)
        {
            frmCadastroVeterinario abrir = new frmCadastroVeterinario();
            abrir.Show();
            this.Hide();
        }

        private void btn_produtos_Click(object sender, EventArgs e)
        {
            frmProdutos abrir = new frmProdutos();
            abrir.Show();
            this.Hide();
        }
    }
}
