using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to your journal");


        int userInput = 0;

        List<string> writingPrompt = new List<string>{
        "What is the happiest moment from today?",
        "How could today of been better?",
        "What was something that scared you today?",
        "How did you serve someone today?",
        "What was the best thing to happen today?", 
        "What or who made you feel special today?"};

                List<string> journalEntries = new List<string>();


    while (userInput != 5){
            Console.WriteLine(" ");
            Console.WriteLine("Please select what you would like to do.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What do you want to do: ");
            string input = Console.ReadLine();
            userInput = int.Parse(input);

            Journal journal = new Journal();
        if (userInput == 1){

            journal.addEntry();

            }
        
        if (userInput == 2){

            journal.displayJournal();

        }
        if (userInput == 3){

            journal.saveJournal();

        }
        if (userInput == 4){
            
            journal.loadJournal();

            }

        }
    }
}