
using entra21.ExerciciosOrientacaoObjeto.Exercicio01;
using Entra21.ExerciciosOrientacaoObjeto;

Console.WriteLine("          Menu");
Console.WriteLine(@"1 - Exercicio01 - Exemplo Livro.
2 - Exercicio02
3 - Exercicio03");
Console.Write("Digite a opção desejada: ");
var opcao = Convert.ToInt32(Console.ReadLine());

if (opcao == 1)
{
    ExemploLivro livro = new ExemploLivro();
    livro.Executar();
}
