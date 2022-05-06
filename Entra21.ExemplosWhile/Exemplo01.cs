using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo01
    {
        public void Executar()
        {
            int indice = 0;
            int soma = 0;
            int quantidadesPositivos = 0;
            while (indice < 3)
            {
                Console.WriteLine("Digite o numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                indice++;
                soma = soma + numero;

                if (numero > 0)
                {
                    quantidadesPositivos++;
                }
            }
            Console.WriteLine("Soma" + soma + "\n Positivos: " + quantidadesPositivos);
        }
    }
}
