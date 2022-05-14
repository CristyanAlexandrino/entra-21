using Entra21.ExemplosFor;

Console.WriteLine(@"              MENU          
1 - Exemplo01
2 - Exemplo02
3 - Exemplo03
4 = Exemplo04");
Console.Write("Escolha a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    Exemplo01 exemplo1 = new Exemplo01();
    exemplo1.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo01 exemplo2 = new Exemplo01();
    exemplo2.Executar();
}
else if (opcaoDesejada == 3)
{
    Exemplo03 exemplo3 = new Exemplo03();
    exemplo3.Executar();
}