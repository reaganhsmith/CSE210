using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string playAgain = "yes";
        // string userInput = " ";
        while(playAgain.ToLower() == "yes"){
            // this gets info from the refernce class (book, chapter, start verse, end verse(this can be left empty))
            Reference scriptureReference = new Reference("Proverbs", "3", "4", "5");

            Scripture scripture = new Scripture(scriptureReference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
            
            string userInput = " ";

            
            while (userInput != "QUIT" && scripture.HasWordsLeft() == true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetScripture());
                Console.WriteLine("Please press enter to continue or type QUIT to finish: ");
                userInput = Console.ReadLine();
                scripture.RemoveWords();
            }
            Console.Clear();
            Console.WriteLine(scripture.GetScripture());
            Console.WriteLine($"Thanks for memorizing {scriptureReference.GetReference()}!");
            Console.WriteLine("Would you like to memorize it again (yes or no)?");
            playAgain = Console.ReadLine();
        }
        Console.WriteLine("Thanks, have a good day!");
    }
}