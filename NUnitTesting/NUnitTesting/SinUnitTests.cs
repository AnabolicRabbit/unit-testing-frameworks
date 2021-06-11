using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SinUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnSinusOfDoubleNumber(
            //Arrange
            [Values(0.0, 30.00, -30.000)] double inputNumber,
            [Values(0.00, -0.9880316240928618, 0.9880316240928618)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSinusOfIntNumber(
            //Arrange
            [Values(0, 30, -30)] int inputNumber,
            [Values(0.00, -0.9880316240928618, 0.9880316240928618)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSinusOfFloatNumber(
            //Arrange
            [Values(0.0f, 30.00f, -30.000f)] float inputNumber,
            [Values(0.00, -0.9880316240928618, 0.9880316240928618)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSinusOfStringNumber(
            //Arrange
            [Values("0.0", "30.00", "-30.000")] string inputNumber,
            [Values(0.00, -0.9880316240928618, 0.9880316240928618)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sin(inputNumber);

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