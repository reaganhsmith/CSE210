public class Eternal : Goals{
    public Eternal(string name, string desc, int point) :base(name, desc, point){

    }

    public override void Display()
    {
            Console.WriteLine(" ");
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"[X] {_name} ({_description})");
            Console.WriteLine(" ");

    }

    public override int CompleteGoal()
    {
        return _points;
    }



}