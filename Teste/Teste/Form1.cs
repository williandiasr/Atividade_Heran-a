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
    public partial class frmcadastro : Form
    {
        public frmcadastro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncarro_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcarro carro = new frmcarro();
            carro.Show();
        }

        private void btncaminhao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmcaminhao caminhao = new frmcaminhao();
            caminhao.Show();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
