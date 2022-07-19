namespace Entra21.BancoDados01.Ado.Net.Models
{
    internal class Cidade
    {
        public int Id { get; set; }
        public UnideFederativa UnidadeFederativa { get; set; }
        public string Nome { get; set; }
        public int quantidadeHabitantes { get; set; }
        public DateTime Fundacao { get; set; }
    }
}
