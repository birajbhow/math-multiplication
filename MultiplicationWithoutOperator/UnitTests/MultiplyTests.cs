using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiplicationWithoutOperator;

namespace UnitTests
{
    [TestClass]
    public class MultiplyTests
    {
        [TestMethod]
        public void multiply_method_returns_correct_result()
        {
            // arrange
            int num1 = 5, num2 = 5;

            // act
            int result = Program.multiply(num1, num2);

            // assert
            Assert.AreEqual(25, result);
        }
    }
}
