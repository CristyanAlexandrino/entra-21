using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo04
    {
        public void Executar()
        {
            int indice1 = 0, indice2 = 0;
            while (indice1 <= 10)
            {
                while (indice2 <= 10)
                {


                    if ((indice1 % 2 == 0) && (indice1 % 2 == 0))
                    {
                        Console.WriteLine(indice1 + "" + indice2);
                    }
                    indice2++;
                }
                indice1++;
                indice1 = 0;
            }
        }
    }
}
