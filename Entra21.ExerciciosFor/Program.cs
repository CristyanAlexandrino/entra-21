using Entra21.ExerciciosFor;

Console.WriteLine(@"-----------------------------------------
         Menu Exercicios
 1 - Exercicio01
 5 - Exercicio05");

Console.WriteLine("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exercicio01 exercicio1 = new Exercicio01();
    exercicio1.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio5 = new Exercicio05();
    exercicio5.Executar();
}
