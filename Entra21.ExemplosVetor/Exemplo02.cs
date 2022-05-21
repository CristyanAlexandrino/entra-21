using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExemplosVetor
{
    internal class Exemplo02
    {
        public void Executar()
        {
            int[] quantidadeHoras = new int[2];
            double[] salarios = new double[2];
            double[] valorHoras = new double[2];
            Console.WriteLine("Quantidade Horas: ");
            quantidadeHoras[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor Hora: ");
            valorHoras[0] = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quantidade Horas: ");
            quantidadeHoras[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor Hora: ");
            valorHoras[1] = Convert.ToDouble(Console.ReadLine());
            salarios[0] = quantidadeHoras[0] * valorHoras[0];
            salarios[1] = quantidadeHoras[1] * valorHoras[1];
            Console.WriteLine("Salario 1: " + salarios[0]);
            Console.WriteLine("Salario 2: " + salarios[1]);



        }
    }
}
