using System;
using Xunit;

namespace xUnitTestPizzaStore
{
    public class UserValidatorTest
    {
        [Fact]
        public void NegativeNameChec()
        {
            // Arrange
            var userValidator = new PizzaStore.Validators.UserValidator();
            bool expected = false;

            // Act
            bool actualrerult = userValidator.IsNameValid("/Rom@");

            // Assert
            Assert.Equal(expected, actualrerult);
        }
        [Fact]
        public void PositivNameChec()
        {
            // Arrange
            var userValidator = new PizzaStore.Validators.UserValidator();
            bool expected = true;

            // Act
            bool actualrerult = userValidator.IsNameValid("Roman95");

            // Assert
            Assert.Equal(expected, actualrerult);
        }
        [Fact]
        public void NegativeMoneyCheck()
        {
            // Arrange
            var userValidator = new PizzaStore.Validators.UserValidator();
            // Act
            var result = userValidator.IsAmountValid(-25);
            // Assert
            Assert.False(result);

        }
        [Fact]
        public void PositiveMoneyCheck()
        {
            // Arrange
            var userValidator = new PizzaStore.Validators.UserValidator();
            // Act
            var result = userValidator.IsAmountValid(25);
            // Assert
            Assert.False(result);

        }
    }
}



