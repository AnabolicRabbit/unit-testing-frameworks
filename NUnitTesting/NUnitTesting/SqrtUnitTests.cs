using NUnit.Framework;
using CSharpCalculator;

namespace NUnitTesting
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class SqrtUnitTests
    {
        Calculator calculator;

        [SetUp]
        public void TestInit()
        {
            calculator = new Calculator();
        }

        [Test, Sequential]
        public void ReturnSquareRootOfDoubleNumber(
            //Arrange
            [Values(4.0, 0.00)] double inputNumber,
            [Values(2.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSquareRootOfIntNumber(
            //Arrange
            [Values(4, 0)] int inputNumber,
            [Values(2.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSquareRootOfFloatNumber(
            //Arrange
            [Values(4.0f, 0.00f)] float inputNumber,
            [Values(2.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test, Sequential]
        public void ReturnSquareRootOfStringNumber(
            //Arrange
            [Values("4.0", "16", "0")] string inputNumber,
            [Values(2.00, 4.00, 0.00)] double expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        //Arrange
        [TestCase(-4.00, "NaN")]
        public void ReturnSquareRootOfNegativeNumber(double inputNumber, string expectedResult)
        {
            //Act
            double actualResult = calculator.Sqrt(inputNumber);

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