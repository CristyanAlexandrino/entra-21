using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio5
    {
        public void Executar()
        {

            Console.Write("Quantos carros deseja cadastrar: ");
            int quantidadeCadastro = Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            double mediaAnoCarros = 0;
            double mediaValorCarros = 0;
            int carrosInicioG = 0;
            int carrosInicioA = 0;
            int somaAnoCarros = 0;
            double somaValorCarros = 0;
            while (indice < quantidadeCadastro)
            {
                Console.WriteLine("Digite o modelo carro: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Valor do carro: ");
                double valorCarro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Ano de fabricação do carro: ");
                int anoCarro = Convert.ToInt32(Console.ReadLine());
                string nomeCarro = modelo.Substring(0, 1);
                if (nomeCarro == "G")
                {
                    carrosInicioG++;
                }
                else if (nomeCarro == "A")
                {
                    carrosInicioA++;
                }
                somaAnoCarros = somaAnoCarros + anoCarro;
                somaValorCarros = somaValorCarros + valorCarro;
                indice++;
            }
            mediaAnoCarros = somaAnoCarros / quantidadeCadastro;
            mediaValorCarros = somaValorCarros / quantidadeCadastro;
            Console.WriteLine("A media de anos dos carros é :" + mediaAnoCarros + " \nmédia de valores dos carros é: " + mediaValorCarros + "\nquantidade de carros com a letra G" + carrosInicioG + "\nquantidade de carros com a letra A: " + carrosInicioA);
        }
    }
}
