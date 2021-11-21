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
    public partial class Pesquisar : Form
    {
        Classes.Geral dataGeral = new Classes.Geral();

        public Pesquisar()
        {
            InitializeComponent();
        }

        private void cmdPesquisar_Click(object sender, EventArgs e)
        {
            dataGeral.Combo = comboBox1.SelectedItem.ToString();
            dataGeral.Busca = txtBusca.Text;


            dataGridView1.DataSource = dataGeral.ListBy().Tables[0];
        }
    }
}
