public class SimpleGoal : Goals{


    public SimpleGoal(string name, string desc, int point, bool completed) :base(name, desc, point){
        this._completed = completed;

    }

    public override void Display(int x){



        if(_completed){
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"{x}. [X] {_name} ({_description})");
            Console.WriteLine($"You have {_points} points");
        }
        else{
            Console.WriteLine(" ");
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"{x}. [ ]{_name} ({_description})"); 
            Console.WriteLine(" ");
        }
    }

    public override string Format()
    {
        return $"simple Goal:{_name}, {_description}, {_points}, {_completed}";
    }
}