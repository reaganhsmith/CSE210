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

     List<string> save = new List<string>{
                " ",
        "Do you want to write a new file or add to an existing one?",
        "1. New file",
        "2. Existing file"
        };

    Journal journal = new Journal();
    while (userInput != 5){

            foreach(string menuItem in menu){
                Console.WriteLine(menuItem);
            }
            string input = Console.ReadLine();
            userInput = int.Parse(input);

            
        if (userInput == 1){


        journal.addEntry();
            }
        
        if (userInput == 2){

            journal.displayJournal();

        }
        if (userInput == 3){
           

        foreach (string item in save){
            Console.WriteLine(item);
        }

        string choice = Console.ReadLine();
        int userChoice = int.Parse(choice);

        if(userChoice == 1){
            journal.saveJournal();}
            else{
                journal.saveExistingFile();
            }

        }
        if (userInput == 4){
            
            journal.loadJournal();

            }

        }
    }
}