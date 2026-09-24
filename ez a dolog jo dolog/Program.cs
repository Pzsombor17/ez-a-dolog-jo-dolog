namespace ez_a_dolog_jo_dolog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Book book = new Book("Hobbit", "gandalf jeno", 310) {Price = 65000 };
            book.UpdatePrice(10);
            Console.WriteLine(book);
            Book dune = book with { Author = "kjhb", Title = "dfs", Pages = 444 };
            Console.WriteLine(dune);
        }
    }
}
