using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace estoque_projeto_integradora.Classes
{
    class Funcionario
    {
        Connection connection = new Connection();

        public int IdFuncionario { get; set; }
        public string CpfFuncionario { get; set; }
        public string NomeFuncionario{ get; set; }
        public string DataNascFuncionario { get; set; }
        public string EnderecoFuncionario { get; set; }
        public string TelefoneFuncionario { get; set; }
        public string CargoFuncionario { get; set; }


        public void InsertFuncionario()
        {
            string sql = $"Insert into Funcionario (cpfFuncionario, nomeFuncionario, dataNascFuncionario, enderecoFuncionario, telefoneFuncionario, cargoFuncionario) values ('{CpfFuncionario}', '{NomeFuncionario}', '{DataNascFuncionario}', '{EnderecoFuncionario}', '{TelefoneFuncionario}', '{CargoFuncionario}')";
            connection.Execute(sql);
        }
    }
}
