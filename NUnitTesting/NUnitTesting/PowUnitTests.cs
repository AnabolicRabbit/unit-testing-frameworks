using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class PowUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnValueOfPowerForTwoDoubleNumbers(
            //Arrange
            [Values(4.0, -2.00, 0.000, 5.0000, 10.0, 4.00, 0.000)] double firstInputNumber,
            [Values(2.0, 3.00, 5.000, 0.0000, -1.0, 0.50, 0.000)] double secondInputNumber,
            [Values(16.00, -8.00, 0.00, 1.00, 0.10, 2.00, 1.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnValueOfPowerForTwoIntNumbers(
            //Arrange
            [Values(4, -2, 0, 5, 10, 0)] int firstInputNumber,
            [Values(2, 3, 5, 0, -1, 0)] int secondInputNumber,
            [Values(16.00, -8.00, 0.00, 1.00, 0.10, 1.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnValueOfPowerForTwoFloatNumbers(
            //Arrange
            [Values(4.0f, -2.00f, 0.000f, 5.0000f, 10.0f, 4.00f, 0.000f)] float firstInputNumber,
            [Values(2.0f, 3.00f, 5.000f, 0.0000f, -1.0f, 0.50f, 0.000f)] float secondInputNumber,
            [Values(16.00, -8.00, 0.00, 1.00, 0.10, 2.00, 1.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnValueOfPowerForTwoStringNumbers(
            //Arrange
            [Values("4", "-2.00", "0", "5.0000", "10.0", "4.00", "0.000")] string firstInputNumber,
            [Values("2", "3.00", "5.000", "0", "-1.0", "0.50", "0.000")] string secondInputNumber,
            [Values(16.00, -8.00, 0.00, 1.00, 0.10, 2.00, 1.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Pow(firstInputNumber, secondInputNumber);

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