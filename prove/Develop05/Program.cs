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

        Console.WriteLine(" ");
        Console.WriteLine($"total points: {goal._totalPoints}");
        Console.WriteLine(" ");

        foreach(string menuItem in menu){
            Console.WriteLine(menuItem);
        }

        string input = Console.ReadLine();
        userInput = int.Parse(input);

        if (userInput == 1){
            Console.WriteLine(" ");
            goal.create();
            Console.WriteLine(" ");
        }

        if (userInput == 2){
            Console.WriteLine(" ");
            goal.DisplayGoals();   
            Console.WriteLine(" ");

        }

        if (userInput == 3){
            Console.WriteLine(" ");
            goal.Save();
            Console.WriteLine(" ");
        }

        if (userInput == 4){
            Console.WriteLine(" ");
            goal.Load();
            Console.WriteLine(" ");

        }

        if (userInput == 5){
            Console.WriteLine(" ");
            goal.DisplayGoals();
            Console.Write("Which goal would you like to report on? ");
            int userChoice = int.Parse(Console.ReadLine());
            goal._totalPoints += goal.GoalList[userChoice - 1].CompleteGoal();
            Console.WriteLine($"You have {goal._totalPoints} total points");
            Console.WriteLine(" ");
        }


    }
}
}