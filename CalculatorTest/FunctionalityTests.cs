using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class FunctionalityTests
    {
        [TestMethod]
        public void Test_Multiply_Result()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.AreEqual(calculator.Multiply(2, 4), 8);
        }

        [TestMethod]
        public void Test_Divide_Result()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.AreEqual(calculator.Divide(4, 2), 2);
        }

        [TestMethod]
        public void Test_Perimeter_Result()
        {
            Calculator.Calculator calculator = new Calculator.Calculator();
            Assert.AreEqual(calculator.Perimeter(4, 2), 12);
        }

    }
}
