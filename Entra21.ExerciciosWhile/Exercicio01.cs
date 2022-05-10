using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio01
    {
        public void Executar()
        {

            int willie = 0;
            string nomePeca = "";
            double precoPeca = 0;
            while (willie < 13)
            {
                Console.Write("Digite o nome da peça: ");
                nomePeca = Console.ReadLine();
                Console.WriteLine("Digite o preço da peça: ");
                precoPeca = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                willie++;

            }


        }
    }
}
