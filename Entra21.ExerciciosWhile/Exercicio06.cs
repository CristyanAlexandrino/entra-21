using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio06
    {
        public void Executar()
        {
            string nomeProduto = "";
            double quantidadeProduto = 0;
            double valorProduto = 0;
            double valorTotal = 0;
            while (nomeProduto != "sair")
            {
                Console.WriteLine("Digite o nome do produto: ");
                nomeProduto = Console.ReadLine();
                if (nomeProduto != "sair")
                {
                    Console.WriteLine("digite a quantidade do produto: ");
                    quantidadeProduto = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor do produto: ");
                    valorProduto = Convert.ToDouble(Console.ReadLine());
                    valorProduto = (quantidadeProduto * valorProduto);
                    valorTotal = valorTotal + valorProduto;
                }
            }
            valorTotal = valorTotal * 0.95;
            Console.WriteLine("Total da Compra: " + valorTotal);


        }
    }
}
