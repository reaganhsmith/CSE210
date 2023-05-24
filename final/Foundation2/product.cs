class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return name; }
        private set { name = value; }
    }

    public string Id
    {
        get { return id; }
        private set { id = value; }
    }

    public double Price
    {
        get { return price; }
        private set { price = value; }
    }

    public int Quantity
    {
        get { return quantity; }
        private set { quantity = value; }
    }
}