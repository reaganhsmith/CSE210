
public class Breathing : Activity{

    public Breathing(string startMessage, string endMessage, int timer) : base(startMessage, endMessage, timer) {

    }

    public void runActivity(){
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
            Console.Write("\b "); 
            Console.WriteLine(" ");
            }

            Console.WriteLine("Well done!");
            wait(2);
            Console.WriteLine($"You have completed {timer} seconds of the breathing activty");
        }
        
}
