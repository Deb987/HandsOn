using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudy_Observer
{
    class SteveObserver : INotificationObserver
    {
        public string Name { get => "Steve"; }

        public void OnServerDown()
        {
            Console.WriteLine(Name + " gets the message that Server is down");
        }
    }
}
