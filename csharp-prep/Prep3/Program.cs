using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");

        // WHILE AND FOR LOOPS 
        Random randomGenerator = new Random();

        int magic = randomGenerator.Next(1, 100);
        int userGuess = -1;


        while (userGuess != magic)
        {

        

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        userGuess = int.Parse(guess);

        if (magic > userGuess){
            Console.WriteLine("Higher");
        }
        else if (magic == userGuess) {
            Console.WriteLine("You guessed it!");
        }
        else{
            Console.WriteLine("Lower");
        }

        }
    }
}