using System;

namespace PracticeCaseStudy_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            JohnObserver john = new JohnObserver();
            SteveObserver steve = new SteveObserver();

            NotificationService s = new NotificationService();

            s.AddSubscriber(john);
            s.AddSubscriber(steve);
            s.NotifySubscriber();

            s.RemoveSubscriber(john);
            s.NotifySubscriber();

            Console.ReadLine();
        }
    }
}
