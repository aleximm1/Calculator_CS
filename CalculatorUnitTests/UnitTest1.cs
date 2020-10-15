using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_CS;
using System;

namespace CalculatorUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateConstructorTest()
        {
            Calculate calcObject = new Calculate();
        }

        [TestMethod]
        public void AddNumbersTest1()
        {
            Calculate calcObject = new Calculate();
            int result = calcObject.Add(3, 4);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void AddNumbersTest2()
        {
            Calculate calcObject = new Calculate();
            int result = calcObject.Add(15, 4);
            Assert.AreEqual(19, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void AddNumbersOutOfRangeTest()
        {
            Calculate calcObject = new Calculate();
            int result = calcObject.Add(int.MaxValue, 2);
            int expected = 0;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void SubtractNumbersTest()
        {
            Calculate calcObject = new Calculate();
            int result = calcObject.Subtract(15, 3);
            Assert.AreEqual(12, result);
        }
    }
}
