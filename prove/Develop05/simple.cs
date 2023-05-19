public class SimpleGoal : Goals{


    public SimpleGoal(string name, string desc, int point, bool completed) :base(name, desc, point){
        this._completed = completed;

    }

    public override void Display(){



        if(_completed){
            Console.WriteLine(" ");
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"[X] {_name} ({_description})");
            Console.WriteLine($"You have {_points} points");
            Console.WriteLine(" ");
        }
        else{
            Console.WriteLine(" ");
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"[ ]{_name} ({_description})"); 
            Console.WriteLine(" ");
        }
    }

    public override string Format()
    {
        return $"simple Goal:{_name}, {_description}, {_points}, {_completed}";
    }
}