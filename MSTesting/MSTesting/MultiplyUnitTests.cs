using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class MultiplyUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(6.0, 2.0, 12.00)]
        [DataRow(-6.00, 1.50, -9.00)]
        [DataRow(0.000, 10.000, 0.00)]
        [DataRow(8.0000, -2.0000, -16.00)]
        [DataRow(0.0, 0.0, 0.00)]
        public void ReturnProductOfTwoDoubleNumbers(double firstInputNumber, double secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Multiply(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(5, 2, 10.00)]
        [DataRow(-16, 2, -32.00)]
        [DataRow(0, 12, 0.00)]
        [DataRow(14, -2, -28.00)]
        [DataRow(0, 0, 0.00)]
        public void ReturnProductOfTwoIntNumbers(int firstInputNumber, int secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Multiply(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(10.0f, 2.0f, 20.00)]
        [DataRow(-7.00f, 3.50f, -24.50)]
        [DataRow(0.000f, 13.000f, 0.00)]
        [DataRow(15.0000f, -7.5000f, -112.50)]
        [DataRow(0f, 0f, 0.00)]
        public void ReturnProductOfTwoFloatNumbers(float firstInputNumber, float secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Multiply(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void TestClean()
        {
            calculator = null;
        }
    }
}