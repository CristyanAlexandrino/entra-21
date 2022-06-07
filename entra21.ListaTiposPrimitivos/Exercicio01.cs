using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ListaTiposPrimitivos
{
    public class Exercicio01
    {
        public void Executar()
        {
            Console.Clear();
            List<string> os_Melhores_Filmes_De_Todos_Os_Tempos = new List<string>();
            os_Melhores_Filmes_De_Todos_Os_Tempos.Add("Dragon Ball Evolution");
            os_Melhores_Filmes_De_Todos_Os_Tempos.Add("Titanic");
            os_Melhores_Filmes_De_Todos_Os_Tempos.Add("Lanterna Verde");
            os_Melhores_Filmes_De_Todos_Os_Tempos.Add("");

            // Alterar
            var indiceFilme = os_Melhores_Filmes_De_Todos_Os_Tempos.IndexOf("Dragon Ball Evolution");
            os_Melhores_Filmes_De_Todos_Os_Tempos[indiceFilme] = "Dragon Ball Super: Broly";

            //Remover Filme
            os_Melhores_Filmes_De_Todos_Os_Tempos.Remove("Lanterna Verde");

            // Descobrir se existe na lista
            var contemFilme = os_Melhores_Filmes_De_Todos_Os_Tempos.Contains("Lanterna Verde");
            if (contemFilme == false)
            {
                Console.WriteLine("Filme não cadastrado");
            }
            else
            {
                Console.WriteLine("Cadastrado");
            }

            // Adicionar 
            os_Melhores_Filmes_De_Todos_Os_Tempos.Add("Quarteto Fantastico");

            // Listar filmes armazenados
            Console.WriteLine($@"Filmes: 
{os_Melhores_Filmes_De_Todos_Os_Tempos[0]}
{os_Melhores_Filmes_De_Todos_Os_Tempos[1]}
{os_Melhores_Filmes_De_Todos_Os_Tempos[2]}
{os_Melhores_Filmes_De_Todos_Os_Tempos[3]}");

            // Alterar Filme (Titanic)
            indiceFilme = os_Melhores_Filmes_De_Todos_Os_Tempos.IndexOf("Titanic");
            os_Melhores_Filmes_De_Todos_Os_Tempos[indiceFilme] = "Titanic 2";

            // Listar os filmes armazenados
            Console.WriteLine($@"Filmes Atuais: 
{os_Melhores_Filmes_De_Todos_Os_Tempos[0]}
{os_Melhores_Filmes_De_Todos_Os_Tempos[1]}
{os_Melhores_Filmes_De_Todos_Os_Tempos[2]}
{os_Melhores_Filmes_De_Todos_Os_Tempos[3]}
");

            // Verificar se existe o filme "Lagoa Azul" e apresentar
            contemFilme = os_Melhores_Filmes_De_Todos_Os_Tempos.Contains("Lagoa Azul");
            if (contemFilme == false)
            {
                Console.WriteLine("Filme não Cadastrado");

            }
            else
            {
                Console.WriteLine("Filme Cadastrado");
            }

        }

    }
}
