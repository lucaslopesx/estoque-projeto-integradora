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
        int i;

        Classes.Produto dataProduto = new Classes.Produto();
        Classes.Cliente dataCliente = new Classes.Cliente();
        Classes.Funcionario dataFuncionario = new Classes.Funcionario();
        Classes.Pedidos dataPedido = new Classes.Pedidos();
        Classes.ItensPedido dataItensPedido = new Classes.ItensPedido();
        Classes.Estoque dataEstoque = new Classes.Estoque();
        Classes.Geral dataGeral = new Classes.Geral();
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
                quantidade = int.Parse(nudQtdItensPedido.Text);
                total = preco * quantidade;
                txtPrecoPedido.Text = total.ToString() ;
            }
        }
        private void cmdIniciarPedido_Click(object sender, EventArgs e)
        {
            dataPedido.DataPedido = dateTimePicker1.Value.ToString();
            dataPedido.Preco = 0;
            dataPedido.IdFuncionario = int.Parse(cbFuncionario.SelectedValue.ToString());
            dataPedido.IdCliente = int.Parse(cbCliente.SelectedValue.ToString());
            dataPedido.InsertPedido();

            cbProduto.DisplayMember = "nomeProduto";
            cbProduto.ValueMember = "idProduto";
            cbProduto.DataSource = dataGeral.ListProdutoENumLote().Tables[0];
            cbProduto.DropDownStyle = ComboBoxStyle.DropDownList;


        }
        private void cbProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGeral.IdProduto = int.Parse(cbProduto.SelectedValue.ToString());

            cbNumLote.DisplayMember = "numeroLote";
            cbNumLote.ValueMember = "idEstoque";
            cbNumLote.DataSource = dataGeral.ListNumeroLote().Tables[0];
            cbNumLote.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        

        private void cmdAddProduto_Click(object sender, EventArgs e)
        {
            i++;
            dataItensPedido.PrecoItensPedido = Decimal.Parse(txtPrecoProduto.Text);
            dataItensPedido.QuantidadeItensPedido = int.Parse(nudQtdItensPedido.Value.ToString());
            dataItensPedido.IdPedido = int.Parse(dataPedido.getLastIdPedido().ToString());

        }

        private void Realizar_Pedido_Load(object sender, EventArgs e)
        {
            cbCliente.DisplayMember = "nomeCliente";
            cbCliente.ValueMember = "idCliente";
            cbCliente.DataSource = dataCliente.List().Tables[0];
            cbCliente.DropDownStyle = ComboBoxStyle.DropDownList;

            cbFuncionario.DisplayMember = "nomeFuncionario";
            cbFuncionario.ValueMember = "idFuncionario";
            cbFuncionario.DataSource = dataFuncionario.List().Tables[0];
            cbFuncionario.DropDownStyle = ComboBoxStyle.DropDownList;

            /*
            cbProduto.DisplayMember = "nomeProduto";
            cbProduto.ValueMember = "idProduto";
            cbProduto.DataSource = dataProduto.List().Tables[0];
            cbProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            */
        }

        private void cmdConfirmar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
