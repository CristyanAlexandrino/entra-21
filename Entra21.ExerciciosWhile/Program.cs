using Entra21.ExerciciosWhile;


Console.WriteLine(@"______________Menu____________
1 - Exercicio 01
2 - Exercicio 02
3 - Exercicio 03
4 - Exercicio 04
5 - Exercicio 05
6 - Exercicio 06
11 - Exercicio 11
12 - Exercicio 12");
Console.Write("Digite a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

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
else if (opcaoDesejada == 5)
{
    Exercicio05 exercicio5 = new Exercicio05();
    exercicio5.Executar();

}
else if (opcaoDesejada == 6)
{
    Exercicio06 exercicio6 = new Exercicio06();
    exercicio6.Executar();
}
else if (opcaoDesejada == 11)
{
    Exercicio011 exercicio11 = new Exercicio011();
    exercicio11.Executar();
}
else if (opcaoDesejada == 12)
{
    Exercicio012 exercicio12 = new Exercicio012();
    exercicio12.Executar();
}

