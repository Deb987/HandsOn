using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Design
{
    class AbstractClass
    {
    }
    public abstract class Order
    {
        public string ProductType { get; set; }
        public string Channel { get; set; }
        public Order(string prodType, string channel)
        {
            this.ProductType = prodType;
            this.Channel = channel;
        }
        public Order()
        { }
        public abstract void ProcessOrder();
    }
    public class ElectronicOrder : Order
    {
        public ElectronicOrder(string prodType, string channel) : base(prodType, channel)
        {

        }
        public override void ProcessOrder()
        {
            Console.WriteLine("Order of Electronic Products being processed. \n");
        }
    }
    public class FurnitureOrder : Order
    {
        public FurnitureOrder(string prodType, string channel) : base(prodType, channel)
        {

        }
        public override void ProcessOrder()
        {
            Console.WriteLine("Order of Furniture being processed. \n");
        }
    }
    public class ToysOrder : Order
    {
        public ToysOrder(string prodType, string channel) : base(prodType, channel)
        {

        }
        public override void ProcessOrder()
        {
            Console.WriteLine("Order of Toys being processed. \n");
        }
    }

    public class Factory
    {
        public Order GenerateOrder(string prodType, string channel)
        {
            if (prodType == null)
            {
                return null;
            }
            else if (prodType.Equals("Electronic Products", StringComparison.InvariantCultureIgnoreCase))
            {
                Order order = new ElectronicOrder(prodType, channel);
                order.Channel = channel;
                return order;
            }
            else if (prodType.Equals("Furniture", StringComparison.InvariantCultureIgnoreCase))
            {
                Order order = new FurnitureOrder(prodType, channel);
                order.Channel = channel;
                return order;
            }
            else if (prodType.Equals("Toys", StringComparison.InvariantCultureIgnoreCase))
            {
                Order order = new ToysOrder(prodType, channel);
                order.Channel = channel;
                return order;
            }
            return null;
        }
    }
}
