using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class SubUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(4.0, 2.0, 2.00)]
        [DataRow(-6.00, -3.00, -3.00)]
        [DataRow(-15.000, 1.000, -16.00)]
        [DataRow(4.5000, 0.0000, 4.50)]
        public void ReturnSubtractingOfTwoDoubleNumbers(double firstInputNumber, double secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(13, 7, 6.00)]
        [DataRow(-5, -3, -2.00)]
        [DataRow(-6, 14, -20.00)]
        [DataRow(4, 0, 4.00)]
        public void ReturnSubtractingOfTwoIntNumbers(int firstInputNumber, int secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(4.5f, 2.5f, 2.00)]
        [DataRow(-6.00f, -3.00f, -3.00)]
        [DataRow(-15.000f, 1.000f, -16.00)]
        [DataRow(4.5000f, 0.0000f, 4.50)]
        public void ReturnSubtractingOfTwoFloatNumbers(float firstInputNumber, float secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("4", "3", 1.00)]
        [DataRow("-9.0", "-3.0", -6.0)]
        [DataRow("15", "-16.00", 31.00)]
        [DataRow("4.0", "0", 4.00)]
        public void ReturnSumOfTwoStringNumbers(string firstInputNumber, string secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

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