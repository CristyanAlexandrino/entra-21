
using entra21.ListaTiposPrimitivos;

Console.WriteLine(@"      Menu 
   
1 - Execicio01 - Os melhores filmes de todos os tempos
2 - Exercicio02 - Conteudos Passados");



Console.WriteLine("Digite a ooção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio1 = new Exercicio01();
    exercicio1.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio02 = new Exercicio02();
    exercicio02.Executar();
}