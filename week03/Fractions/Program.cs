using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(5);
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f1.GetFractionString()); 
        Console.WriteLine(f1.GetDecimalValue());   

        Console.WriteLine(f2.GetFractionString()); 
        Console.WriteLine(f2.GetDecimalValue());   

        Console.WriteLine(f3.GetFractionString()); 
        Console.WriteLine(f3.GetDecimalValue());   

        // Test setters and getters
        f3.SetNumerator(1);
        f3.SetDenominator(3);

        Console.WriteLine(f3.GetFractionString()); 
        Console.WriteLine(f3.GetDecimalValue());   
    }
}

