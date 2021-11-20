using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    internal class Geral
    {
        Connection connection = new Connection();

        public string Combo { get; set; }
        public string Busca { get; set; }
        public string NumeroLote { get; set; }
        public int IdEstoque { get; set; }
        public int IdProduto { get; set; }


        public DataSet ListBy()
        {
            string sql = $"Select * from {Combo}";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;
        }
        public DataSet ListProdutoENumLote()
        {
            string sql = $"Select * from ProdutoENumLote";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }

        public DataSet ListNumLote()
        {
            string sql = $"Select * from ProdutoENumLote where idEstoque = {IdEstoque}";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }

        public DataSet ListNumeroLote()
        {
            string sql = $"select e.idEstoque, e.numeroLote from Estoque e inner join Produto p on e.idProduto = p.idProduto where e.idProduto = {IdProduto}";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }

    }
}
