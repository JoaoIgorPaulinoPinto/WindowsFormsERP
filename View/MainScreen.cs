using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto0307
{
    public partial class MainScreen: Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void cONSULTARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerenciadorGeral.CarregarNovaTela<CadCliente>(this);
        }

        private void cOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cLIENTEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GerenciadorGeral.CarregarNovaTela<CadProduto>(this);
        }

        private void cLIENTEToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            GerenciadorGeral.CarregarNovaTela<CadCliente>(this);
        }
    }
}
