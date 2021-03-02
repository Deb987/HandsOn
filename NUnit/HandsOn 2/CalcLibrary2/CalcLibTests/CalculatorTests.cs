using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary2;

namespace CalcLibTests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        [TestCase(30,20,50)]
        [TestCase(100,150,250)]
        public void AdditionTest(double a, double b, double expected)
        {
            Calculator cal = new Calculator();
            double result = cal.Addition(a, b);
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase(30,10,20)]
        [TestCase(60,90,-30)]
        public void SubtractionTest(double a, double b, double expected)
        {
            Calculator cal = new Calculator();
            double result = cal.Subtraction(a,b);
            Assert.AreEqual(expected,result);
        }
        [Test]
        [TestCase(5,6,30)]
        [TestCase(6,9,54)]
        public void MultiplicationTest(double a, double b, double expected)
        {
            Calculator cal = new Calculator();
            double result = cal.Multiplication(a,b);
            Assert.AreEqual(expected,result);
        }
        [Test]
        [TestCase(10,2,5)]
        [TestCase(20,0,null)]
        public void DivisionTest(double a, double b, double expected)
        {
            Calculator cal = new Calculator();
            try
            {
                double result = cal.Division(a, b);
                Assert.AreEqual(expected, result);
                //Assert.Fail();
            }
            catch(DivideByZeroException e)
            {
                List<string> message = new List<string> { e.Message };
                //Assert.Contains("Division by zero.",message);
                Assert.Fail("Division by zero.");
            }
        }

        [Test]
        [TestCase(10,20,30)]
        public void TestAddAndClear(double a, double b, double expected)
        {
            Calculator cal = new Calculator();
            double result = cal.Addition(a,b);
            Assert.AreEqual(expected,result);
            result = cal.AllClear();
            Assert.AreEqual(0, result);
        }
    }
}
