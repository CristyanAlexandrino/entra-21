using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class Exercicio04
    {
        public void Executar()
        {
            double[] notas = new double[4];
            var media = 0.0;
            string[] nomeAlunos = {""};
            var testeNota = 0.0;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Digite o nome do Aluno: ");
                nomeAlunos[i] = Console.ReadLine();
                Console.WriteLine("Valor Nota: ");
                notas[i] = Convert.ToDouble(Console.ReadLine());
                testeNota = notas[i];
                if (testeNota < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Nota não pode ser menor que 0.");
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else 
                {
                    notas[i] = testeNota;
                }
               
                media = media + notas[i];
            }
                media = media / 4;
                Console.WriteLine(@"Nome Aluno: " + nomeAlunos[] + 
                "\nMedia de notas: " + media);

        }

    }
}
