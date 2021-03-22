using System;

namespace CaseStudy_Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();

            Observer admin1 = new Observer("Admin 1");
            subject.Subscribe(admin1);

            Observer admin2 = new Observer("Admin 2");
            subject.Subscribe(admin2);
            subject.BookTicket("A");

            subject.Unsubscribe(admin1);

            Observer admin3 = new Observer("Admin 3");
            subject.Subscribe(admin3);
            subject.BookTicket("B");

            Console.ReadLine();
        }
    }
}
