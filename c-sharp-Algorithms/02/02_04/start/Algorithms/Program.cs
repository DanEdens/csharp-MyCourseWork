using System;

namespace Algorithms {
    class Program {
        static int[] Reverse(int[] input) {
            return input;
        }

        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(Reverse(arr), Console.WriteLine);
        }
    }
}