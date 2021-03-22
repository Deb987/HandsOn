using System;

namespace CaseStudy_Design
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new Factory();
            
            Order order1 = factory.GenerateOrder("Electronic Products", "E-Commerce Website");
            Order order2 = factory.GenerateOrder("Furniture", "Tele Caller Agents Application");
            Order order3 = factory.GenerateOrder("Toys", "E-Commerce Website");

            order1.ProcessOrder();
            Console.WriteLine("Order1 ordered through: {0}\n" , order1.Channel);
            
            order2.ProcessOrder();
            Console.WriteLine("Order2 ordered through: {0}\n" , order2.Channel);
            
            order3.ProcessOrder();
            Console.WriteLine("Order3 ordered through: {0}\n" , order3.Channel);
            
            Console.ReadLine();
        }
    }
}
