using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class IsNegativeUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(-50.0, true)]
        [DataRow(40.00, false)]
        [DataRow(0.000, false)]
        public void DefineNegativeDoubleNumber(double inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(-26, true)]
        [DataRow(16, false)]
        [DataRow(0, false)]
        public void DefineNegativeIntNumber(int inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(-15.7f, true)]
        [DataRow(18f, false)]
        [DataRow(0f, false)]
        public void DefineNegativeFloatNumber(float inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("-11", true)]
        [DataRow("13.0", false)]
        [DataRow("0", false)]
        public void DefineNegativeStringNumber(string inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

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