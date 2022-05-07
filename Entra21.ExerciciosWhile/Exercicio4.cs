using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio4
    {
        public void Executar()
        {
            double peso = 0;
            int quantidadePessoas = 0;
            Console.WriteLine("Digite o seu peso: ");
            peso = Convert.ToDouble(Console.ReadLine());
            while (peso <= 300.00 && peso >= 0)
            {
                Console.WriteLine("Digite o seu peso: ");
                peso = Convert.ToDouble(Console.ReadLine());

                quantidadePessoas++;
            }
            Console.WriteLine(quantidadePessoas + "quantidade de pessoas responderam ");

        }

    }
}
