
public class Breathing : Activity{

    public Breathing(string startMessage, string endMessage, int timer) : base(startMessage, endMessage, timer) {

    }

    public void runActivity(){

        Console.WriteLine("Welcome to the BREATH activity!");
        Console.WriteLine(" ");

        intro();
        wait(3);

       int timer = getTimer();
       DateTime endTime = DateTime.Now.AddSeconds(timer);

        Console.Clear();
        while (DateTime.Now < endTime)
            { 
            Console.Write("Breath in.... ");
            countDown(6);
            Console.WriteLine("\b ");
            Console.WriteLine(" ");

            Console.Write("Now breath out... ");
            countDown(4);
            Console.WriteLine("\b "); 
            Console.WriteLine(" ");
            }

            end("breath activity");
        }
        
}
