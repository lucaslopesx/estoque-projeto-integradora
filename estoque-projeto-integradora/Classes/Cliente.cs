using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    internal class Cliente
    {
        Connection connection = new Connection();

        public int IdCliente { get; set; }
        public string CpfCliente { get; set; }
        public string NomeCliente { get; set; }
        public string EnderecoCliente { get; set; }
        public string TelefoneCliente { get; set; }


        public void InsertCliente()
        {
            string sql = $"Insert into Cliente (cpfCliente, nomeCliente, enderecoCliente, telefoneCliente) values ('{CpfCliente}', '{NomeCliente}', '{EnderecoCliente}', '{TelefoneCliente}')";
            connection.Execute(sql);
        }
        public DataSet List()
        {
            string sql = "Select * from Cliente";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }
    }
}
