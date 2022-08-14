namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
        }
    }
}