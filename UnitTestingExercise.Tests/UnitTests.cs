using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(3, 6, 9, 18)]
        [InlineData(4, 8, 12, 24)]
        [InlineData(5, 10, 15, 30)]
        [InlineData(6, 12, 18, 36)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            Calculator c = new Calculator();

            //Act
            // call the Add method that is located in the Calculator class
            // and store its result in a variable named actual
            var actual = c.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(23, 16, 7)]//Add test data <-------
        [InlineData(10, 10, 0)]
        [InlineData(15, 42, -27)]
        [InlineData(-3, -6, 3)]
        [InlineData(6, -50, 56)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator c = new Calculator();

            //Act
            var actual = c.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(1, 1, 1)]//Add test data <-------
        [InlineData(2, 2, 4)]
        [InlineData(6, 8, 48)]
        [InlineData(10, 100, 1000)]
        [InlineData(23, 32, 736)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator c = new Calculator();

            //Act
            var actual = c.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0, 1, 0)]//Add test data <-------
        [InlineData(25, 5, 5)]
        [InlineData(64, 2, 32)]
        [InlineData(12, 5, 2)]
        [InlineData(6, 6, 1)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            Calculator c = new Calculator();

            //Act
            var actual = c.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
