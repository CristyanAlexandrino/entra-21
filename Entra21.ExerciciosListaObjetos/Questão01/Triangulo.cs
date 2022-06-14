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
            var segmento1 = Lado01 + Lado02;
            var segmento2 = Lado01 + Lado03;
            var segmento3 = Lado03 + Lado02;
            if (segmento1 < 3 && segmento2 < 2 && segmento3 < 1 )
            {
                return true;
            }
            return false;
        }
    }
}
