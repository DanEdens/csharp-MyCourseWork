using System;

namespace Algorithms {
    class Program {
        static int[] Reverse(int[] input) {
            int[] reversed = new(input.Length);

            for (int i = 0; reversed.Length; i++) {
                reversed[i] = input[input.Length - i -1];
            }
            return reversed
        }

        static void ReverseInPlace(int[] input) {
            for (int i = 0; i < input.Length / 2; i++) {
                int temp = input[i];
                input[i] = input[input.Length - i -1];
                input[input.Length - 1 -i] = temp;
            }
        }
        static void Main(string[] args) {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            Array.ForEach(Reverse(arr), Console.WriteLine);
            ReverseInPlace(arr);
            Array.ForEach(arr, Console.WriteLine);

        }
    }
}
