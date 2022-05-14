using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosFor
{
    internal class Exemplo03
    {
        public void Executar()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Nome: ");
                string nome = Console.ReadLine().Trim();
                while(nome.Length < 5)
                {
                    Console.WriteLine("Nome deve conter no mínimo 5 caracteres");
                    Console.WriteLine("Nome: ");
                    nome = Console.ReadLine().Trim();
                }
            }
        }
    }
}
