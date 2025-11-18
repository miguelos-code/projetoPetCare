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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente()
        {
            InitializeComponent();
            DesabilitarCampos();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            HabilitarCampos();
        }

        private void DesabilitarCampos()
        {
            txt_nome.Enabled = false;
            txt_idade.Enabled = false;
            txt_codigo.Enabled = false;
        }

        private void HabilitarCampos()
        {
            txt_nome.Enabled = true;
            txt_idade.Enabled = true;
            txt_codigo.Enabled = true;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_nome.Clear();
            txt_idade.Clear();
            txt_codigo.Clear();
        }

        private void btn_voltar_Click(object sender, EventArgs e)
        {
            frmMenuPrincipal abrir = new frmMenuPrincipal();
            abrir.Show();
            this.Hide();
        }
    }
}
