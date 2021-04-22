using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;
using Xunit;

namespace PizzaStore.Tests
{
    public class Validators
    {
        [Fact]
        public void PositivNameCheck()
        {
            var expectedResult = true;

            var actualResult = new UserValidator().IsNameValid("Mario");

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void NegativeNameCheck()
        {
            var expectedResult = false;

            var actualResult = new UserValidator().IsNameValid("|V| è |< 0 ë @");

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void PositiveMoneyCheck()
        {
            var expectedResult = true;

            var actualResult = new UserValidator().IsAmountValid(300);

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void NegativeMoneyCheck()
        {
            var expectedResult = false;

            var actualResult = new UserValidator().IsAmountValid(-2);

            Assert.Equal(expectedResult, actualResult);
        }

    }
}
