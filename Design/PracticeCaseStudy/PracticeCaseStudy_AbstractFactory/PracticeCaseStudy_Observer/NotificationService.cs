using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudy_Observer
{
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();

        public void AddSubscriber(INotificationObserver observer)
        {
            observers.Add(observer);
            Console.WriteLine(observer.Name + " is added to the list.");
            Console.WriteLine("\n List of Subscribers");
            foreach (var o in observers)
            {
                Console.WriteLine(o.Name);
            }
        }

        public void NotifySubscriber()
        {
            foreach (var o in observers)
            {
                o.OnServerDown();
            }

        }

        public void RemoveSubscriber(INotificationObserver observer)
        {

            observers.Remove(observer);
            Console.WriteLine(observer.Name + " is removed from the list.");
            Console.WriteLine("\n List of Subscriber.");
            foreach (var o in observers)
            {
                Console.WriteLine(o.Name);
            }
        }
    }
}
