using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_Observer
{
    interface ISubject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
    public class Event
    {
        public string EventName { get; set; }
        public int TicketSold { get; set; }
    }
    public class Subject : ISubject
    {
        private List<Observer> observers = new List<Observer>();
        //private int _int = 100;
        private List<Event> events = new List<Event>()
        {
            new Event(){EventName= "A", TicketSold = 100},
            new Event(){EventName = "B", TicketSold = 99}
        };
        public void BookTicket(string eventName)
        {
            foreach(var e in events)
            {
                if (String.Equals(e.EventName, eventName))
                {
                    e.TicketSold++;
                    if(e.TicketSold > 100)
                    {
                        Notify();
                    }
                }
            }
            
        }
    //    public int EventsTicketBooked
    //    {
    //        get
    //        {
    //            return _int;

    //        }
    //        set
    //        {

    //            if (e.TicketSold > 100)
    //                Notify();
    //            _int = value;
    //        }
    //    }
    //}
    public void Subscribe(Observer observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribe(Observer observer)
        {
            observers.Remove(observer);
        }
        public void Notify()
        {
            observers.ForEach(x => x.Update());
        }
    }
}
