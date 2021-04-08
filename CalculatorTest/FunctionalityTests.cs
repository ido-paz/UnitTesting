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
            Assert.AreEqual(calculator.Multiply(2, 4), 81);
        }

    }
}
