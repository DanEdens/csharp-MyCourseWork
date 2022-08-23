namespace LinkedIn.Essentials;

//classes - reference types
public class CPoint
{
    public int X { get; set; }
    public int Y { get; set; }
}  

//structs - value types
public struct SPoint
{
    public int X { get; set; }
    public int Y { get; set; }

    //public static bool operator == (SPoint a, SPoint b) => a.X == b.X   &&  a.Y == b.Y;
    //public static bool operator != (SPoint a, SPoint b) => a.X != b.X   ||  a.Y != b.Y;
}

//records (C# 9)
public record RPoint(int X, int Y);
