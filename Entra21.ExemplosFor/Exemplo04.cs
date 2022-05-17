using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo04
    {
        public void Executar()
        {
            Console.WriteLine("Digite a quantidade de carros: ");
            var quantidadeCarros = Convert.ToInt32(Console.ReadLine());
            var somaPrecos = 0.0;
            for (var i = 0; i < quantidadeCarros; i++)
            {
                Console.WriteLine("Modelo Carro: ");
                var modelo = Console.ReadLine();
                Console.WriteLine("Preço: ");
                var precos = Convert.ToDouble(Console.ReadLine());
                somaPrecos = somaPrecos + precos;
            }
            Console.WriteLine("Soma dos Preços: " + somaPrecos);
        }
    }
}
