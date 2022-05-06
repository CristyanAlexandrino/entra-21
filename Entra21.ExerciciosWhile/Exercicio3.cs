using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio3
    {
        public void Executar()
        {
            int idade = 128;
            int idadeUsuario = 0;
            while (idade >= idadeUsuario)
            {
                Console.WriteLine("Digite uma idade: ");
                idadeUsuario = Convert.ToInt32(Console.ReadLine());
            }
            

        }

    }
}
