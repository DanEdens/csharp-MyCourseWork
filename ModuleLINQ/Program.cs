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

            var cheapBoooks = books.Where(b => b.Price < 10).OrderBy(b => b.Title).Select(b => b.Title);
    
           foreach (var book in cheapBoooks)
                Console.WriteLine(book);
        }
    }
}