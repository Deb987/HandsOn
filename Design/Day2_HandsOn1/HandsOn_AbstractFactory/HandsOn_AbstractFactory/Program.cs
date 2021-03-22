using System;

namespace HandsOn_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoFactory autoFactory = new AutoFactory();

            Factory car1 = autoFactory.GetFactory("Audi");
            car1.makeHeadLight();
            car1.makeTire();

            Factory car2 = autoFactory.GetFactory("Mercedes");
            car2.makeHeadLight();
            car2.makeTire();

            Console.ReadLine();
        }
    }
}
