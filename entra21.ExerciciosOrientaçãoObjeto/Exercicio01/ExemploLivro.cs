using Entra21.ExerciciosOrientacaoObjeto.OrietacaoObjetos.Exercicio01;
using Entra21.ExerciciosOrientacaoObjeto.ValidarInformacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ExerciciosOrientacaoObjeto.Exercicio01
{
    public class ExemploLivro
    {

        public void Executar()
        {
            Livro duna = new Livro();
            NomeCorreto nome = new NomeCorreto();
            Console.WriteLine("Informe o nome do Livro: ");
            duna.Titulo = Console.ReadLine().Trim();
            Console.Clear();
          
            Console.WriteLine("Informe o Nome do Autor: ");
            duna.NomeAutor = nome.NomeValido();
            Console.Clear();

            Console.WriteLine("Informe o Codigo ISBN: ");
            duna.CodigoIsbn = Console.ReadLine().Trim();
            Console.Clear();

            Console.WriteLine("O idioma original do livro: ");
            duna.IdiomaOriginal = Console.ReadLine().ToLower().Trim();
            Console.Clear();

            Console.WriteLine("Data de Lançamento (Ano/mes/dia): ");
            duna.DataLancamento = Convert.ToDateTime(Console.ReadLine());
            duna.DataLancamento.ToString("dd/MM/yyyy");
            Console.Clear();

            Console.WriteLine("Quantidade de paginas: ");
            duna.QuantidadePaginas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Quantidade de paginas lidas: ");
            duna.QuantidadePaginasLidas = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Quantidade Releituras: ");
            duna.QuantidadeReleitura = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine( $"Nome do Livro e Autor: {duna.ApresentarTituloAutor()}");
            Console.WriteLine($"Quatidade de paginas: {duna.QuantidadePaginasParaLer()}");
            Console.WriteLine($"Quantidade Paginas Lidas: {duna.QuantidadePaginasLidasNoTotal()}");
            Console.WriteLine($"Data Lançamento: {duna.ApresentarQuantidadeAnosAposPublicacao()} anos");
        }
    }
}
