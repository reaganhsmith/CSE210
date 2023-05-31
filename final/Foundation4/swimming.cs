public class Swimming : Activity{

    private int _laps;

    public Swimming(DateTime date, int duration, int laps) :base(date, duration){
        this._laps = laps;
    }

    public override double getDistance()
    {
        return Math.Round((_laps * 50 / 1000 * 0.62), 2);
    }

    public override double getSpeed()
    {
        return Math.Round(((getDistance() / _duration) * 60), 2);
    }

    public override double getPace()
    {
        return Math.Round((_duration / getDistance()), 2);
    }
    public override string getSummary()
        {
            return $"Date: {_date.ToString("MM, dd, yyyy")}\nActivity: Swimming ({_duration} min)\nDistance: {getDistance()} miles, Speed: {getSpeed()}mph, Pace: {getPace()} min per mile";
        }
}
