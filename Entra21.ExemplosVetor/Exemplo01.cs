using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosVetor
{
    internal class Exemplo01
    {
        public void Executar() 
        {
            int[] numeros = new int[3];
            numeros[0] = 14;
            numeros[1] = 27;
            numeros[2] = 36;
            int soma = numeros[0] + numeros[1] + numeros[2];
            Console.WriteLine(soma);
        }

    }
}
