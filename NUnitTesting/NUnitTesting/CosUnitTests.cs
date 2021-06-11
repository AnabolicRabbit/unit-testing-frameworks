using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class CosUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnCosineOfDoubleNumber(
            //Arrange
            [Values(0.0, 60.00, 90.000, -60.0000)] double inputNumber,
            [Values(1.00, -0.9524129804151563, -0.4480736161291701, -0.9524129804151563)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnCosineOfIntNumber(
            //Arrange
            [Values(0, 60, 90, -60)] int inputNumber,
            [Values(1.00, -0.9524129804151563, -0.4480736161291701, -0.9524129804151563)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnCosineOfFloatNumber(
            //Arrange
            [Values(0.0f, 60.00f, 90.000f, -60.0000f)] float inputNumber,
            [Values(1.00, -0.9524129804151563, -0.4480736161291701, -0.9524129804151563)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnCosineOfStringNumber(
            //Arrange
            [Values("0", "60", "90.0", "-60.00")] string inputNumber,
            [Values(1.00, -0.9524129804151563, -0.4480736161291701, -0.9524129804151563)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Cos(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void TestClean()
        {
            calculator = null;
        }
    }
}