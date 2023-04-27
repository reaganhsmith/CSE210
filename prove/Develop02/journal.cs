using System;
using System.IO;

public class Journal{
public List<entry> entries = new List<entry>();

public void addEntry(){

    List<string> writingPrompt = new List<string>{
        "What is the happiest moment from today?",
        "How could today of been better?",
        "What was something that scared you today?",
        "How did you serve someone today?",
        "What was the best thing to happen today?", 
        "What or who made you feel special today?"};   

        Random random = new Random();
        string randomPrompt = writingPrompt[random.Next(writingPrompt.Count)];
        Console.WriteLine(randomPrompt);
        string response = Console.ReadLine();   

        DateTime Today = DateTime.Today;
        entry entry = new entry();
        entry._date = Today;

        entry._response = response;
        entry._prompt = randomPrompt;
        
    }


public void saveJournal(){
    Console.WriteLine("What do you want to name the file? (add .txt to the end)");
    string fileName = Console.ReadLine(); 

    using (StreamWriter outputFile = new StreamWriter(fileName))
{
    // You can add text to the file with the WriteLine method
    outputFile.WriteLine();
}
}

public void displayJournal(){

    // string[] lines = System.IO.File.ReadAllLines(fileName);

    // foreach (string line in lines)
    // {
    //     string[] parts = line.Split(",");

    //     string firstName = parts[0];
    //     string lastName = parts[1];
    // }

}

public void loadJournal(){

}
} 