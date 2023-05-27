public class Outdoor : Events{
    private string _weather;

    public Outdoor(string title, string desc, DateTime date, TimeSpan time, Address address, string weather) 
    :base(title, desc, date, time, address){
        this._weather = weather;
    }

    public override string fullDetails()
    {
        return $"{base.fullDetails()}\nType: Outdodor Gathering\nWeather: {_weather}";
    }
}