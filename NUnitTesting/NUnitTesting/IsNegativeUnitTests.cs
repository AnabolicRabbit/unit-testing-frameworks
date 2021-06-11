using NUnit.Framework;
using CSharpCalculator;

[assembly: LevelOfParallelism(2)]
namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class IsNegativeUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void DefineNegativeDoubleNumber(
            //Arrange
            [Values(-50.0, 40.00, 0.000)] double inputNumber,
            [Values(true, false, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void DefineNegativeIntNumber(
            //Arrange
            [Values(-26, 16, 0)] int inputNumber,
            [Values(true, false, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void DefineNegativeFloatNumber(
            //Arrange
            [Values(-15.7f, 18f, 0f)] float inputNumber,
            [Values(true, false, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void DefineNegativeStringNumber(
            //Arrange
            [Values("-11", "13.0", "0")] string inputNumber,
            [Values(true, false, false)] bool expectedResult)
        {
            //Act
            bool actualResult = calculator.isNegative(inputNumber);

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