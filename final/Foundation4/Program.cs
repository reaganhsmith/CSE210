using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        List<Activity> activities = new List<Activity>();

        Running running = new Running(date, 60, 3.2);
        Cycling cycling = new Cycling(date, 75, 12.9);
        Swimming swimming = new Swimming(date, 45, 120);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);



        Console.WriteLine(" ");
        foreach(Activity activity in activities){
            Console.WriteLine(" ");
            Console.WriteLine(activity.getSummary());
            Console.WriteLine(" ");
        }


    }
}