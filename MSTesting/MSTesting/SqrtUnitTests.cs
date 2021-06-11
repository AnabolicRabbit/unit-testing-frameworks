using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class SqrtUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(4.0, 2.00)]
        [DataRow(0.00, 0.00)]
        public void ReturnSquareRootOfDoubleNumber(double inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(4, 2.00)]
        [DataRow(0, 0.00)]
        public void ReturnSquareRootOfIntNumber(int inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(4.0f, 2.00)]
        [DataRow(0.00f, 0.00)]
        public void ReturnSquareRootOfFloatNumber(float inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("4.0", 2.00)]
        [DataRow("16", 4.00)]
        [DataRow("0", 0.00)]
        public void ReturnSquareRootOfStringNumber(string inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ReturnSquareRootOfNegativeNumber()
        {
            //Arrange
            double inputNumber = -4.00;
            string expectedResult = "NaN";

            //Act
            double actualResult = calculator.Sqrt(inputNumber);

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