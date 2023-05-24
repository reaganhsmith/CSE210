class Order
{
    private List<Product> products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
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

        totalPrice += _customer.Address.IsInUSA() ? 5 : 35;

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
        return $"Shipping Label:\nName: {_customer.Name}\nAddress:\n{_customer.Address.GetFullAddress()}";
    }
}
