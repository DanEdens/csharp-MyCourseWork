using System;

namespace LamedaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBooks();
            
            var cheapBooks = books.FindAll(IsCheaperThan10Dollars);

            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }

        }

        static bool IsCheaperThan10Dollars(Book book)
        {
            return book.Price < 10;
        }
   }
}