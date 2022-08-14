using System;

namespace ModuleExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string post = "This is supposed to be a very long blog post...";
            var ShortendPost = post.Shorten(5)

            Console.WriteLine(ShortendPost);
        }
    }
}