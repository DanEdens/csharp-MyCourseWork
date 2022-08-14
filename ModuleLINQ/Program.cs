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

            var count = books.Max(b => b.Price);    
            
            Console.WriteLine(count);
            
        }
    }
}