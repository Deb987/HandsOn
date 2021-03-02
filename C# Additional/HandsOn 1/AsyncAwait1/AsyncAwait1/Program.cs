using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsyncAwait1
{
    class Program
    {
        public async static Task FirstMethod()
        {
            string str = await SecondMethod();
            Console.WriteLine(str);
        }
        public async static Task<string> SecondMethod()
        {
            Thread.Sleep(5000);
            return "Welcome in SecondMethod";
        }
        static void Main(string[] args)
        {
            FirstMethod();
            Console.ReadLine();
        }
    }
}
