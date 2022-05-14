using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo01
    {
        public void Executar()
        {
            for(int i = 0; i <= 23; i = i + 1)
            {
                for (int j = 0; j < 60; j++)
                {
                    for(int k = 0; k <= 59; k++)
                    {
                        Console.WriteLine(i + ":" + j + ":" + k);
                    }
                }
            }
        }
    }
}
