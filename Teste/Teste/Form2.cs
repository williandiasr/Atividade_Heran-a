using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste
{
    public partial class frmcarro : Form
    {

        Carro carro;
        public frmcarro()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            carro = new Carro(txtmodelo.Text,txtabast.Text,txtplaca.Text, Convert.ToInt32(txtchassi.Text), txtmarca.Text, Convert.ToInt32(txtqtd), Convert.ToDouble(txtcap.Text));
            txtmarca.Clear();
            txtabast.Clear();
            txtcap.Clear();
            txtchassi.Clear();
            txtmodelo.Clear();
            txtplaca.Clear();
            txtqtd.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(carro.ImprimeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcadastro frmcadastro = new frmcadastro();
            frmcadastro.Show();
        }
    }
}
