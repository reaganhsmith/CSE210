using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = DateTime.Now;

        List<Activity> activities = new List<Activity>();

        List<string> menuOptions = new List<string>{
            "Which would you like to do? ",
            "1. Add Run",
            "2. Add Cycle",
            "3. Add Swim",
            "4. Show workouts",
            "5. quit",
            "please type the number of the one you participated in."
        };

        int userInput = 0;

        Console.WriteLine(" ");
        foreach(string option in menuOptions){
            Console.WriteLine(option);
        }

        while(userInput != 5){

            Console.WriteLine(" ");
        foreach(string option in menuOptions){
            Console.WriteLine(option);
        }
            userInput = int.Parse(Console.ReadLine());

            if(userInput == 1){

                Console.WriteLine("How many minutes did you run for?");
                int time = int.Parse(Console.ReadLine());

                Console.WriteLine("How many miles did you go?");
                double distance = double.Parse(Console.ReadLine());

                Running running = new Running(date, time, distance);
                activities.Add(running);
            }
            if(userInput == 2){
                Console.WriteLine("How many minutes did you cycle for?");
                int time = int.Parse(Console.ReadLine());

                Console.WriteLine("How many miles did you go?");
                double distance = double.Parse(Console.ReadLine());

                Cycling cycling = new Cycling(date, time, distance);
                activities.Add(cycling);
            }

            if(userInput == 3){
                Console.WriteLine("How many minutes did you swim for?");
                int time = int.Parse(Console.ReadLine());

                Console.WriteLine("How many laps did you do?");
                int laps = int.Parse(Console.ReadLine());

                Swimming swimming = new Swimming(date, time, laps);
                activities.Add(swimming);
            }

            if(userInput == 4){
                Console.WriteLine(" ");
                foreach(Activity activity in activities){
                Console.WriteLine(" ");
                Console.WriteLine(activity.getSummary());
                Console.WriteLine(" ");
            }

            }


       }

       Console.WriteLine("Thanks have a good day:)");

       
        
    }
}