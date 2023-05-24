class Address
{
    private string _address;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        this._address = streetAddress;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return _country == "USA";
    }

    public string GetAddress()
    {
        return $"{_address}\n {_city},{_state} {_country}";
    }
}