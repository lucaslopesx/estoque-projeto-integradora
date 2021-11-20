using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    class Produto
    {
        Connection connection = new Connection();

        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public string DescProduto { get; set; }
        public string PrecoProduto { get; set; }
        public int IdSetor { get; set; }
        public string FotoProduto { get; set; }

        public void InsertProduto()
        {
            string sql = $"Insert into Produto (nomeProduto, descProduto, precoProduto, idSetor, fotoProduto) values ('{NomeProduto}', '{DescProduto}', '{PrecoProduto}', '{IdSetor}', '{FotoProduto}')";
            connection.Execute(sql);
        }

        public DataSet List()
        {
            string sql = "Select * from Produto";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
    }
}
