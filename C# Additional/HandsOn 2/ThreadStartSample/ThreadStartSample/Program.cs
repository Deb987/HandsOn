using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadStartSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****ThreadStatrt Delegate App *****\n");
            Console.Write("Do you want [1] or [2] threads?");
            string threadCount = Console.ReadLine();

            //Naming the current thread 
            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            //Displaying thread info
            Console.WriteLine("->{0} is executing Main()", Thread.CurrentThread.Name);

            //worker class
            Printer p = new Printer();
            switch (threadCount)
            {
                case "2":
                    //Now make the thread.
                    Thread backGroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backGroundThread.Name = "Secondary";
                    backGroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("no choice mentioned");
                    goto case "1";
            }

            //Do some additional work.
            Console.WriteLine("Hello this from main!");
            Console.ReadLine();
        }
    }
}
