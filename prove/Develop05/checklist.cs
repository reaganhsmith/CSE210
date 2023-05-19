public class Checklist : Goals
{

    private int _countGoal;
    private int _currentGoal;
    public int _bonus;
    List<string> MenuList = new List<string>();

    public Checklist(string name, string desc, int point, int countGoal, int currentGoal, int bonus) :base(name, desc, point){
        _countGoal = countGoal;
        _currentGoal = currentGoal;
        _bonus = bonus;
    }

    public override void Display(int x){
        if(_completed){
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"{x}. [X] {_name} ({_description})");
            Console.WriteLine($"Current completed: {_currentGoal}/{_countGoal}");

            Console.WriteLine($"You have points now"); 

        }
        else{
            Console.WriteLine("The goals are: ");
            Console.WriteLine($"{x}. [ ] {_name} ({_description})"); 
            Console.WriteLine($"Current completed: {_currentGoal}/{_countGoal}");

        }

    }

    public override int CompleteGoal(){
        if (_completed == false){
            _currentGoal += 1;
            if (_currentGoal == _countGoal)
            {
                _completed = true;
                Console.Write("Yay you completed your goal");
                return _points + _bonus;
            }
            else{
                return _points;
            }
        }
        else{
            return 0;
        }
    }




    
}