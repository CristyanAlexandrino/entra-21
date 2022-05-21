using Entra21.ExemplosVetor;
Console.WriteLine($@"Exmplos Vetor
 1 - Exemplo01
 2 - Exemplo02");
Console.WriteLine("Digite a opção desejada: ");
var opcaoDesejada = Convert.ToInt32(Console.ReadLine());

if (opcaoDesejada == 1)
{
    Exemplo01 exemplo1 = new Exemplo01();
    exemplo1.Executar();
}
else if (opcaoDesejada == 2)
{
    Exemplo02 exemplo2 = new Exemplo02();
    exemplo2.Executar();

}










