using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class AbsUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(1.0, 1.00)]
        [DataRow(-2.00, 2.00)]
        [DataRow(0.000, 0.00)]
        public void ReturnAbsoluteOfDoubleNumber(double inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(7, 7.00)]
        [DataRow(-19, 19.00)]
        [DataRow(0, 0.00)]
        public void ReturnAbsoluteOfIntNumber(int inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(12.0f, 12.00)]
        [DataRow(-19f, 19.00)]
        [DataRow(0f, 0.00)]
        public void ReturnAbsoluteOfFloatNumber(float inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("5", 5.00)]
        [DataRow("-5.0", 5.00)]
        [DataRow("5.00", 5.00)]
        public void ReturnAbsoluteOfStringNumber(string inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

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