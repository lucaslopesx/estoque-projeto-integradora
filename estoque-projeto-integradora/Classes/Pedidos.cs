using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    internal class Pedidos
    {
        Connection connection = new Connection();

        public int IdPedido { get; set; }
        public string DataPedido { get; set; }
        public Decimal Preco { get; set; }
        public int IdFuncionario { get; set; }
        public int IdCliente { get; set; }


        public void InsertPedido()
        {
            string sql = $"Insert into Pedidos (DataPedido, Preco, IdFuncionario, IdCliente) values ('{DataPedido}', '{Preco}', '{IdFuncionario}', '{IdCliente}')";
            connection.Execute(sql);
        }

        public object getLastIdPedido()
        {
            string sql = "select top 1 * from pedidos order by idPedido desc";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds.Tables[0].Rows[0].ItemArray[0];
        }
    }
}
