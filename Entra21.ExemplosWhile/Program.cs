using Entra21.ExemplosWhile;

Console.WriteLine(@"----------MENU-----------
1 - Exemplo 01
2 - Exemplo 02
3 - Exemplo 03
4 - Exemplo 04
5 - Exemplo 05
6 - Exemplo 06");
Console.Write("Digite a opção desejada:");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exemplo01 exemplo01 = new Exemplo01();
    exemplo01.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 nossoExemplo = new Exemplo02();
    nossoExemplo.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 delesExemplo = new Exemplo03();
    delesExemplo.Executar();
}
else if (opcaoDesejada == 4)
{
    Exemplo04 exemplo4 = new Exemplo04();
    exemplo4.Executar();
}
else if (opcaoDesejada == 5)
{
    Exemplo05 exemplo5 = new Exemplo05();
    exemplo5.Executar();
}
else if (opcaoDesejada == 6)
{
    Exemplo06 exemplo6 = new Exemplo06();
    exemplo6.Executar();
}