
namespace AdaTech.DelegateLINQ.FiltrarLivros
{
    internal class LivroFilter
    {
        internal static bool FiltroPorAnoPublicacao(Livro livro, int ano)
        {
            return livro.AnoPublicacao >= ano;
        }

        internal static bool FiltroPorPrecoMaximo(Livro livro, decimal precoMaximo)
        {
            return livro.Preco <= precoMaximo;
        }

        internal static bool FiltroPorTitulo(Livro livro, string palavraTitulo)
        {
            return livro.Titulo.Contains(palavraTitulo, StringComparison.OrdinalIgnoreCase);
        }
    }
}
