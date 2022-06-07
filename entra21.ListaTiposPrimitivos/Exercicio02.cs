using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entra21.ListaTiposPrimitivos
{
    public class Exercicio02
    {
        public void Executar()
        {
            List<string> conteudos_Passados = new List<string>();
            conteudos_Passados.Add("Como fazer um bolo");

            // Listar Conteúdos
            Console.WriteLine($"Conteudos : {conteudos_Passados[0]}");

            // Alterar Conteúdo (Como fazer um bolo)
            var indiceConteudo = conteudos_Passados.IndexOf("Como fazer um bolo");
            conteudos_Passados[indiceConteudo] = "Algoritmos onde vivem? Do que se alimentam.";

            // Adicionar conteudos
            conteudos_Passados.Add("Variáveis");
            conteudos_Passados.Add("Mais pra frente");

            // Alterar conteudo
            indiceConteudo = conteudos_Passados.IndexOf("Mais pra frente");
            conteudos_Passados[indiceConteudo] = "If com E";

            //Adicionar Conteudos
            conteudos_Passados.Add("If com OU");
            conteudos_Passados.Add("While");
            conteudos_Passados.Add("For");

            // Listar conteúdos
            Console.WriteLine(@$"Conteudos: {conteudos_Passados[0]} 
{conteudos_Passados[1]}
{conteudos_Passados[2]}
{conteudos_Passados[3]}
{conteudos_Passados[4]}");
            

            // Adicionar Conteudos
            conteudos_Passados.Add("Vetor");
            conteudos_Passados.Add("Vetor");

            // Apagar conteudos
            conteudos_Passados.Remove("Vetor");

            //Adicionar Conteudos
            conteudos_Passados.Add("Vetor");

            // Alterar Conteudos
            indiceConteudo = conteudos_Passados.IndexOf("Vetor");
            conteudos_Passados[indiceConteudo] = "Vetor com For um amor da minha vida";

            // Listar Conteudos
            Console.WriteLine($@"Conteudos: {conteudos_Passados[0]}
{conteudos_Passados[1]}
{conteudos_Passados[2]}
{conteudos_Passados[3]}
{conteudos_Passados[4]}
{conteudos_Passados[5]}
{conteudos_Passados[6]}");
            

            // Adicionar Conteudos

            conteudos_Passados.Add("Classe propriedade e metodos");

            // Listar Conteudos
            Console.WriteLine($@"Conteudos: {conteudos_Passados[0]}
{conteudos_Passados[1]}
{conteudos_Passados[2]}
{conteudos_Passados[3]}
{conteudos_Passados[4]}
{conteudos_Passados[5]}
{conteudos_Passados[6]}
{conteudos_Passados[7]}");
           





        }
    }
}
