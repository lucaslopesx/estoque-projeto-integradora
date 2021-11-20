using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    internal class Estoque
    {
        Connection connection = new Connection();

        public int IdEstoque { get; set; }
        public string DataValEstoque { get; set; }
        public string NumeroLote { get; set; }
        public int QtdEstoque { get; set; }
        public int IdProduto { get; set; }
        public int IdFornecedor { get; set; }

        public void InsertEstoque()
        {
            string sql = $"Insert into Estoque (dataValEstoque, numeroLote, qtdEstoque, idProduto, idFornecedor) values ('{DataValEstoque}', '{NumeroLote}', '{QtdEstoque}', '{IdProduto}', '{IdFornecedor}')";
            connection.Execute(sql);
        }

        public DataSet List()
        {
            string sql = "Select * from Estoque";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
        public DataSet ListNumLote()
        {
            string sql = "Select * from Estoque";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
    }
}
