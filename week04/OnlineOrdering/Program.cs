using System;

class Program
{
    static void Main()
    {
        // Creates the addresses
        Address address1 = new Address("123 Main St", "Los Angeles", "CA", "USA");
        Address address2 = new Address("456 Elm St", "Toronto", "ON", "Canada");

        // Creates costumer
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Creates products
        Product laptop = new Product("Laptop", 101, 999.99, 1);
        Product mouse = new Product("Mouse", 102, 25.50, 2);

        // Creates orders
        Order order1 = new Order(customer1);
        order1.AddProduct(laptop);
        order1.AddProduct(mouse);

        Order order2 = new Order(customer2);
        order2.AddProduct(mouse);

        // Shows the product details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():F2}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():F2}\n");
    }
}
