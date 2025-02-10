using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 5.0);

        Console.WriteLine($"Square Color: {square.GetColor()}");
        Console.WriteLine($"Square Area: {square.GetArea()}");
    }
}
