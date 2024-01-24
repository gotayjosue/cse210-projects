using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(1);
        Fraction fraction3 = new Fraction(1, 3);

        Console.WriteLine(fraction3.GetBottom());
        Console.WriteLine(fraction3.GetTop());
        fraction3.GetFractionString();

        Console.WriteLine(fraction3.GetDecimalValue());
    }   
}