using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo02
    {
        public void Executar()
        {
            int quantidadeSc = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a sigla do seu estado: ");
                string estado = Console.ReadLine().Trim().ToLower();
                if (estado == "sc")
                {
                    quantidadeSc = quantidadeSc + 1;
                }
            }
            Console.WriteLine("quantidade SC:" + quantidadeSc);
        }
    }
}
