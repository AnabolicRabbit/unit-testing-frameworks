using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class IsPositiveUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(-50.5, false)]
        [DataRow(40.00, true)]
        [DataRow(0.000, false)]
        public void DefinePositiveDoubleNumber(double inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(-10, false)]
        [DataRow(15, true)]
        [DataRow(0, false)]
        public void DefinePositiveIntNumber(int inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(-19.9f, false)]
        [DataRow(18.3f, true)]
        [DataRow(0f, false)]
        public void DefinePositiveFloatNumber(float inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("-15.5", false)]
        [DataRow("133", true)]
        [DataRow("0.00", false)]
        public void DefinePositiveStringNumber(string inputNumber, bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

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