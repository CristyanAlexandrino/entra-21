namespace Entra21.ExemploObjeto
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();
        // encapsulamento + tipoRetorno + NomeMetodos(paramentros)
        public void Adicionar(string nome, double precoUnitario,
            ProdutoLocalizacao localizacao, int quantidade)
        {
            // Innstanciar um objeto da classe Produto
        Produto produto = new Produto();

            // Atribuir valor para as Propriedades com os dados passados como parâmetros
            produto.Nome = nome;
            produto.PrecoUnitario = precoUnitario;
            produto.Localizacao = localizacao;
            produto.Quantidade = quantidade;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public void Editar() { }

        public void Apagar() { }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo()
        {
            return null;
        }
    }
}
