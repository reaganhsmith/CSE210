public class createGoal{
    public List<Goals> GoalList = new List<Goals>();

    public string _input;
    public int _totalPoints = 0;

    public void create(){
        List<string> menu = new List<string>{
            "-----------------------------------------------",
            "Goal options:",
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal",
            "-----------------------------------------------",
            "What type of goal would you like to create? "
    };

        foreach(string item in menu){
                Console.WriteLine(item);
        }

        int userInput = int.Parse(Console.ReadLine());
       

        string goalName;
        string desc; 
        int points;

        if (userInput == 1){
            
            Console.WriteLine("What is the name of the Goal: ");
            goalName = Console.ReadLine();

            Console.WriteLine("Please give a brief description of your goal: ");
            desc = Console.ReadLine();

            Console.WriteLine("How many points is the goal worth? ");
            points = int.Parse(Console.ReadLine());
            
            SimpleGoal simpleGoal = new SimpleGoal(goalName, desc, points, false);
            string addGoal = simpleGoal.Format();

            GoalList.Add(simpleGoal);
        }

        if (userInput == 2){
            Console.WriteLine("What is the name of the Goal: ");
            goalName = Console.ReadLine();

            Console.WriteLine("Please give a brief description of your goal: ");
            desc = Console.ReadLine();

            Console.WriteLine("How many points is the goal worth? ");
            points = int.Parse(Console.ReadLine());


            Eternal eternal = new Eternal(goalName, desc, points);

            GoalList.Add(eternal);
        }
    
        if (userInput == 3){
        Console.WriteLine("What is the name of the Goal: ");
            goalName = Console.ReadLine();

            Console.WriteLine("Please give a brief description of your goal: ");
            desc = Console.ReadLine();

            Console.WriteLine("How many points is the goal worth? ");
            points = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times must you do this goal until it is completed? ");
            int completed = int.Parse(Console.ReadLine());

            Console.WriteLine("How many bonus points do you want when you complete this goal? ");
            int bonus = int.Parse(Console.ReadLine());


            Checklist checklist = new Checklist(goalName, desc, points, completed, 0, bonus);

            GoalList.Add(checklist);
        }  

    }

    public void DisplayGoals(){
        foreach(Goals goal in GoalList){
            Console.WriteLine(goal);
        }
    }


    public void Save(){
        Console.WriteLine("What would you like to name the file (end it in .txt): ");
        string fileName = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(fileName, true))
        {
            foreach (Goals goal in GoalList){
             writer.WriteLine(goal);
             writer.WriteLine(" ");
            }
        }
    }


    public void Load(){
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
