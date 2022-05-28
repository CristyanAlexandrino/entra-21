using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entra21.ExerciciosOrientacaoObjeto;

namespace Entra21.ExerciciosOrientacaoObjeto.ValidarInformacoes
{
    public class NomeCorreto
    { 
        public string NomeValido()
        {
            var nome = Console.ReadLine().Trim();
            var nomeValido = false;
            while (nomeValido == false)
            {
                if (nome.Length > 3)
                {
                    nomeValido = true;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Nome não pode ter menos que 3 caracteres");
                    Console.ForegroundColor = ConsoleColor.Green;
                    nome = Console.ReadLine();
                    
                }

            }
            return nome;
        }
    }
}
