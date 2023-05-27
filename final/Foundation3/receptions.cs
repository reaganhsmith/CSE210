class Reception : Events{
    private string _rsvp;

    public Reception(string title, string desc, DateTime date, TimeSpan time, Address address, string rsvp) 
    :base(title, desc, date, time, address){
        this._rsvp = rsvp;
    }

    public override string fullDetails()
    {
        return $"{base.fullDetails()}\nType: Reception\nRSVP Email: {_rsvp}";
    }


}

