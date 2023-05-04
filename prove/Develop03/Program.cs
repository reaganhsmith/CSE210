using System;

class Program
{
    static void Main(string[] args)
    {
        // this gets info from the refernce class (book, chapter, start verse, end verse(this can be left empty))
        Reference scriptureReference = new Reference("Proverbs", "3", "5", "6");
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
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine("Thanks for memorizing! Have a nice day:)");
    }
}