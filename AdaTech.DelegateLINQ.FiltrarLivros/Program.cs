
namespace AdaTech.DelegateLINQ.FiltrarLivros
{
    internal class Program
    {
        internal static void Main()
        {
            List<Livro> livros = new List<Livro>
        {
            new Livro { Titulo = "A Arte da Guerra", Autor = "Sun Tzu", AnoPublicacao = 2000, Preco = 19.99m },
            new Livro { Titulo = "O Príncipe", Autor = "Maquiavel", AnoPublicacao = 2010, Preco = 15.99m },
            new Livro { Titulo = "1984", Autor = "George Orwell", AnoPublicacao = 2005, Preco = 25.99m }
        };

            LivroRepository repositorio = new LivroRepository(livros);

            var filtroAno = new Filter<Livro>(x => LivroFilter.FiltroPorAnoPublicacao(x, 2000));
            var livrosPorAno = repositorio.Filtrar(filtroAno);

            var filtroPreco = new Filter<Livro>(x => LivroFilter.FiltroPorPrecoMaximo(x, 20.00m));
            var livrosPorPreco = repositorio.Filtrar(filtroPreco);

            var filtroTitulo = new Filter<Livro>(x => LivroFilter.FiltroPorTitulo(x, "a"));
            var livrosPorTitulo = repositorio.Filtrar(filtroTitulo);

            Console.WriteLine("Livros a partir do ano 2000:");
            livrosPorAno.ForEach(l => Console.WriteLine(l.Titulo));

            Console.WriteLine("\nLivros com preço até 20.00:");
            livrosPorPreco.ForEach(l => Console.WriteLine(l.Titulo));

            Console.WriteLine("\nLivros que contêm 'a' no título:");
            livrosPorTitulo.ForEach(l => Console.WriteLine(l.Titulo));
        }
    }

}
