using Entra21.BancoDados01.Ado.Net.Models;

namespace Entra21.BancoDados01.Ado.Net.Services
{
    internal interface IPersonagemService
    {
        List<Personagem> ObterTodos();
        Personagem ObterPorId(int id);
        void Cadastrar(Personagem personagem);
        void Apagar(int id);
    }
}