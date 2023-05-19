using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" ");
        Console.WriteLine("Welcome to your journal");

        int userInput = 0;


    List<string> menu = new List<string>{
        "Menu Options",
            "1. Create New Goal",
            "2. List Goals",
            "3. Save Goals",
            "4. Load Goals",
            "5. Record Event",
            "6. Quit",
            "What do you want to do: "
    };

     createGoal goal = new createGoal();

    while (userInput != 6){
           Console.WriteLine($"{goal._totalPoints}");
            foreach(string menuItem in menu){
                Console.WriteLine(menuItem);
            }
            string input = Console.ReadLine();
            userInput = int.Parse(input);

        if (userInput == 1){
            
            goal.create();

        }

        if (userInput == 2){
            goal.DisplayGoals();   
        }

        if (userInput == 3){
            goal.Save();
        }

        if (userInput == 4){
            goal.Load();

        }

        if (userInput == 5){
            goal.DisplayGoals();
            Console.Write("Which goal would you like to report on? ");
            int userChoice = int.Parse(Console.ReadLine());
            goal._totalPoints += goal.GoalList[userChoice - 1].CompleteGoal();
            Console.WriteLine($"You have {goal._totalPoints} total points");
        }


    }
}
}