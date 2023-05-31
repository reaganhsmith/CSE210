public class Cycling : Activity{

    private double _speed;

    public Cycling(DateTime date, int duration, double speed) :base(date, duration){
        this._speed = speed;
    }

    public override double getSpeed()
    {
        return _speed;
    }

    public override double getPace()
    {
        return  Math.Round((60 / _speed), 2);
    }

    public override string getSummary()
    {
        return $"Date:{_date.ToString("MM, dd, yyyy")}\nActivity:Cycling ({_duration} min)\nSpeed:{_speed}mph, Pace:{getPace()} min per mile";
    }
}