using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("");

        Assignment a1 = new Assignment("Samuel Bennett", "multiplication");
        Console.WriteLine(a1.GetSummary());

        Console.WriteLine("");

        MathAssignment a2 =new MathAssignment("Reagan Smith", "Fractions", "7.0", "8-12");
        Console.WriteLine(a2.GetHomeworkList());

        Console.WriteLine(""); 

        WritingAssignment a3 = new WritingAssignment("Braden Houser", "WWII", "The Second World War");
        Console.WriteLine(a3.GetWitingInformation());
        
        Console.WriteLine("");
    }
}