using System;

namespace OnlineOrder
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            List<Order> orders = new List<Order>();

            Address address1 = new Address("Suite 46 BlueCrest Mall", "Sangotedo", "Lagos", "Nigeria");
            Customer customer1 = new Customer("Mr Tony Nweke", address1);
            Order order1 = new Order(customer1);
            order1.AddProducts("AC012", "Frame Holder", 10.15f, 3);
            order1.AddProducts("OP035", "Rayban Frame", 159.05f, 1);
            order1.AddProducts("AC002", "Rayban Case", 0.01f, 1);
            orders.Add(order1);

            Address address2 = new Address("Temple Drive", "Salt Lake", "Utah", "USA");
            Customer customer2 = new Customer("Ms Liz Smith", address2);
            Order order2 = new Order(customer2);
            order2.AddProducts("AC012", "Frame Holder", 10.15f, 3);
            order2.AddProducts("OP035", "Rayban Frame", 159.05f, 1);
            order2.AddProducts("AC002", "Rayban Case", 0.01f, 1);
            orders.Add(order2);

            Address address3 = new Address("5 Yateem Lane", "Khalifa City A", "Abu Dhabi", "UAE");
            Customer customer3 = new Customer("Dr. Ben Adjeh", address3);
            Order order3 = new Order(customer3);
            order3.AddProducts("AC012", "Frame Holder", 10.15f, 3);
            order3.AddProducts("OP035", "Rayban Frame", 159.05f, 1);
            order3.AddProducts("AC002", "Rayban Case", 0.01f, 1);
            orders.Add(order3);

            foreach (Order order in orders)
            {
                Console.WriteLine($"{order.FormatShippingLabel()}");
                order.PrintPackingLabel();
                Console.WriteLine($"Total Bill: ${order.ComputeOrdercost()}");
                Console.WriteLine();
            }

        }
    }
}