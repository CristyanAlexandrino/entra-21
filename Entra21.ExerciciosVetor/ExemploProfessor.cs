﻿using ConsoleTables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosVetor
{
    internal class ExemploProfessor
    {
        public void Executar()
        {
            var table = new ConsoleTable("one", "two", "three");
            table.AddRow(1, 2, 3)
                 .AddRow("this line should be longer", "yes it is", "oh")
                 .AddRow("Pizza Calabresa", "Calabresa, queoijo e molho de tomate", "29.90");
            

            table.Write();
            Console.WriteLine();
        }
    }
}
