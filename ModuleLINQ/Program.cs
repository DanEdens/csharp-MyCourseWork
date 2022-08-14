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

            var totalPrice = books.Sum(b => b.Price);    
            

            Console.WriteLine(totalPrice);
            

        }
    }
}