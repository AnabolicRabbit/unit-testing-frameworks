using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MSTesting
{
    [TestClass]
    public class DivideUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(6.0, 2.0, 3.00)]
        [DataRow(-6.00, 1.50, -4.00)]
        [DataRow(0.000, 10.000, 0.00)]
        [DataRow(8.0000, -2.0000, -4.00)]
        public void ReturnDivisionOfTwoDoubleNumbers(double firstInputNumber, double secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(5, 2, 2.50)]
        [DataRow(-16, 2, -8.00)]
        [DataRow(0, 12, 0.00)]
        [DataRow(14, -2, -7.00)]
        public void ReturnDivisionOfTwoIntNumbers(int firstInputNumber, int secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(10.0f, 2.0f, 5.00)]
        [DataRow(-7.00f, 3.50f, -2.00)]
        [DataRow(0.000f, 13.000f, 0.00)]
        [DataRow(15.0000f, -7.5000f, -2.00)]
        public void ReturnDivisionOfTwoFloatNumbers(float firstInputNumber, float secondInputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnDivideByZeroException()
        {
            //Arrange
            int firstInputNumber = 4;
            int secondInputNumber = 0;
            string expectedResult = "∞";

            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult.ToString());
        }

        [TestCleanup]
        public void TestClean()
        {
            calculator = null;
        }
    }
}