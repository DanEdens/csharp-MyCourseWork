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

            var book = books.lastOrDefault(b => b.Title == "C# Advanced Topics");

            Console.WriteLine(book.Title + " " + book.Price);
        }
    }
}