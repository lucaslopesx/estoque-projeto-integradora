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
    public partial class Cadastrar_Produto : Form
    {
        public Cadastrar_Produto()
        {
            InitializeComponent();
        }
        Classes.Setor dataSetor = new Classes.Setor();
        Classes.Produto dataProduto = new Classes.Produto();
        Classes.Fornecedor dataFornecedor = new Classes.Fornecedor();
        Classes.Estoque dataEstoque = new Classes.Estoque();

        private void Cadastrar_Produto_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nomeSetor";
            comboBox1.ValueMember = "idSetor";
            comboBox1.DataSource = dataSetor.List().Tables[0];
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            /*cbFornecedor.DisplayMember = "nomeFornecedor";
            cbFornecedor.ValueMember = "idFornecedor";
            cbFornecedor.DataSource = dataFornecedor.List().Tables[0];
            cbFornecedor.DropDownStyle = ComboBoxStyle.DropDownList;*/
        }

        private void cmdCadastrar_Click(object sender, EventArgs e)
        {
            dataProduto.IdSetor = int.Parse(comboBox1.SelectedValue.ToString());
            dataProduto.NomeProduto = txtNomeProduto.Text;
            dataProduto.DescProduto = txtDesc.Text;
            dataProduto.PrecoProduto = txtPreco.Text;
            dataProduto.FotoProduto = null;
            dataProduto.InsertProduto();

            /*dataEstoque.DataValEstoque = dateTimePicker1.Text.ToString();
            dataEstoque.QtdEstoque = int.Parse(nudQuantidade.ToString());
            dataEstoque.IdFornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());
            dataEstoque.IdProduto = ;

            dataEstoque.InsertEstoque();*/


        }
    }
}
