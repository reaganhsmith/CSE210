using System;

class Program
{
    static void Main(string[] args)
    {

        int userInput = 0;

        List<string> menu = new List<string>{
            "Menu Options",
            "1. Start Breathing Activity",
            "2. Start Reflection Activity",
            "3. Start Listing Activity",
            "4. Quit",
            "What do you want to do: "
        };

        // Breathing breathing = new Breathing();
        
        // Listing listing = new Listing();


        while(userInput != 4){
            foreach(string menuItem in menu){
                Console.WriteLine(menuItem);
            }
            string input = Console.ReadLine();
            userInput = int.Parse(input);

            if(userInput == 1)
            {


            }

             if(userInput == 2)
             {
                Console.Clear();
                string intro1 = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
                string end1 = "Thank you for joining us today:)";
                int timer = 3;
                Reflection reflection = new Reflection(intro1, end1, timer);
                reflection.runActivity();

            }


             if(userInput == 3)
             {
                
            }
        }
    }
}