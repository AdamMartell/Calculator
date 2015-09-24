using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestAdd()
        {
            MathsCalculator calculator = new MathsCalculator();
            decimal expected = 10;
            decimal actual = calculator.Add(5,5);
            Assert.AreEqual(expected, actual);
        }
    }
}
