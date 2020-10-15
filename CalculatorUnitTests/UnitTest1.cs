using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator_CS;

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
        public void AddNumbersTest()
        {
            Calculate calcObject = new Calculate();
            int result = calcObject.Add(3, 4);
            Assert.AreEqual(7, result);
        }
    }
}
