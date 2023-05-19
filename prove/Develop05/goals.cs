public class Goals{
    public bool _completed = false;
    public string _name;
    public string _description;
    public int _points;

    public Goals(string Name, string Desc, int points){
        _name = Name;
        _description = Desc;
        _points = points;
    }

    public virtual int CompleteGoal(){
        if(_completed == false){
            _completed = true;
            return _points;
        }
        else{
            return 0;
        }
    }

    public virtual void Display(int x){

    }

    public virtual string Format(){
        return " ";
    }





   


}



