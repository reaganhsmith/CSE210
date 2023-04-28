using System;
using System.IO;

public class Journal{
public List<Entry> _entries = new List<Entry>();

public void addEntry(){

    List<string> writingPrompt = new List<string>{
        "What is the happiest moment from today?",
        "How could today of been better?",
        "What was something that scared you today?",
        "How did you serve someone today?",
        "How did I see Gods hand today?", 
        "What or who made you feel special today?"};   

        Random random = new Random();
        string randomPrompt = writingPrompt[random.Next(writingPrompt.Count)];
        Console.WriteLine(randomPrompt);
        string response = Console.ReadLine();   

        DateTime Today = DateTime.Today;
        Entry entry = new Entry();
        entry._date = Today;

        entry._response = response;
        entry._prompt = randomPrompt;

        _entries.Add(entry);
        
    }


public void saveJournal(){
    Console.WriteLine("What do you want to name the file? (add .txt to the end) ");
    string fileName = Console.ReadLine(); 

    
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach (Entry entry in _entries){
            outputFile.WriteLine(entry._date);
            outputFile.WriteLine(entry._prompt);
            outputFile.WriteLine(entry._response);
            outputFile.WriteLine(" ");
            }
              }
}

public void saveExistingFile(){
    Console.WriteLine("What is the name of the file you want to save it to? (add .txt to the end) ");
    string fileName = Console.ReadLine(); 
    using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            foreach (Entry entry in _entries){
             writer.WriteLine(entry._date);
             writer.WriteLine(entry._prompt);
             writer.WriteLine(entry._response);
             writer.WriteLine(" ");
            }
        }
}


public void displayJournal(){
    Console.WriteLine("Previous entries");
    foreach (Entry entry in _entries){
        Console.WriteLine("");
        entry.Display();
        Console.WriteLine("");
    }

}

public void loadJournal(){
    Console.WriteLine(" ");
    Console.WriteLine("Here is a list of the .txt files available to open");
     string[] files = Directory.GetFiles(".", "*.txt");

        foreach (string file in files)
        {
            Console.WriteLine(file);
        }
    Console.WriteLine("What is the filename? (add .txt to the end) ");
    string fileName = Console.ReadLine(); 

    string[] lines = System.IO.File.ReadAllLines(fileName);
        using (StreamReader reader = new StreamReader(fileName))
        {
            // Read the entire file and store it in a string variable
            string fileContents = reader.ReadToEnd();

            // Print the file contents to the console
            Console.WriteLine(fileContents);
        }

}
} 