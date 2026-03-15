using calculatorUi;  // reference your main project
using System;        // for exceptions
using Xunit;         // xUnit attributes & assertions

namespace calculatorTest
{
    public class UnitTest1
    {
        private Calculator calculator = new Calculator();

        [Fact]
        public void Add_TwoNumbers_ReturnsSum()
        {
            double result = calculator.Add(5, 3);
            Assert.Equal(8, result);
        }

        [Fact]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            double result = calculator.Subtract(10, 4);
            Assert.Equal(6, result);
        }

        [Fact]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            double result = calculator.Multiply(6, 7);
            Assert.Equal(42, result);
        }

        [Fact]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            double result = calculator.Divide(20, 4);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
