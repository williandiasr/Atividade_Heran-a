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
    public partial class frmcaminhao : Form
    {

        Caminhao caminhao;
        public frmcaminhao()
        {
            InitializeComponent();
        }

        private void btncadastro_Click(object sender, EventArgs e)
        {
            caminhao = new Caminhao(txtmarca.Text, txtcabine.Text, txtplaca.Text, Convert.ToInt32(txtchassi.Text), txtabast.Text, txtcarga.Text, Convert.ToInt32(txtpeso.Text), Convert.ToDouble(txtaltura.Text), Convert.ToInt32 (txtqtdeixo.Text));
            txtmarca.Clear();
            txtcabine.Clear();
            txtplaca.Clear();
            txtchassi.Clear();
            txtabast.Clear();
            txtqtdeixo.Clear();
            txtcarga.Clear();
            txtpeso.Clear();
            txtaltura.Clear();
        }

        private void btnexibir_Click(object sender, EventArgs e)
        {
            MessageBox.Show(caminhao.ImprimeDados());
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcadastro frmcadastro = new frmcadastro();
            frmcadastro.Show();
        }

        private void txtcarga_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
