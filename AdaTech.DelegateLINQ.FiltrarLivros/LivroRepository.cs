
namespace AdaTech.DelegateLINQ.FiltrarLivros
{
    internal class LivroRepository
    {
        private List<Livro> livros = new List<Livro>();

        internal LivroRepository(List<Livro> livros)
        {
            this.livros = livros;
        }

        internal List<Livro> Filtrar(Filter<Livro> filtro)
        {
            return livros.Where(x => filtro(x)).ToList();
        }
    }
}
