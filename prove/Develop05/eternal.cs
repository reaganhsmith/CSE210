public class Eternal : Goals{
    public Eternal(string name, string desc, int point) :base(name, desc, point){

    }

    public override void Display(int x)
    {
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"{x}. [ ] {_name} ({_description})");

    }

    public override string Format()
    {
        return $"Eternal Goal: {_name}, {_description}, {_points}";
    }

    public override int CompleteGoal()
    {
        return _points;
    }



}