using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio03
    {
        public void Executar()
        {
            string[] nomeProdutos = new string[7];
            double[] precoProdutos = new double[7];
            var preco = 0.0;
            for (int i = 0; i < nomeProdutos.Length && i < precoProdutos.Length; i++)
            {
                Console.WriteLine("Digite o nome do produto: ");
                nomeProdutos[i] = Console.ReadLine();
                Console.WriteLine("Digite o valor do produto: ");
                precoProdutos[i] = Convert.ToDouble(Console.ReadLine());
            }
            Console.Clear();


        }

    }
}
