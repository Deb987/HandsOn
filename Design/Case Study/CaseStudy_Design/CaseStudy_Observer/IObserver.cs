using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Observer
{
    interface IObserver
    {
        void Update();
    }
    public class Observer : IObserver
    {
        public string ObserverName { get; private set; }
        public Observer(string name)
        {
            this.ObserverName = name;
        }
        public void Update()
        {
            Console.WriteLine("{0}: A new event's sold-ticket crossed 100",this.ObserverName);
        }
    }
}
