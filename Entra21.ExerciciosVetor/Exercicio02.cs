using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string[] nomes = new string[10];
            var nome = "";
            for (int i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite um nome: ");
                nomes[i] = Console.ReadLine();
                nome = nome + nomes[i] + "\n";


            }
            Console.Clear();
            Console.WriteLine(nome);
        }
    }
}
