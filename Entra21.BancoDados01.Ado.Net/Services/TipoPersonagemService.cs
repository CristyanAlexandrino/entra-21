using Entra21.BancoDados01.Ado.Net.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    // Dois pontos seguidos de uma interface, quer dizer que a classe
    // será obrigada a implementar os métodos(contratos) estabelecidos
    // na interface 
    internal class TipoPersonagemService : ITipoPersonagemService
    {
        public void Cadastrar(TipoPersonagem tipoPersonagem)
        {
            throw new NotImplementedException();

            // Instanciando um objeto da classe SqlConnection,
            // que permitirá fazer selects, isenrts, updates, deletes, etc.
            SqlConnection conexao = new SqlConnection();

            // string qie contém o caminho para o banco de dados, o
            // que permitirá conectar ao bando de dados
            var connectionsString = @"";

            //Definir o caminho da conexão para o SqlConnection
            conexao.ConnectionString = connectionsString;

            // Abrir a conexão com o banco de dados
             conexao.Open();
        }
    }
}
