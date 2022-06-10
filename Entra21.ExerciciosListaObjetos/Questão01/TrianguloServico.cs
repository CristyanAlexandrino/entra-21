namespace Entra21.ExerciciosListaObjetos.Questão01
{
    internal class TrianguloServico
    {
        private List<Triangulo> triangulos = new List<Triangulo>();
        private int codigoAtual = 0;

        public bool Adicionar(int lado01, int lado02, int lado03)
        {
            Triangulo triangulo = new Triangulo();
            triangulo.Lado01 = lado01;
            triangulo.Lado02 = lado02;
            triangulo.Lado03 = lado03;
            triangulo.Codigo = codigoAtual;

            codigoAtual = codigoAtual++;

            var trianguloValido = triangulo.ValidarTriangulo();
            return trianguloValido;
            triangulos.Add(triangulo);


        }

        public void Editar()
        {

        }

       // public bool Apagar(int codigo)
        //{

       // }

        public void ObterTodos()
        {

        }

        public void ObterPorCodigo()
        {

        }

    }
}
