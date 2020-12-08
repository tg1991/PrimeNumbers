using PrimeNumbers.Controllers;
using System;
using Xunit;

namespace XUnitPrimeNumbers
{
    public class NumbersUnitTest
    {
        [Theory]
        [InlineData("10", "10")]
        [InlineData("4,6,8", "8,6,4")]
        [InlineData("2,3,5", "")]
        [InlineData("1,2,3,4,5,6,7,8,9,10,11", "10,9,8,6,4,1")]
        [InlineData("521,911,1373,3,1801", "")]
        [InlineData("521,911,8000,1373,3,5000,1801", "8000,5000")]
        public void RemovePrimeNumbers_SimpleScenarios_Calculated(string numbers, string expected)
        {
            var numbersController = new NumbersController();

            string result = numbersController.RemovePrimeNumbers(numbers);

            Assert.Equal(expected, result);
        }
    }
}
