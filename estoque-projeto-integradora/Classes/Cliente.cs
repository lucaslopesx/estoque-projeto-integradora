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
        public void AlterarCliente()
        {
            string sql = $"Update Cliente set cpfCliente = '{CpfCliente}',enderecoCliente = '{EnderecoCliente}', telefoneCliente = '{TelefoneCliente}' Where idCliente =" + IdCliente.ToString();
            connection.Execute(sql);
        }

        public void Excluir()
        {
            string sql = $"Delete Cliente where idCliente = {IdCliente.ToString()}";
            connection.Execute(sql);
        }
        public DataSet List()
        {
            string sql = "Select * from Cliente";
            connection.ListInfo(sql);

            connection.Disconnect();
            return connection.ds;
        }

        public void ConsultarDados()
        {
            string sql = $"Select * from Cliente where idCliente = {IdCliente}";
            connection.Consult(sql);

            if (connection.dr.Read())
            {
                CpfCliente = connection.dr["cpfCliente"].ToString();
                EnderecoCliente = connection.dr["enderecoCliente"].ToString();
                TelefoneCliente = connection.dr["telefoneCliente"].ToString();

            }
            connection.Disconnect();
        }
    }
}
