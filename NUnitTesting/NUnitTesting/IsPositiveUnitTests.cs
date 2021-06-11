using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class IsPositiveUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void DefinePositiveDoubleNumber(
            ////Arrange
            [Values(-50.5, 40.00, 0.000)] double inputNumber,
            [Values(false, true, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void DefinePositiveIntNumber(
            //Arrange
            [Values(-10, 15, 0)] int inputNumber,
            [Values(false, true, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void DefinePositiveFloatNumber(
            //Arrange
            [Values(-19.9f, 18.3f, 0f)] float inputNumber,
            [Values(false, true, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void DefinePositiveStringNumber(
            //Arrange
            [Values("-15.5", "133", "0.00")] string inputNumber,
            [Values(false, true, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isPositive(inputNumber);

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