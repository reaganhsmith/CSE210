using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to your journal");

        int userInput = 0;


    List<string> menu = new List<string>{
        "Please select what you would like to do.",
        "1. Write",
        "2. Display",
        "3. Save",
        "4. Load",
        "5. Quit",
        "What do you want to do: "
    };


    while (userInput != 5){

            foreach(string menuItem in menu){
                Console.WriteLine(menuItem);
            }
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