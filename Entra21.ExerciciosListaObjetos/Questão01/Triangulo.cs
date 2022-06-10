namespace Entra21.ExerciciosListaObjetos.Questão01
{
    internal class Triangulo
    {
        public int Lado01;
        public int Lado02;
        public int Lado03;
        public int Codigo;

        public bool ValidarTriangulo()
        {
            var trianguloValido = true;
            if (Lado01 + Lado02 < Lado03)
            {
                return trianguloValido;
            }
            return false;
        }
    }
}
