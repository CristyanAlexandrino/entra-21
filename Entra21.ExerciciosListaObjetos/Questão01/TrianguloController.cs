using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosListaObjetos.Questão01
{
    internal class TrianguloController
    {
        TrianguloServico trianguloServico = new TrianguloServico();
        public void GerenciarMenu()
        {
            int codigo = 0;
            while (codigo != 6)
            {
                Console.Clear();
                codigo = ApresentarMenu();

                if (codigo == 1)
                {
                    ApresentarTodos();
                }
                else if (codigo == 2)
                {
                    ApresentarTriangulo();
                }
                else if (codigo == 3)
                {
                    Cadastrar();
                }
                else if (codigo == 4)
                {
                    Editar();
                }
                else if (codigo == 5)
                {
                    Apagar();

                }
                Console.WriteLine("\n\n Aperte alguma tecla para continuar");
            }


        }

        public void Apagar()
        {
            ApresentarTodos();

            Console.Write("Informe o código do triângulo que deseja apagar: ");
            var codigoParaApagar = Convert.ToInt32(Console.ReadLine());

            var trianguloApagado = trianguloServico.Apagar(codigoParaApagar);

            Console.WriteLine(trianguloApagado == true
                ? "Registro removido com sucesso!"
                : "Nenhum triângilo encotrado com o código informado");

        }

        public void Editar()
        {
            ApresentarTodos();

            Console.Write("Código do triângulo desejado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado 1: ");
            var valorLado1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado 2: ");
            var valorLado2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do lado 3: ");
            var valorLado3 = Convert.ToInt32(Console.ReadLine());

            var alterado = trianguloServico.Editar(codigo, valorLado1, valorLado2, valorLado3);

        }

        public void Cadastrar()
        {
            Console.WriteLine("Digite o valor do lado 1: ");
            var lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado 2: ");
            var lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o valor do lado 3: ");
            var lado3 = Convert.ToInt32(Console.ReadLine);

            trianguloServico.Adicionar(lado1, lado2, lado3);

        }

        public void ApresentarTodos()
        {
            var triangulo = trianguloServico.ObterTodos();

            if (triangulo.Count == 0)
            {
                Console.WriteLine("Nenhum Triângulo cadastrado");

                return;
            }

            for (int i = 0; i < triangulo.Count; i++)
            {

            }
        }

        public void ApresentarTriangulo()
        {
            ApresentarTodos();

            Console.Write("Digite o código do triângulo a ser detalhado: ");
            var codigo = Convert.ToInt32(Console.ReadLine());

            var triangulo = trianguloServico.ObterPorCodigo(codigo);

            if (triangulo == null)
            {
                Console.WriteLine("Triângulo não cadastrado!! ");

                return;
            }

            Console.WriteLine(@$" Código: {triangulo.Codigo}
Lado 1: {triangulo.Lado01}
Lado 2: {triangulo.Lado02}
Lado 3: {triangulo.Lado03}");
        }

        public int ApresentarMenu()
        {
            Console.WriteLine(@" MENU:

1 - Listar Todos
2 - Apresentar triângulo desejado
3 - Cadastrar 
4 - Editar
5 - Apagar
6 - Sair");

            int codigo = SolicitarCodigo();
            return codigo;
        }

        public int SolicitarCodigo()
        {
            var codigo = 0;

            while (codigo < 1 || codigo > 6)
            {
                try
                {
                    Console.WriteLine("Digite o código: ");
                    codigo = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {

                    Console.WriteLine("Digite um número válido!");
                }
            }

            return codigo;
        }
    }
}
