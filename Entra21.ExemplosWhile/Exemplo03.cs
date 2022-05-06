using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo03
    {
        public void Executar()
        {
            string nomeMaiorIdade = "", nomeMenorIdade = "";
            int maiorIdade = 0;
            int menorIdade = 0;
            double somaIdade = double.MaxValue;
            int indice = 0;
            while (indice <= 2)
            {
                Console.WriteLine("Idade: ");
                int idade = Convert.ToInt32(Console.ReadLine());
                somaIdade = somaIdade + idade;
                indice++;
                if (idade > maiorIdade)
                {
                    maiorIdade = idade;
                }
                if (idade < menorIdade)
                {
                    menorIdade = idade;
                }
            }
            double mediaIdade = somaIdade / indice;
            Console.Write("Media das idades: " + mediaIdade + "\n Menor Idade;" + menorIdade + "\n Maior Idade: " + maiorIdade);
        }
    }
}
