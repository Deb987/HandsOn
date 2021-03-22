using System;
using System.Collections.Generic;

namespace HandsOn_Mediator
{
    class Program
    {
        public interface IChatMediator
        {
            void AddUser(IUser user);
            void SendMessage(IUser user, string message);
        }
        public interface IUser
        {
            void ReceiveMessage(string message);
            void SendMessage(string message);
        }
        public class ChatMediator : IChatMediator
        {
            List<IUser> users = new List<IUser>();
            public void AddUser(IUser user)
            {
                users.Add(user);
            }
            public void SendMessage(IUser user, string message)
            {
                foreach (var u in users)
                {
                    if (user != u)
                    {
                        u.ReceiveMessage(message);
                    }
                }
            }
            
        }
        public class BasicUser : IUser
        {
            public IChatMediator chatMediator { get; set; }
            public string name { get; set; }
            public BasicUser(string name, IChatMediator mediator)
            {
                this.chatMediator = mediator;
                this.name = name;
            }
            public void ReceiveMessage(string message)
            {
                Console.WriteLine("{0} (Basic User) Recieved Message : {1}",this.name,message);
            }
            public void SendMessage(string message)
            {
                Console.WriteLine("\n {0} (Basic User) Sending Message : {1}",this.name,message);
                chatMediator.SendMessage(this,message);
            }
        }
        public class PremiumUser : IUser
        {
            public IChatMediator chatMediator { get; set; }
            public string name { get; set; }
            public PremiumUser(string name, IChatMediator mediator)
            {
                this.name = name;
                this.chatMediator = mediator;
            }
            public void ReceiveMessage(string message)
            {
                Console.WriteLine("\n {0} (Premium User) Received Message : {1}",this.name,message);
            }
            public void SendMessage(string message)
            {
                Console.WriteLine("\n {0} (Premium User) Sending Message : {1}",this.name,message);
                chatMediator.SendMessage(this,message);
            }
        }
        static void Main(string[] args)
        {
            ChatMediator mediator = new ChatMediator();
            IUser a = new BasicUser("A", mediator);
            IUser b = new BasicUser("B", mediator);
            IUser c = new PremiumUser("C", mediator);
            IUser d = new PremiumUser("D", mediator);
            //adding to list of receiver
            mediator.AddUser(a);
            mediator.AddUser(b);
            mediator.AddUser(c);
            mediator.AddUser(d);
            //sending message
            a.SendMessage("Hi");

            Console.ReadLine();
        }
    }
}
