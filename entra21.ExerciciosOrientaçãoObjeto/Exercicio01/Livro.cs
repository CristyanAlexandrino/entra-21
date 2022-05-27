using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.OrietacaoObjetos.Exercicio01
{
   
    public class Livro
    {
        public string Titulo = "Duna";
        public string NomeAutor = "Frank Herbert";
        public int CodigoIsbn;
        public string IdiomaOriginal = "Inglês";
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleitura;

        Livro duna = new Livro();
        public string ApresentarTituloAutor()
        {



            return "Nome Livro: " + duna.Titulo;

        }

        public int QuantidadePaginasParaLer()
        {
            var totalPaginas = duna.QuantidadePaginas;

            return totalPaginas;
        }

        public int QuantidadePaginasLidasNoTotal()
        {
            var paginasLidas = duna.QuantidadePaginas - duna.QuantidadePaginasLidas;

            return paginasLidas;
        }

    }
}


