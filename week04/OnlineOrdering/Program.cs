using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Console.WriteLine();

        // Order 1: customer in the USA
        Address address1 = new Address("123 Maple Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("John Carter", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Wireless Mouse", "WM100", 12.50, 2));
        order1.AddProduct(new Product("USB Keyboard", "KB220", 25.00, 1));
        order1.AddProduct(new Product("Laptop Stand", "LS330", 18.75, 1));

        // Order 2: customer outside the USA
        Address address2 = new Address("45 Allen Avenue", "Ikeja", "Lagos", "Nigeria");
        Customer customer2 = new Customer("Adeoye George", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Notebook Pack", "NB410", 4.00, 5));
        order2.AddProduct(new Product("Ballpoint Pens", "PN520", 1.50, 10));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Price: ${order.GetTotalPrice().ToString("F2")}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine();
    }
}