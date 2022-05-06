using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo06
    {
        public void Executar()
        {
            Console.WriteLine("Digite a quantidade desejada: ");
            int quantidadeDesejada =Convert.ToInt32(Console.ReadLine());
            int indice = 0;
            while (indice < quantidadeDesejada)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine();
                indice++;
            }
        }
    }
}
