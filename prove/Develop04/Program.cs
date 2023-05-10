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

        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();


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


            }


             if(userInput == 3)
             {
                
            }
        }
    }
}