using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1
        Address address1 = new Address("875 Sunset Blvd", "Los Angeles", "CA", "USA");
        Customer customer1 = new Customer("Olivia Carter", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Keyboard", "P3001", 59.99, 1));
        order1.AddProduct(new Product("Bluetooth Mouse", "P3002", 34.95, 2));
        order1.AddProduct(new Product("27-inch Monitor", "P3003", 249.99, 1));

        // Order 2
        Address address2 = new Address("221 Baker Street", "London", "England", "United Kingdom");
        Customer customer2 = new Customer("James Walker", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Noise Cancelling Headphones", "P4001", 189.99, 1));
        order2.AddProduct(new Product("Portable SSD 1TB", "P4002", 129.50, 1));

        // Display 1
        Console.WriteLine(" ORDER 1 ");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("Shipping Address:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        // Display 2
        Console.WriteLine(" ORDER 2 ");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine("Shipping Address:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}