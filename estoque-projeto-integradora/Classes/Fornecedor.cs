using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    internal class Fornecedor
    {
        Connection connection = new Connection();

        public int IdFornecedor { get; set; }
        public string CnpjFornecedor { get; set; }
        public string NomeFornecedor { get; set; }
        public string TelefoneFornecedor { get; set; }


        public void InsertFornecedor()
        {
            string sql = $"Insert into Fornecedor (cnpjFornecedor, nomeFornecedor, telefoneFornecedor) values ('{CnpjFornecedor}', '{NomeFornecedor}', '{TelefoneFornecedor}')";
            connection.Execute(sql);
        }
        public DataSet List()
        {
            string sql = "Select * from Fornecedor";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
    }
}
