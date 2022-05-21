using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio01
    {
        public void Executar()
        {
            int[] numeros = new int[16];
            int soma = 0;
            for (int i = 0; i < numeros.Length; i++)
            {
                try
                {
                    Console.WriteLine("Digite um numero: ");
                    numeros[i] = Convert.ToInt32(Console.ReadLine());
                    soma = soma + numeros[i];
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Digite um numero inteiro valido");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            Console.WriteLine("a Soma dos numeros é: " + soma);

        }
    }
}
