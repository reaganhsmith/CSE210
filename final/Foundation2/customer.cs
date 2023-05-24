class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public Address Address
    {
        get { return address; }
        private set { address = value; }
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public double GetShippingCost()
    {
        return address.IsInUSA() ? 5 : 35;
    }
}
