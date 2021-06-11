using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class AddUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnSumOfTwoDoubleNumbers(
            //Arrange
            [Values(2.0, -3.00, 15.000, 4.5000)] double firstInputNumber,
            [Values(2.0, -3.00, -16.000, 0.0000)] double secondInputNumber,
            [Values(4.00, -6.00, -1.00, 4.50)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSumOfTwoIntNumbers(
            //Arrange
            [Values(6, -2, 14, 4)] int firstInputNumber,
            [Values(7, -3, -20, 0)] int secondInputNumber,
            [Values(13.00, -5.00, -6.00, 4.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSumOfTwoFloatNumbers(
            //Arrange
            [Values(3.0f, -3.00f, 11.000f, 8.0000f)] float firstInputNumber,
            [Values(3.0f, -3.00f, -14.000f, 0.0000f)] float secondInputNumber,
            [Values(6.00, -6.00, -3.00, 8.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSumOfTwoStringNumbers(
            //Arrange
            [Values("4", "-9.0", "15", "4.0")] string firstInputNumber,
            [Values("3", "-3.0", "-16.00", "0")] string secondInputNumber,
            [Values(7.00, -12.00, -1.00, 4.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Add(firstInputNumber, secondInputNumber);

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