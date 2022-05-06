using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosWhile
{
    internal class Exemplo05
    {
        public void Executar()
        {
            string texto = "";
            string nome = "";
            while (nome != "fim")
            {
                Console.WriteLine("Digite um nome: ");
                nome = Console.ReadLine();
                texto = texto + nome + "\n";
            }
        }
    }
}
