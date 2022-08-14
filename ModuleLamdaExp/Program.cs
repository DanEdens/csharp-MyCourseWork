namespace LamedaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression 
            // args goes to expression

            //number => number * number;
            Func<int, int> square = number => number*number;

            Console.WriteLine(square(5));
        }
   }
}