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
            decimal actual = calculator.Add(5, 5);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestSubtract()
        {
            MathsCalculator calculator = new MathsCalculator();
            decimal expected = 10;
            decimal actual = calculator.Subtract(20, 10);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMultiply()
        {
            MathsCalculator calculator = new MathsCalculator();
            decimal expected = 10;
            decimal actual = calculator.Multiply(5, 2);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDivide()
        {
            MathsCalculator calculator = new MathsCalculator();
            decimal expected = 1;
            decimal actual = calculator.Divide(2, 0);
            Assert.AreEqual(expected, actual);
        }


    }
}

