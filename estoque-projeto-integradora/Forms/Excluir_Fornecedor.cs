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
    public partial class Excluir_Fornecedor : Form
    {
        public Excluir_Fornecedor()
        {
            InitializeComponent();
        }
        Classes.Fornecedor dados = new Classes.Fornecedor();
        private void Excluir_Fornecedor_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nomeFornecedor";
            comboBox1.ValueMember = "idFornecedor";
            comboBox1.DataSource = dados.List().Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dados.IdFornecedor = int.Parse(comboBox1.SelectedValue.ToString());
            dados.ConsultarDados();
            txtCnpjFornecedor.Text = dados.CnpjFornecedor;
            txtTelefoneFornecedor.Text = dados.TelefoneFornecedor;
        }

        private void cmdExclu_Click(object sender, EventArgs e)
        {
            dados.Excluir();
            MessageBox.Show("Dados alterados");
        }
    }
}
