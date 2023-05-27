public class Lecture : Events{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string desc, DateTime date, TimeSpan time, Address address, string speaker, int capacity) : base(title, desc, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string fullDetails(){
        return $"{base.fullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
