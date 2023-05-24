using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("112233 Chocolate Waffles", "Breaky", "WA", "US");
        Customer customer1 = new Customer("Mac Howzer", address1);

        Product product1 = new Product("lazy Dayz Graphic tee", "A12QE0", 29.99, 2);
        Product product2 = new Product("Plaid Squirt", "A134QWE", 32.52, 1);
        Product product3 = new Product("Buttery Smooth Bath Robe", "Y3456AQ", 25.99, 3);
        Product product4 = new Product("Sleek Sunglasses", "QWE33435", 15.99, 8);

        Order order1 = new Order(customer1);
        order1.addProducts(product1);
        order1.addProducts(product2);
        order1.addProducts(product3);
        order1.addProducts(product4);

        Console.WriteLine(" ");
        Console.WriteLine(order1.packageLabel());
        Console.WriteLine(" ");
        Console.WriteLine(order1.shippingLabel());
        Console.WriteLine($"Total Price: ${order1.totalPrice()}");
        Console.WriteLine(" ");


    }
}