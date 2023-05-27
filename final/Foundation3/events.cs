public class Events{
    private string _title;
    private string _description;
    private DateTime _date;
    private TimeSpan _time;
    private Address _address;

    public Events(string title, string desc, DateTime date, TimeSpan time, Address address){
        this._title = title;
        this._description = desc;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string getStandardDetails(){
        return $"{_title}, {_description}\n{_date}, {_time}, {_address}\n";
    }

    public virtual string fullDetails(){
        return getStandardDetails();
    }

    public string shortDescription(){
        return $"type: {GetType().Name}\nTitle: {_title}\nDate:{_date.ToShortDateString()}";
    }


}
