
public class Listing : Activity{

    private List <string> _prompt = new List<string>();
    private List <string> _response = new List<string>();

        public Listing(string startMessage, string endMessage, int timer) : base(startMessage, endMessage, timer) {

    }

    public void addToPrompt(){
        _prompt.Add("Who are people that you appreciate?");
        _prompt.Add("What are personal strengths of yours?");
        _prompt.Add("Who are people that have helped you this week?");
        _prompt.Add("Wheen have you felt the holy ghost this month?");
        _prompt.Add("Who are some of your personal heros?");
        _prompt.Add("What are you grateful for?");

    }


    public string getRandom(List<string> myList) {
        Random random = new Random();
        int randomIndex = random.Next(0, myList.Count);
        string randomItem = myList[randomIndex];
        return randomItem;
    }

    public void _askPonder() {
        string randomPrompt = getRandom(_prompt);
        Console.WriteLine($"--- {randomPrompt} ---");
    }

    public void runActivity() {
        addToPrompt();
        Console.WriteLine("Welcome to the LISTING activity!");

        Console.WriteLine(" ");
        intro();
        wait(3);

        Console.WriteLine("Please consider the following prompt:");
        Console.WriteLine(" ");
    Console.Clear();
        Console.WriteLine("List how many respnses you can to the following prompt:");    
        _askPonder();
        Console.WriteLine(" ");
        Console.Write("You may begin in:   ");
        countDown(5);
        Console.WriteLine("\b ");
        Console.WriteLine(" ");




       int timer = getTimer();
       DateTime endTime = DateTime.Now.AddSeconds(timer);

        
        while (DateTime.Now < endTime)
            {
            string usersResponse = Console.ReadLine();
            _response.Add(usersResponse);
            }

            foreach(string item in _response){
                Console.WriteLine(item);
            }
            end("list activity");
        }


}