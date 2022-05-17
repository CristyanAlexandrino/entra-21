using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosFor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            for (int i = 0; i < 13; i++)
            {
                Console.WriteLine("Digite o nome da peça: ");
                var nomePeca = Console.ReadLine();
                Console.WriteLine("Digite o preço da peça:");
                var precoPeca = Convert.ToDouble(Console.ReadLine());

            }
        }
    }
}
