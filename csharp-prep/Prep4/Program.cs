using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");

        //Creating lists 

        List<int> numbers = numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, hit 0 when done");
        int userInput = 1;

        while (userInput != 0){
            Console.Write("Enter Number: ");
            string input = Console.ReadLine();
            userInput = int.Parse(input);
            numbers.Add(userInput);
        }

        int max = numbers[0];
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
             if (number > max)
            {
                max = number;
            }
            
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The max is: {max}");

        


    }
}