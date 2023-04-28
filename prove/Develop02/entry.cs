using System;

public class Entry{

    public string _response; 
    public string _prompt;
    public DateTime _date;

    public void Display()
    {

        Console.WriteLine($"Date {_date}: {_prompt}: {_response}");
    }
}