namespace Generics
{
    public class Utilities
    {
        public int Max(int a, int b)
        { 
            return a > b ? a : b 
        }

        public T Max<T>(T a, T b) where T : IComparable
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
} 