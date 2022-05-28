using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entra21.ExerciciosOrientacaoObjeto.OrietacaoObjetos.Exercicio01
{

    public class Livro
    {
        public string Titulo;
        public string NomeAutor;
        public string CodigoIsbn;
        public string IdiomaOriginal;
        public DateTime DataLancamento;
        public int QuantidadePaginas;
        public int QuantidadePaginasLidas;
        public int QuantidadeReleitura;


        public string ApresentarTituloAutor()
        {
            return $"{Titulo} {NomeAutor}";
        }

        public int QuantidadePaginasParaLer()
        {
            return QuantidadePaginas;

        }

        public int QuantidadePaginasLidasNoTotal()
        {
            var paginasLidas = QuantidadePaginas * QuantidadeReleitura + QuantidadePaginasLidas;
           
            return paginasLidas;
        }
        public int ApresentarQuantidadeAnosAposPublicacao()
        {
            var dataAtual = DateTime.Now;
            var apresentarAno = dataAtual.Year - DataLancamento.Year;
            return apresentarAno;

        }

    }
}


