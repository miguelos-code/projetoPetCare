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
    public partial class frmCadastroAnimal : Form
    {
        public frmCadastroAnimal()
        {
            InitializeComponent();
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_idAnimal.Clear();
            txt_pesoAnimal.Clear();
            txt_corAnimal.Clear();
            txt_nomeAnimal.Clear();
            txt_detalheAnimal.Clear();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
