using FluentAssertions;
using Xunit;

namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTests
    {

        //[Fact]
        //public void Add_ShouldTakeTwoIntegers_And_ReturnAnInteger()
        //{
        //Arrange
        //    var calculator= new Calculator();

        //Act
        //    var actualResult = calculator.Add(5, 5);

        //Assert
        //    //Assert.Equal(10, actualResult);
        //    actualResult.Should().Be(10);

        //}
        [Theory]
        [InlineData(5,5,10)]
        public void Add_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber,
            
            int secondNumber,int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult = calculator.Add(firstNumber,secondNumber);
            actualResult.Should().Be(expectedResult);

        }

        [Theory]
        [InlineData(5,5,0)]
        [InlineData(10,5,5)]
        public void Subtract_ShouldTakeTwoIntegers_And_ReturnAnInteger(int firstNumber,
            int secondNumber,int expectedResult)
        {
            var calculator = new Calculator();
            var actualResult=calculator.Subtraction(firstNumber,secondNumber);
            actualResult.Should().Be(expectedResult);
        }
    }
}