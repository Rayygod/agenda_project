using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace agenda_project.Data
{
    static internal class conexao_db
    {
        static public MySqlConnection cria_conexao()
        {
            //string com as informações do servidor para se conectar como IP e etc
            string stringConexao = "Server=127.0.0.1;Database=bd_agenda;User ID=root;Password=root;";
            // criando conexão
            MySqlConnection conexao = new MySqlConnection(stringConexao);
            // retorna a conexao la pro outro forms para que ele tambem consigo abrir a conexao com o banco de dados
            return conexao;
        }
    }
}
