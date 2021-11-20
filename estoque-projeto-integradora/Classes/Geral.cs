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


        public DataSet ListBy()
        {
            string sql = $"Select * from {Combo}";
            connection.ListInfo(sql);
            connection.Disconnect();
            return connection.ds;
        }



    }
}
