using System;
using System.Collections.Generic;

namespace HandsOn_Observer
{
    class Program
    {
        public interface Subject
        {
            public void attach(Observer o);

            public void detach(Observer o);

            public void notifyUpdate(Message m);
        }
        public class MessagePublisher : Subject
        {

            private List<Observer> observers = new List<Observer>();
            private State state;
            public State GetState()
            {
                return this.state;
            }
            public void SetState(State state)
            {
                this.state = state;
                //state.stateName = ""
            }
            public void attach(Observer o)
            {
                observers.Add(o);
            }
            public void detach(Observer o)
            {
                observers.Remove(o);
            }
            public void notifyUpdate(Message m)
            {
                foreach (var observer in observers)
                {
                    Console.WriteLine("State of publisher : " + state.stateName);
                    observer.update(m);

                }
            }
        }
        public interface Observer

        {
            public void update(Message m);

        }
        public class MessageSubscriberOne : Observer

        {
            public void update(Message m)
            {
                Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());
            }

        }
        public class MessageSubscriberTwo : Observer
        {
            public void update(Message m)
            {
                Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());
            }
        }
        public class MessageSubscriberThree : Observer
        {
            public void update(Message m)
            {
                Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());
            }
        }
        public class Message
        {
            readonly String messageContent;
            public Message(String m)
            {
                this.messageContent = m;
            }
            public String getMessageContent()
            {
                return messageContent;
            }
        }
        public class State
        {
            public string stateName;
        }
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscriberThree s3 = new MessageSubscriberThree();

            MessagePublisher p = new MessagePublisher();
            State currentState = new State();
            currentState.stateName = "Active01";
            p.SetState(currentState);
            p.attach(s1);
            p.attach(s2);
            p.notifyUpdate(new Message("First Message")); //s1 and s2 will receive the update
            currentState.stateName = "Active02";
            p.SetState(currentState);
            p.detach(s1);
            p.attach(s3);
            p.notifyUpdate(new Message("Second Message")); //s2 and s3 will receive the update
        }
    }
}
