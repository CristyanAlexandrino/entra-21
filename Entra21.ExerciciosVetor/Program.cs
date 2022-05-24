using Entra21.ExerciciosVetor;

Console.WriteLine(@" Exercicios Vetores
 1 -  Exercicio01 - Digitar 16 numeros e apresentar a soma.
 2 -  Exercicio02 - Solicitar 10 nomes e apresentar.
 3 -  Exercicio03 - Solicitar o nome de 7 produtos e seus valores e aprensetar. ");
Console.WriteLine("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio1 = new Exercicio01();
    exercicio1.Executar();

}
else if (opcaoDesejada == 2)
{
    Exercicio02 exercicio2 = new Exercicio02();
    exercicio2.Executar();
}
else if (opcaoDesejada == 3)
{
    Exercicio03 exercicio3 = new Exercicio03();
    exercicio3.Executar();

}
else if (opcaoDesejada == 4)
{
    Exercicio04 exercicio4 = new Exercicio04();
    exercicio4.Executar();

}