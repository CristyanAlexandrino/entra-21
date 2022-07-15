using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.DataBase
{
    internal class Conexao
    {
        public SqlConnection Conectar()
        {

            // Instanciando um objeto da classe SqlConnection,
            // que permitirá fazer selects, isenrts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection();

            // string qie contém o caminho para o banco de dados, o
            // que permitirá conectar ao bando de dados
            var connectionsString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Server\c#-noturno\cristyan.alexandrino\Desktop\ExemploBancoDados01AdoNet.mdf;Integrated Security=True;Connect Timeout=30";

            //Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionsString;

            // Abrir a conexão com o banco de dados
            conexao.Open();
        
            return conexao;
        }
    }
}
