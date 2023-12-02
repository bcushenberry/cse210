using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("1 Bob Street", "Bobbington", "Maine", "USA");
        Address a2 = new Address("2 Keito-doori", "Keito-shi", "Kanagawa", "Japan");

        Customer c1 = new Customer("Bob Bobson", a1);
        Customer c2 = new Customer("Kate Kateson", a2);

        List<Product> pList1 = new List<Product>();
        pList1.AddRange(new List<Product>
        {
            new Product("Toothpaste", 55340, 2.50, 6),
            new Product("Apple", 22222, 0.49, 20),
            new Product("Sweater", 86454, 33.33, 1)
        });        

        List<Product> pList2 = new List<Product>();
        pList2.AddRange(new List<Product>
        {
            new Product("Rice - 20kg", 10001, 10.00, 2),
            new Product("Toothpaste", 55340, 2.50, 5),
            new Product("Blanket", 96811, 24.99, 1)
        });       

        Order order1 = new Order(pList1, c1);
        Order order2 = new Order(pList2, c2);

        Console.WriteLine("");
        Console.WriteLine("Order 1");
        order1.Display();

        Console.WriteLine("");
        Console.WriteLine("Order 2");       
        order2.Display();
    }
}