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
        "How did I see Gods hand today?", 
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
    Console.WriteLine("What do you want to name the file? (add .txt to the end) ");
    string fileName = Console.ReadLine(); 

    
        using (StreamWriter outputFile = new StreamWriter(fileName)){
            foreach(entry entry in entries){
                entry.display();
            }
              }
}


public void displayJournal(){

    foreach (entry entry in entries){
        entry.display();
    }

}

public void loadJournal(){
    Console.WriteLine("What is the filename? (add .txt to the end) ");
    string fileName = Console.ReadLine(); 

    string lines = System.IO.File.ReadAllText(fileName);
    Console.WriteLine(lines);

}
} 