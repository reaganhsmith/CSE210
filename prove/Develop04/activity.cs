
public class Activity{
    private string _startMessage;
    private string _endMessage;
    private int _timer;


    public Activity(string startMessage, string endMessage, int timer){
        _startMessage = startMessage;
        _endMessage = endMessage;
        _timer = timer;
    }

    public string getStart(){
        return _startMessage;
    }

    public string getEnd(){
        return _endMessage;

    }

    public int getTimer(){
        return _timer;
    }

    public void intro(){
        Console.WriteLine(_startMessage);
        Console.WriteLine(" ");
        Console.WriteLine("How many seconds do you want to spend on todays activity?");
        _timer = int.Parse(Console.ReadLine());
        Console.WriteLine(" ");
        Console.Clear();
        Console.WriteLine("Get ready...");
    }

    public void wait(int duration){
        for (int i =0; i < duration; i++){
                  Console.Write("/");
                  Thread.Sleep(500);
                  Console.Write("\b"); 
                  
                  Console.Write("|");
                  Thread.Sleep(500);
                  Console.Write("\b"); 
            
                  Console.Write("\\");
                  Thread.Sleep(500);
                  Console.Write("\b\b"); 
                  
                  Console.Write("-");
                  Thread.Sleep(500);
                  Console.Write("\b");
            }
    }

          public void countDown(int time)
      {
            for (int i = time; i > 0; i--)
            {
            Console.Write("\b"); // Erase the + character

            Console.Write($"{i}");

            Thread.Sleep(1000);
                  
            }
            
        }
}