using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosWhile
{
    internal class Exercicio012
    {
        public void Executar()
        {
            Console.WriteLine("Bem Vindo a Padaria do João");
            int opcaoDesejada = 0;
            double valorProduto = 0;
            string nomeProduto = "";
            double total = 0;
            while (opcaoDesejada != 16)
            {


                Console.WriteLine(@"                                  MENU");
                Console.WriteLine(" ------------------------------------------------------------------------");
                Console.WriteLine("|Cód. | Tipos       |       Nome                           |  Valor      |");
                Console.WriteLine("| 1   | Bolos       | Bolo Brigadeiro                      | R$ 29,50    |");
                Console.WriteLine("| 2   | Bolos       | Bolo Floresta Negra                  | R$ 2,00     |");
                Console.WriteLine("| 3   | Bolos       | Bolo Leite com Nutella               | R$ 29,23    |");
                Console.WriteLine("| 4   | Bolos       | Bolo Mousse de Cholocate             | R$ 7,10     |");
                Console.WriteLine("| 5   | Bolos       | Bolo Nega Maluca                     | R$ 19,33    |");
                Console.WriteLine("| 6   | Doces       | Bomba de Creme                       | R$ 17,71    |");
                Console.WriteLine("| 7   | Doces       | Bomba de Morango                     | R$ 4,82     |");
                Console.WriteLine("| 8   | Sanduíches  | Filé-Mignon com fritas e cheddar     | R$ 21,16    |");
                Console.WriteLine("| 9   | Sanduíches  | Hambúrguer,Queijo,champignon e rúcula| R$ 12,70    |");
                Console.WriteLine("| 10  | Sanduíches  | Provolone com salame                 | R$ 19,70    |");
                Console.WriteLine("| 11  | Sabduíches  | Vegetariano de berinjela             | R$ 28,22    |");
                Console.WriteLine("| 12  | Pizzas      | Calabresa                            | R$ 8,98     |");
                Console.WriteLine("| 13  | Pizzas      | Napolitana                           | R$ 0,42     |");
                Console.WriteLine("| 14  | Pizzas      | Peruana                              | R$ 18,36    |");
                Console.WriteLine("| 15  | Pizzas      | Portuguesa                           | R$ 27,50    |");
                Console.WriteLine("| 16                | Sair                                               |");
                Console.WriteLine("Digite a opção desejada: ");
                opcaoDesejada = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe a quantidade: ");
                int quantidade = Convert.ToInt32(Console.ReadLine());
                if (opcaoDesejada == 1)
                {
                    nomeProduto = nomeProduto + "Bolo Brigadeiro R$29,50" + "\n";
                    valorProduto = 29.50;
                    total = total + valorProduto;
                }
                else if (opcaoDesejada == 2)
                {
                    nomeProduto = nomeProduto + "Bolo Floresta Negra R$ 2,00" + "\n";
                    valorProduto = 2.00;
                    total = total + valorProduto;
                }
                else if (opcaoDesejada == 3)
                {
                    nomeProduto = nomeProduto + "Bolo Leite com Nutella R$ 29,23" + "\n";
                    valorProduto = 29.23;
                    total = total + valorProduto;

                }
                else if (opcaoDesejada == 4)
                {
                    nomeProduto = nomeProduto + "Bolo Mousse de Chocolate R$ 7,10" + "\n";
                    valorProduto = 7.10;
                    total = total + valorProduto;
                }
                else if (opcaoDesejada == 5)
                {
                    nomeProduto = nomeProduto + "Bolo Nega Maluca R$ 19,33" + "\n";
                    valorProduto = 19.33;
                    total = total + valorProduto;
                }
                else if (opcaoDesejada == 6)
                {
                    nomeProduto = nomeProduto + "Bomba de Creme R$ 17,71" + "\n";
                    valorProduto = 17.71;
                    total = total + valorProduto;
                }
                else if (opcaoDesejada == 7)
                {
                    nomeProduto = nomeProduto + "Bomba de Morango R$ 4,82" + "\n";
                    valorProduto = 4.82;
                    total = total + valorProduto;
                }
            }
            Console.WriteLine("Lista Pedidos \n" + nomeProduto);
        }

    }
}
