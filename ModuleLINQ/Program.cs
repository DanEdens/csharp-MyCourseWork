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

            var maxPrice = books.Max(b => b.Price);    
            var minPrice = books.Min(b => b.Price);

            Console.WriteLine(maxPrice);
            Console.WriteLine(minPrice);

        }
    }
}