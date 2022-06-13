namespace Entra21.ExemploObjeto
{
    internal class ProdutoController
    {
        private ProdutoServico produtoServico = new ProdutoServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            while (codigo != 6)
            {
                Console.Clear();
                codigo = AprensentarSolicitarMenu();
                Console.Clear();


                if (codigo == 1)
                {
                    // Menu escolhido para listar produtos
                    ApresentarProdutos();
                }
                else if (codigo == 2)
                {
                    // Menu escolhido para cadastrar produto
                    Cadastrar();
                }
                else if (codigo == 3)
                {
                    // Menu escolhido para editar produto
                    Editar();
                }
                else if (codigo == 4)
                {
                    // Apagar();
                }
                else if (codigo == 5)
                {
                    // ApresentarProduto();
                }
                Console.WriteLine("\n\nAperte alguma tecla para continuar...");
            }


        }
        private void ApresentarProduto()
        {

            ApresentarProdutos();

            Console.WriteLine("Digite o código do produto a ser detalhado: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var produto = produtoServico.ObterPorCodigo(codigo);

            // Verifica se o produto não está cadastrado na lista de produtos
            if (produto == null)
            {
                Console.WriteLine("Produto não cadastrado");

                return;
            }
            Console.Clear();
            Console.WriteLine(@$"Código :  {produto.Codigo} 
                Nome: {produto.Nome}
Preço unitário: {produto.PrecoUnitario}
Quantidade: {produto.Quantidade}
Total: {produto.CalcularPrecoTotal()}");
        }
        private void Apagar()
        {
            ApresentarProdutos();

            Console.WriteLine("Digite o código do produto para apagar: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            var registroApagado = produtoServico.Apagar(codigo);

            Console.WriteLine(registroApagado == true
                ? "Registro removido com sucesso"
                : "Nenhum produto cadastrado com o código informado");
        }
        private void Editar()
        {
            ApresentarProdutos();

            Console.WriteLine("Código produto desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nome: ");
            var nome = Console.ReadLine();

            Console.WriteLine("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Preço unitário: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponiveis:
- Armazem
- Area Venda
- Loja");

            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();
            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            var alterou = produtoServico.Editar(codigo, nome, quantidade, precoUnitario, localizacaoProduto);


        }
        private int AprensentarSolicitarMenu()
        {
            Console.WriteLine(@" Menu:
1 - Listar Todos
2 - Cadastrar
3 - Editar
4 - Apagar
5 - Apresentar produto desejado
6 - Sair");

            int codigo = SolicitarCodigo();

            return codigo;
        }
        private int SolicitarCodigo()
        {
            int codigo = 0;

            // Continua solicitando o código até que um seja um código 1 e 6
            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.WriteLine("Digite o código");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Digite um número válido");
                }
            }
            return codigo;
        }
        private void Cadastrar()
        {
            Console.Write("Nome: ");
            var nome = Console.ReadLine();

            Console.Write("Quantidade: ");
            var quantidade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Preço Unitario: ");
            var precoUnitario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(@"Localizações disponiveis:
 - Armazem
- Area Venda
- Loja");
            Console.WriteLine("Localização: ");
            var localizacao = Console.ReadLine();

            var localizacaoProduto = ObterLocalizacaoProduto(localizacao);

            produtoServico.Adicionar(nome, precoUnitario, localizacaoProduto, quantidade);
        }

        private ProdutoLocalizacao ObterLocalizacaoProduto(string localizacao)
        {
            if (localizacao.ToLower() == "armazem")
            {
                return ProdutoLocalizacao.Armazem;
            }
            else if (localizacao.ToLower() == "loja")
            {
                return ProdutoLocalizacao.Loja;
            }
            else
            {
                return ProdutoLocalizacao.AreaVenda;
            }
        }
        private void ApresentarProdutos()
        {
            var produtos = produtoServico.ObterTodos();

            if (produtos.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado");

                // Para a execução desde método
                return;
            }

            for (var i = 0; i < produtos.Count; i++)
            {
                var produtoAtual = produtos[i];
                Console.WriteLine("\nNome: " + produtoAtual.Nome +
                    "\nCódigo: " + produtoAtual.Codigo + "\n");
            }
        }
    }
}
