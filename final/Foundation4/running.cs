
public class Running : Activity{
    private double _distance;

    public Running(DateTime date, int duration, double distance) :base(date, duration){
        this._distance = distance;
    }

    public override double getDistance()
    {
        return _distance;
    }

    public override double getSpeed()
    {
        return Math.Round(((_distance / _duration) * 60), 2);
    }

    public override double getPace()
    {
        return Math.Round((_duration / _distance), 2);
    }

    public override string getSummary()
    {
        return $"Date: {_date.ToString("MM, dd, yyyy")}\nActivity: Running ({_duration} min)\nDistance: {_distance} miles, Speed: {getSpeed()}mph, Pace: {getPace()} min per mile";
    }

}
