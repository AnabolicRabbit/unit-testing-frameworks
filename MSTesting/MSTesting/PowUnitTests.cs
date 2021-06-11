using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class PowUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(4.0, 2.0, 16.00)]
        [DataRow(-2.00, 3.00, -8.00)]
        [DataRow(0.000, 5.000, 0.00)]
        [DataRow(5.0000, 0.0000, 1.00)]
        [DataRow(10.0, -1.0, 0.10)]
        [DataRow(4.00, 0.50, 2.00)]
        [DataRow(0.000, 0.000, 1.00)]
        public void ReturnValueOfPowerForTwoDoubleNumbers(double firstInputNumber, double secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(4, 2, 16.00)]
        [DataRow(-2, 3, -8.00)]
        [DataRow(0, 5, 0.00)]
        [DataRow(5, 0, 1.00)]
        [DataRow(10, -1, 0.10)]
        [DataRow(0, 0, 1.00)]
        public void ReturnValueOfPowerForTwoIntNumbers(int firstInputNumber, int secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(4.0f, 2.0f, 16.00)]
        [DataRow(-2.00f, 3.00f, -8.00)]
        [DataRow(0.000f, 5.000f, 0.00)]
        [DataRow(5.0000f, 0.0000f, 1.00)]
        [DataRow(10.0f, -1.0f, 0.10)]
        [DataRow(4.00f, 0.50f, 2.00)]
        [DataRow(0.000f, 0.000f, 1.00)]
        public void ReturnValueOfPowerForTwoFloatNumbers(float firstInputNumber, float secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("4", "2", 16.00)]
        [DataRow("-2.00", "3.00", -8.00)]
        [DataRow("0", "5.000", 0.00)]
        [DataRow("5.0000", "0", 1.00)]
        [DataRow("10.0", "-1.0", 0.10)]
        [DataRow("4.00", "0.50", 2.00)]
        [DataRow("0.000", "0.000", 1.00)]
        public void ReturnValueOfPowerForTwoStringNumbers(string firstInputNumber, string secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

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