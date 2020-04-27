using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(1,2,3,6)]
        [InlineData(5,5,5,15)]
        [InlineData(6,15,9,30)]
        public void Add(int num1, int num2, int num3, int expected)
        {
            var test = new UnitTestMethods();
            //Arrange: prepare the code we'll need to call the Add method

            //Act
            var actual = test.Add(num1, num2, num3);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(15,5,10)]
        [InlineData(64,14,50)]
        [InlineData(50,0,50)]
        public void Subtract(int minuend, int subtrahend, int expected)
        {
            var test = new UnitTestMethods();
            //Arrange

            //Act
            var actual = test.Subtract(minuend, subtrahend);
            //Squiggly because there's not test to run? Yeah!
            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(5,5,25)]
        [InlineData(6,4,24)]
        [InlineData(15,5,75)]
        public void Multiply(int num1, int num2, int expected)
        {
            //Arrange
            var test = new UnitTestMethods();
            //Act
            var actual = test.Multiply(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData()]
        public void Divide(int num1, int num2, int expected)
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName()
        {
            //Arrange

            //Act

            //Assert

        }

        [Fact]
        public void YourMethodName2()
        {
            //Arrange

            //Act

            //Assert
        }
    }
}
