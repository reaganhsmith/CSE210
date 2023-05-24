class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer)
    {
        this.customer = customer;
        products = new List<Product>();
    }

    public void addProducts(Product product)
    {
        products.Add(product);
    }

    public double totalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }

        totalPrice += customer.GetShippingCost();

        return totalPrice;
    }

    public string packageLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (Product product in products)
        {
            packingLabel += $"{product.Name} (ID: {product.Id})\n";
        }
        return packingLabel;
    }

    public string shippingLabel()
    {
        
        return $"---------------------\nShipping Label:\nName: {customer.Name}\nAddress:\n{customer.Address.GetAddress()}\n---------------------";
    }
}
