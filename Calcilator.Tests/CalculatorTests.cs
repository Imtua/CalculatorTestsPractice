using NUnit.Framework;
using CalculatorTestsPractice;

namespace Calcilator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void Addition_MustReturnTrueAndFalse()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Addition(5, 5) == 10);
            Assert.False(calculator.Addition(82, 1) == 85);
        }

        [Test]
        public void Addition_MustReturnNotNull()
        {
            var calculator = new Calculator();
            Assert.NotNull(calculator.Addition(5, 14));
        }

        [Test]
        public void Subtraction_MustReturnTrueAndFalse()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Subtraction(11, 10) == 1);
            Assert.False(calculator.Subtraction(30, 20) == 15);
        }

        [Test]
        public void Subtraction_MustReturnNotNull()
        {
            var calculator = new Calculator();
            Assert.NotNull(calculator.Subtraction(13, 13));
        }

        [Test]
        public void Multiplication_MustReturnTrueAndFalse()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Multiplication(1, 5) == 5);
            Assert.False(calculator.Multiplication(1, 5) == 4);
        }

        [Test]
        public void Multiplication_MustReturnNotNull()
        {
            var calculator = new Calculator();
            Assert.NotNull(calculator.Multiplication(6, 6));
        }

        [Test]
        public void Division_MustReturnTrueAndFalse()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(20, 2) == 10);
            Assert.False(calculator.Division(14, 7) == 1);
        }

        [Test]
        public void Division_MustReturnNotNull()
        {
            var calculator = new Calculator();
            Assert.NotNull(calculator.Multiplication(7, 1));
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException> (() => calculator.Division(7, 0));
        }
    }
}