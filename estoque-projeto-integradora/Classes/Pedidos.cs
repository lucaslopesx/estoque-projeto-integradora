using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
