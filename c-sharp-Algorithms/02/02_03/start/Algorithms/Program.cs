using System;

namespace Algorithms {
    class Program {
        static int[] FindEvenNums(int[] arr1, int[] arr2) {
            ArrayList Result = new ArrayList();
            

            foreach(int num in arr1) {
                if (num % 2 == 0) {
                result.Add(num);
                }
        

            foreach(int num in arr2) {
                 if (num % 2 == 0) {
                result.Add(num);
                }

        }

        static void Main(string[] args) {
            int[] arr1 = {-8, 2, 3, -9, 11, -20};
            int[] arr2 = {0, -2, -9, -39, 39, 10, 7};

            int[] evenArr = FindEvenNums(arr1, arr2);
        }
    }
}
