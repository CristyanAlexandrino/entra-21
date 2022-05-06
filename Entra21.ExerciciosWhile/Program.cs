using Entra21.ExerciciosWhile;


Console.WriteLine("@______________Menu_____________" +
    "1 - Exercicio 01" +
    "2 - Exercicio 02" +
    "3 - Exercicio 03" +
    "4 - Exercicio 04" +
    "5 - Exercicio 05 ");
int opcaoDesejada = Convert.ToInt32(Console.ReadLine());
if(opcaoDesejada == 1)
{
    Exercicio1 exercicio1 = new Exercicio1();
    exercicio1.Executar();
}
else if (opcaoDesejada == 2)
{
    Exercicio2 exercicio2 = new Exercicio2();
    exercicio2.Executar();

}
else if (opcaoDesejada == 3 )
{
    Exercicio3 exercicio3 = new Exercicio3();
    exercicio3.Executar();
}