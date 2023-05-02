using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());
        Console.WriteLine(" ");

        Fraction f2 = new Fraction(5);
        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());
        Console.WriteLine(" ");

        Fraction f3 = new Fraction(3,6);
        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());
        Console.WriteLine(" ");

        Fraction f4 = new Fraction(6, 3);
        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());
        Console.WriteLine(" ");

        Console.WriteLine("What do you want the TOP number to be? ");
        string top = Console.ReadLine();
        int topNumber = int.Parse(top);
        Console.WriteLine("What do you want the BOTTOM number to be? ");
        string bottom = Console.ReadLine();
        int bottomNumber = int.Parse(bottom);
        Console.WriteLine(" ");

        Fraction f5 = new Fraction(topNumber, bottomNumber);
        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
        Console.WriteLine(" ");

    }
}