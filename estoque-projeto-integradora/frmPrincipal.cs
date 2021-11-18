using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_projeto_integradora
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //frmFornecedor ff = new frmFornecedor();
            //ff.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmCadastroEstoque fce = new frmCadastroEstoque();
            fce.MdiParent = this;
            fce.Show();
        }
    }
}
