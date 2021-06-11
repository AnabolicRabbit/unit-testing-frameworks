using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class AddUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(2.0, 2.0, 4.00)]
        [DataRow(-3.00, -3.00, -6.00)]
        [DataRow(15.000, -16.000, -1.00)]
        [DataRow(4.5000, 0.0000, 4.50)]
        public void ReturnSumOfTwoDoubleNumbers(double firstInputNumber, double secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(6, 7, 13.00)]
        [DataRow(-2, -3, -5.00)]
        [DataRow(14, -20, -6.00)]
        [DataRow(4, 0, 4.00)]
        public void ReturnSumOfTwoIntNumbers(int firstInputNumber, int secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(3.0f, 3.0f, 6.00)]
        [DataRow(-3.00f, -3.00f, -6.00)]
        [DataRow(11.000f, -14.000f, -3.00)]
        [DataRow(8.0000f, 0.0000f, 8.00)]
        public void ReturnSumOfTwoFloatNumbers(float firstInputNumber, float secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("4", "3", 7.00)]
        [DataRow("-9.0", "-3.0", -12.0)]
        [DataRow("15", "-16.00", -1.00)]
        [DataRow("4.0", "0", 4.00)]
        public void ReturnSumOfTwoStringNumbers(string firstInputNumber, string secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

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