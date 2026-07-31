using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 - USA Customer
        Address address1 = new Address("47 Fleet St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Emmanuel Landon", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Game pad", "A1012", 799.99, 1));
        order1.AddProduct(new Product("Flash drive", "A1013", 25.50, 2));
        order1.AddProduct(new Product("USB cord", "A1014", 95.00, 1));

        // Order 2 - International Customer
        Address address2 = new Address("121 King's St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Matt Gerald", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Battery", "A2011", 29.99, 1));
        order2.AddProduct(new Product("Memory Chip", "A2012", 69.99, 1));

        // Display Order 1
        Console.WriteLine(" ORDER 1 ");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("Shipping Address:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        // Display Order 2
        Console.WriteLine(" ORDER 2 ");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("Shipping Address:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}