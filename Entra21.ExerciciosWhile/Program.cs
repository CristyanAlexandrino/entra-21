using Entra21.ExerciciosWhile;


Console.WriteLine(@"______________Menu____________
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06");
Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    Exercicio1 exercicio1 = new Exercicio1();
    exercicio1.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio2 exercicio2 = new Exercicio2();
    exercicio2.Executar();

}
else if (opcaoDesejada == 3)
{
    Exercicio3 exercicio3 = new Exercicio3();
    exercicio3.Executar();
}
else if (opcaoDesejada == 4)
{
    Exercicio4 exercicio4 = new Exercicio4();
    exercicio4.Executar();
}
else if (opcaoDesejada == 5)
{
    Exercicio5 exercicio5 = new Exercicio5();
    exercicio5.Executar();

}
else if (opcaoDesejada == 6)
{
    Exercicio6 exercicio6 = new Exercicio6();
    exercicio6.Executar();
}

