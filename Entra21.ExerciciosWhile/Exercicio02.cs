using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio02
    {
        public void Executar()
        {
            string nome = "";
            string texto = "";
            while (nome != "fim")

            {
                Console.WriteLine("Digite um nome: ");
                nome = Console.ReadLine();
                texto = texto + nome;

            }
        }

    }
}
