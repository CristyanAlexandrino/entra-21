namespace Entra21.ExemploObjeto
{
    internal class ProdutoServico
    {
        private List<Produto> produtos = new List<Produto>();

        // Armazenar o código do proximo produto
        private int codigoAtual = 1;

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

            // Atribuir o código novo para o objeto fo produto
            produto.Codigo = codigoAtual;

            // Adicionar 1 no código atual para quando criar um novo produto o produto conter outro código
            codigoAtual = codigoAtual++;

            // Adicionar o produto instanciado na lista de produtos
            produtos.Add(produto);
        }

        public bool Editar(int codigoAlterar, string nome, double precoUnitario,
            ProdutoLocalizacao localizacao, int quantidade)
        {
            // Obtem o produto desejado da lista de produtos
            Produto produtoParaAlterar = ObterPorCodigo(codigoAlterar);

            if (produtoParaAlterar == null)
            {
                // Retorno falso pq não existe produto com o código dos parametros
                return false;
            }

            // Atualiza as propriedades (campos) do produto desejado
            produtoParaAlterar.Nome = nome;
            produtoParaAlterar.Localizacao = localizacao;
            produtoParaAlterar.PrecoUnitario = precoUnitario;
            produtoParaAlterar.Quantidade = quantidade;

            // Retorna verdadeiro pq foi possivel alterar o produto
            return true;

        }

        public bool Apagar(int codigo)
        {
            for (int i = 0; i < produtos.Count; i++)
            {
                //Resgatando de uma lista de tipos primitivos
                // int numero = numeros[i];

                // Resgatando de uma lisra de objetos
                Produto produto = produtos[i];
                if (produto.Codigo == codigo)
                {
                    //Posso remover com o indice do objeto desejado
                    // produtos.RemoveAt(i);

                    //Posso remover com o objeto desejado 
                    produtos.Remove(produto);
                    // Retorna verdadeiro pq o produto com o codigo desejado foi removido da lista
                    return true;
                }
            }
            // Retorna falso pq não foi encontrado produto com o código desejado ou seja,
            // nenhum elemento foi removido da lista
            return false;
        }

        public List<Produto> ObterTodos()
        {
            return produtos;
        }
        public Produto ObterPorCodigo(int codigo)
        {
            // Percorrer todos os elementos para encontrar o produto filtrado por código
            for (int i = 0; i < produtos.Count; i++)
            {
                // Obter o produto da lista de produtos em determinado indice
                var produtoAtual = produtos[i];

                // Verificar se o produto atual da lista percorrida é o desejado
                if (produtoAtual.Codigo == codigo)
                {
                    // Retorna o produto encontrado
                    return produtoAtual;
                }
            }

            // Retonar null, caso encontre um produto com o codigo passado como parâmetro
            return null;
        }
    }
}
