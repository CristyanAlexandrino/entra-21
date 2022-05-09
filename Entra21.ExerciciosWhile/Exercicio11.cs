using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio11
    {
        public void Executar()
        {
            int opcaoDesejada = 0;
            Console.WriteLine("Digite um numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite outro numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());
            while (opcaoDesejada != 5)
            {
                Console.WriteLine(@" ----------------MENU--------------
| 1            |       Somar      |
| 2            |       Subtrair   |
| 3            |       Multiplicar|
| 4            |       Dividir    |
| 5            |       Sair       |");
                Console.WriteLine("Escolha a opção desejada: ");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                if (opcaoDesejada == 1)
                {
                    Console.WriteLine("A soma é: " + (numero1 + numero2));
                }
                else if (opcaoDesejada == 2)
                {
                    Console.WriteLine("A subtração é: " + (numero1 - numero2));
                }
                else if (opcaoDesejada == 3)
                {
                    Console.WriteLine("A multiplicão é: " + (numero1 * numero2));
                }
                else if (opcaoDesejada == 4)
                {
                    Console.WriteLine("A divisão é:" + (numero1 / numero2));
                }
            }
        }
    }
}
