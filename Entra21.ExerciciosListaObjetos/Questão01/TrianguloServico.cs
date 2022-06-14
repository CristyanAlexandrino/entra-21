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

            var trianguloValido = triangulo.ValidarTriangulo();
            if (trianguloValido == true)
            {
            codigoAtual = codigoAtual + 1;
            triangulos.Add(triangulo);

            }
            return trianguloValido;


        }

        public bool Editar(int codigoAlterar, int lado1, int lado2, int lado3)
        {
            Triangulo trianguloParaAlterar = ObterPorCodigo(codigoAlterar);

            if (trianguloParaAlterar == null)
            {
                return false;
            }

            trianguloParaAlterar.Lado01 = lado1;
            trianguloParaAlterar.Lado02 = lado2;
            trianguloParaAlterar.Lado03 = lado3;
            return true;

        }

        public bool Apagar(int codigo)
        {
            Triangulo trianguloApagar = ObterPorCodigo(codigo);

            if (trianguloApagar == null)
            {
                return false;
            }

            triangulos.Remove(trianguloApagar);
            return true;
        }

        public List<Triangulo> ObterTodos()
        {
            return triangulos;
        }

        public Triangulo ObterPorCodigo(int codigo)
        {
            for (int i = 0; i < triangulos.Count; i++)
            {
                var trianguloAtual = triangulos[i];

                if (trianguloAtual.Codigo == codigo)
                {
                    return trianguloAtual;
                }
            }
            return null;
        }

    }
}
