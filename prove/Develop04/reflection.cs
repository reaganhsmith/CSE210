public class Reflection : Activity {
    private List<string> _prompts = new List<string>();
    private List<string> _ponder = new List<string>();

    public Reflection(string startMessage, string endMessage, int timer) : base(startMessage, endMessage, timer) {

    }

    public void AddToList() {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _ponder.Add("Why was this experience meaningful to you?");
        _ponder.Add("Have you ever done anything like this before?");
        _ponder.Add("How did you get started?");
        _ponder.Add("How did you feel when it was complete?");
        _ponder.Add("What made this time different than other times when you were not as successful?");
        _ponder.Add("What is your favorite thing about this experience?");
        _ponder.Add("What could you learn from this experience that applies to other situations?");
        _ponder.Add("What did you learn about yourself through this experience?");
        _ponder.Add("How can you keep this experience in mind in the future?");
    }

public string getRandom(List<string> myList) {
        Random random = new Random();
        int randomIndex = random.Next(0, myList.Count);
        string randomItem = myList[randomIndex];
        return randomItem;
    }

    public void _askPonderQuestions() {
        string ponderQuestion = getRandom(_ponder);
        Console.WriteLine(ponderQuestion);
    }

    public void _askPrompt() {
        string prompt = getRandom(_prompts);
        Console.WriteLine($"---{prompt}---");
    }

    

    public void runActivity() {
        AddToList();
        Console.WriteLine("Welcome to the REFLECTION activity!");
        Console.WriteLine(" ");
        intro();
        wait(3);
        Console.WriteLine("Please consider the following prompt:");

        Console.WriteLine(" ");
        _askPrompt();
        Thread.Sleep(3000);
        Console.WriteLine("When you have something in mind press enter to continue.");
        Console.ReadLine();
        Console.WriteLine(" ");
        Console.Write("Now ponder on the following questions and how they relate to your experience...");
        countDown(5);

        Console.Clear();
        _askPonderQuestions();  
        wait(3);
        _askPonderQuestions();  
        wait(3);
        _askPonderQuestions();  
        wait(3);

        int timer = getTimer();
       DateTime endTime = DateTime.Now.AddSeconds(timer);
        while (DateTime.Now < endTime)
            {
            _askPonderQuestions();  
            wait(3);
            }
            Console.Clear();

            end("Reflect activity");
        }

        
    }
