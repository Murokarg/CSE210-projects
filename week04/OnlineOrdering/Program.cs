using System;

class Program
{
    static void Main(string[] args)
    {
         // Create addresses
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Address address2 = new Address("456 Oak Ave", "Toronto", "ON", "Canada");
        Address address3 = new Address("789 Pine Rd", "London", "Greater London", "UK");

        // Create customers
        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("Jane Doe", address2);
        Customer customer3 = new Customer("Bob Johnson", address3);

        // Create products
        Product product1 = new Product("Laptop", "P001", 999.99, 1);
        Product product2 = new Product("Mouse", "P002", 25.50, 2);
        Product product3 = new Product("Keyboard", "P003", 75.00, 1);
        Product product4 = new Product("Monitor", "P004", 299.99, 1);
        Product product5 = new Product("USB Cable", "P005", 12.99, 3);

        // Create Order 1 (USA customer)
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        // Create Order 2 (International customer)
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display Order 1 details
        Console.WriteLine("=== ORDER 1 ===");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}");
        Console.WriteLine();

        // Display Order 2 details
        Console.WriteLine("=== ORDER 2 ===");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}");
        Console.WriteLine();

        // Create Order 3 (Another international customer)
        Order order3 = new Order(customer3);
        order3.AddProduct(product2);
        order3.AddProduct(product3);

        Console.WriteLine("=== ORDER 3 ===");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost: ${order3.GetTotalCost():F2}");
    }

}