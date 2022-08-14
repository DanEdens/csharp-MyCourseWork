using Linq;
using System.Collections.Generic;
using System.Linq;

namespace ModuleLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();

            var book = books.Single(b => b.Title == "ASP.Net MVC");

            Console.WriteLine(book.Title);
        }
    }
}