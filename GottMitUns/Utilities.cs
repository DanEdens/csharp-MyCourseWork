namespace Generics
{
    // where T : ICompareable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new()
    public class Utilities<T> where T : IComparable 
    {
        public int Max(int a, int b) => a > b ? a : b;

        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
} 