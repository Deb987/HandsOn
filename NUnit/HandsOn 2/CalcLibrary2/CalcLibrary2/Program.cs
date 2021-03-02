using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary2
{
    interface IMathLibrary
    {
        double Addition(double a, double b);
        double Subtraction(double a, double b);
        double Multiplication(double a, double b);
        double Division(double a, double b);
    }
    public class Calculator : IMathLibrary
    {
        public double x;
        public double GetResult { get { return x; } set { x = value; } }

        public double Addition(double a, double b)
        {
            x = a + b;
            return x;
        }
        public double Subtraction(double a, double b)
        {
            x = a - b;
            return x;
        }
        public double Multiplication(double a, double b)
        {
            x = a * b;
            return x;
        }
        public double Division(double a, double b)
        {
            x = a / b;
            return x;
        }
        public double AllClear()
        {
            x = 0;
            return x;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
