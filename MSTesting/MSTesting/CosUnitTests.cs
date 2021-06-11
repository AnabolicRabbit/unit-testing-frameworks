using CSharpCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting
{
    [TestClass]
    public class CosUnitTests
    {
        Calculator calculator;

        [TestInitialize]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [TestMethod]
        //Arrange
        [DataRow(0.0, 1.00)]
        [DataRow(60.00, -0.9524129804151563)]
        [DataRow(90.000, -0.4480736161291701)]
        [DataRow(-60.0000, -0.9524129804151563)]
        public void ReturnCosineOfDoubleNumber(double inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(0, 1.00)]
        [DataRow(60, -0.9524129804151563)]
        [DataRow(90, -0.4480736161291701)]
        [DataRow(-60, -0.9524129804151563)]
        public void ReturnCosineOfIntNumber(int inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow(0.0f, 1.00)]
        [DataRow(60.00f, -0.9524129804151563)]
        [DataRow(90.000f, -0.4480736161291701)]
        [DataRow(-60.0000f, -0.9524129804151563)]
        public void ReturnCosineOfFloatNumber(float inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        //Arrange
        [DataRow("0", 1.00)]
        [DataRow("60", -0.9524129804151563)]
        [DataRow("90.0", -0.4480736161291701)]
        [DataRow("-60.00", -0.9524129804151563)]
        public void ReturnCosineOfStringNumber(string inputNumber, double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

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