using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class SinUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(0.0, 0.00)]
        [DataRow(30.00, -0.9880316240928618)]
        [DataRow(-30.000, 0.9880316240928618)]
        public void ReturnSinusOfDoubleNumber(double inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(0, 0.00)]
        [DataRow(30, -0.9880316240928618)]
        [DataRow(-30, 0.9880316240928618)]
        public void ReturnSinusOfIntNumber(int inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(0.0f, 0.00)]
        [DataRow(30.00f, -0.9880316240928618)]
        [DataRow(-30.000f, 0.9880316240928618)]
        public void ReturnSinusOfFloatNumber(float inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("0.0", 0.00)]
        [DataRow("30.00", -0.9880316240928618)]
        [DataRow("-30.000", 0.9880316240928618)]
        public void ReturnSinusOfStringNumber(string inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

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