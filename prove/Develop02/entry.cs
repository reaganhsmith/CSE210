using System;

public class entry{

    public string _response; 
    public string _prompt;
    public DateTime _date;

    public void displayEntry(){
        Console.WriteLine($"Date {_date}: {_prompt}: {_response}");
    }
}