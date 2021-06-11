using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class DivideUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnDivisionOfTwoDoubleNumbers(
            //Arrange
            [Values(6.0, -6.00, 0.000, 8.0000)] double firstInputNumber,
            [Values(2.0, 1.50, 10.000, -2.0000)] double secondInputNumber,
            [Values(3.00, -4.00, 0.00, -4.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnDivisionOfTwoIntNumbers(
            //Arrange
            [Values(5, -16, 0, 14)] int firstInputNumber,
            [Values(2, 2, 12, -2)] int secondInputNumber,
            [Values(2.50, -8.00, 0.00, -7.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnDivisionOfTwoFloatNumbers(
            //Arrange
            [Values(10.0f, -7.00f, 0.000f, 15.0000f)] float firstInputNumber,
            [Values(2.0f, 3.50f, 13.000f, -7.5000f)] float secondInputNumber,
            [Values(5.00, -2.00, 0.00, -2.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Arrange
        [TestCase(4, 0, "∞")]
        public void ReturnDivideByZeroException(int firstInputNumber, int secondInputNumber, string expectedResult)
        {
            //Act
            double actualResult = calculator.Divide(firstInputNumber, secondInputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult.ToString());
        }

        [TearDown]
        public void TestClean()
        {
            calculator = null;
        }
    }
}