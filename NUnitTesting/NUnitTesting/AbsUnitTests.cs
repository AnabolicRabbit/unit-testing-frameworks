using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class AbsUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnAbsoluteOfDoubleNumber(
            //Arrange
            [Values(1.0, -2.00, 0.000)] double inputNumber,
            [Values(1.00, 2.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnAbsoluteOfIntNumber(
            //Arrange
            [Values(7, -19, 0)] int inputNumber,
            [Values(7.00, 19.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnAbsoluteOfFloatNumber(
            //Arrange
            [Values(12.0f, -19f, 0f)] float inputNumber,
            [Values(12.00, 19.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnAbsoluteOfStringNumber(
            //Arrange
            [Values("5", "-5.0", "5.00")] string inputNumber,
            [Values(5.00, 5.00, 5.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Abs(inputNumber);

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