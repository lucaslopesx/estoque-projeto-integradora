using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace estoque_projeto_integradora.Forms
{
    public partial class Realizar_Pedido : Form
    {
        int quantidade;
        float preco;
        float total;
        public Realizar_Pedido()
        {
            InitializeComponent();
        }

        private void verificar_preco_Click(object sender, EventArgs e)
        {
            if (txtPrecoProduto.Text == "")
                MessageBox.Show("Escolha um produto.");
            else
            {
                preco = float.Parse(txtPrecoProduto.Text);
                quantidade = int.Parse(txtqtd.Text);
                total = preco * quantidade;
                txtPrecoPedido.Text = total.ToString() ;
            }
        }

    }
}
