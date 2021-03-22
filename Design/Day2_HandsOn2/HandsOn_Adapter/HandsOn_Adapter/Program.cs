using System;

namespace HandsOn_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Movable bugattiVeyron = new BugattiVeyron(); 
            MovableAdapter bugattiVeyronAdapter = new MovableAdapterImpl();

            Console.WriteLine("Speed in MPH : " + bugattiVeyron.getSpeed());
            Console.WriteLine("Speed in KMPH : " + bugattiVeyronAdapter.getSpeed());

            Console.WriteLine("Price in USD : " + bugattiVeyron.getPrice());
            Console.WriteLine("Price in Euro : " + bugattiVeyronAdapter.getPrice());
        }
    }
}
