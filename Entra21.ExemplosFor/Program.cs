using Entra21.ExemplosFor;

Console.WriteLine(@"              MENU          
 1 - Exemplo01
2 - Exemplo02
3 -Exemplo03");
Console.Write("Escolha a opção desejada: ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
Console.Clear();

if (opcaoDesejada == 1)
{
    Exemplo01 exercicio1 = new Exemplo01();
    exercicio1.Executar();
}