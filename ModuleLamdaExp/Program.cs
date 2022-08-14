namespace LamedaExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            // args => expression 
            // args goes to expression

            //number => number * number;
            // () => ...
            // x = > ...
            // (x,y,z) => ...
            const int factor = 5;
            Func<int, int> multipler = n => n*factor;

            var result = multipler(10);
            Console.WriteLine( result);
        }
   }
}