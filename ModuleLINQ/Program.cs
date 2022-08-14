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

            var pagedBooks = books.Skip(2).Take(3);

            foreach (var pagedBook in pagedBooks)
            { 
                Console.WriteLine(pagedBook.Title);
            }
        }
    }
}