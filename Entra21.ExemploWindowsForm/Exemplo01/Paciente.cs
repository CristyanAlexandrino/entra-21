namespace Entra21.ExemploWindowsForm.Exemplo01
{
    public class Paciente
    {
        public int Codigo;
        public string Nome;
        public double Altura;
        public double Peso;

        public double ObterImc()
        {
            return Peso / Math.Pow(Altura, 2);
        }

    }
}
