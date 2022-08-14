using System;

namespace ModuleExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post...";
            var ShortendPost = post.Shorten(5);

            IEnumerable<int> numbers = new List<int>() { 1,5,3,10,2,18};
            var max = numbers.Max();

            Console.WriteLine(ShortendPost);
            Console.WriteLine(max);
        }
    }
}