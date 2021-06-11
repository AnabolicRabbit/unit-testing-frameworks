using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class MultiplyUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnProductOfTwoDoubleNumbers(
            //Arrange
            [Values(6.0, -6.00, 0.000, 8.0000, 0.0)] double firstInputNumber,
            [Values(2.0, 1.50, 10.000, -2.0000, 0.0)] double secondInputNumber,
            [Values(12.00, -9.00, 0.00, -16.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Multiply(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnProductOfTwoIntNumbers(
            //Arrange
            [Values(5, -16, 0, 14, 0)] int firstInputNumber,
            [Values(2, 2, 12, -2, 0)] int secondInputNumber,
            [Values(10.00, -32.00, 0.00, -28.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Multiply(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnProductOfTwoFloatNumbers(
            //Arrange
            [Values(10.0f, -7.00f, 0.000f, 15.0000f, 0f)] float firstInputNumber,
            [Values(2.0f, 3.50f, 13.000f, -7.5000f, 0f)] float secondInputNumber,
            [Values(20.00, -24.50, 0.00, -112.50, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Multiply(firstInputNumber, secondInputNumber);

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