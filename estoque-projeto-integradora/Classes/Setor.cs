using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    internal class Setor
    {
        Connection connection = new Connection();

        public int IdFuncionario { get; set; }
        public string NomeSetor { get; set; }


        public void InsertSetor()
        {
            string sql = $"Insert into Setor (nomeSetor) values ('{NomeSetor}')";
            connection.Execute(sql);
        }
    }
}
