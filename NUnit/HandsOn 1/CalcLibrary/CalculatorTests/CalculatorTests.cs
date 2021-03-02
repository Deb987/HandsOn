using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CalcLibrary; 

namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator add;
        [SetUp]
        public void SetUpMethod()
        {
            add = new Calculator();
        }
        [Test]
        [TestCase(15,10,25)]
        [TestCase(5,6,11)]
        public void CalcTest(double num1, double num2, double expected)
        {
            double result = add.Addition(num1,num2);
            Assert.AreEqual(expected,result);

        }
        [TearDown]
        public void TearDownMethod()
        {
            
        }
    }
}
