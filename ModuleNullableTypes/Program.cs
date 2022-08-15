using System;

namespace ModuleNullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2;

            if (date != null)
                date2 = date.GetValueOrDefault();
            else
                date2 = DateTime.Today;

            Console.WriteLine(date2);
        }
    }
}