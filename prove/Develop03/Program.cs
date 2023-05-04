using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string filePath = "/Users/reagan/Desktop/CSE210/prove/Develop03/scripture.csv";
        using (var reader = new StreamReader(filePath))
        {
            while (!reader.EndOfStream){
                string line = reader.ReadLine();
                string[] values = line.Split(",");

                string scriptureBook = values[0];
                string scriptureChapter = values[1];
                string scriptureStart = values[2];
                string scriptureEnd = values[3];
                string scriptureVerse= values[4];

        
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
        Console.Clear();
        Console.WriteLine(scripture.GetScripture());
        Console.WriteLine($"Thanks for memorizing {scriptureReference.GetReference()}! Have a nice day:)");
            }     
        }
    }
}