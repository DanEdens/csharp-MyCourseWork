using System;

namespace ModuleNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2014, 1, 1);
            DateTime date2 = date.GetValueOrDefault();
            DateTime? date3 = date2; 

            Console.WriteLine( date2);
        }
    }
}