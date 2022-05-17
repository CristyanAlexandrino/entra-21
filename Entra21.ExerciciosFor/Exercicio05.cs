using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio05
    {
        public void Executar()
        {
            var mediaAno = 0;
            var mediaPreco = 0.0;
            var comecaComA = 0;
            var comecaComG = 0;
            var quantidadeCadastro = 0;
            var anoCarro = 0;
            var preco = 0.0;
            try
            {
                Console.WriteLine("Quantos carros quer cadastrar: ");
                quantidadeCadastro = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Digite um numero valido maior que zero");
                Console.ForegroundColor = ConsoleColor.Green;
            }

            for (int i = 0; i < quantidadeCadastro; i++)
            {

                Console.WriteLine("Digite o modelo: ");
                var modelo = Console.ReadLine().ToUpper().Trim();
                try
                {

                    Console.WriteLine("Digite o ano de fabricação: ");
                    anoCarro = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um ano valido");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                try
                {
                    Console.WriteLine("Digite o Preço: ");
                    preco = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Preço não pode ser menor ou igual a zero");
                    Console.ForegroundColor = ConsoleColor.Green;

                }

                mediaAno = mediaAno + anoCarro;
                mediaPreco = mediaPreco + preco;
                // Logica para  contagem de carros que começam com a letra A ou G
                if (modelo.StartsWith("A"))
                {
                    comecaComA++;
                }
                 if (modelo.StartsWith("G"))
                {
                    comecaComG++;
                }
            }

            mediaAno = mediaAno / quantidadeCadastro;
            mediaPreco = mediaPreco / quantidadeCadastro;
            Console.WriteLine("Media de Anos: " + mediaAno +
    "\nMedia de Preços: " + mediaPreco +
    "\nCarros que começam com A: " + comecaComA +
    "\nCarros que Começam com G: " + comecaComG);
        }
    }
}









