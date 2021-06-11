using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SubUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnSubtractingOfTwoDoubleNumbers(
            //Arrange
            [Values(4.0, -6.00, -15.000, 4.5000)] double firstInputNumber,
            [Values(2.0, -3.00, 1.000, 0.0000)] double secondInputNumber,
            [Values(2.00, -3.00, -16.00, 4.50)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSubtractingOfTwoIntNumbers(
            //Arrange
            [Values(13, -5, -6, 4)] int firstInputNumber,
            [Values(7, -3, 14, 0)] int secondInputNumber,
            [Values(6.00, -2.00, -20.00, 4.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSubtractingOfTwoFloatNumbers(
            //Arrange
            [Values(4.5f, -6.00f, -15.000f, 4.5000f)] float firstInputNumber,
            [Values(2.5f, -3.00f, 1.000f, 0.0000f)] float secondInputNumber,
            [Values(2.00, -3.00, -16.00, 4.50)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSubtractingOfTwoStringNumbers(
            //Arrange
            [Values("4", "-9.0", "15", "4.0")] string firstInputNumber,
            [Values("3", "-3.0", "-16.00", "0")] string secondInputNumber,
            [Values(1.00, -6.00, 31.00, 4.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sub(firstInputNumber, secondInputNumber);

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