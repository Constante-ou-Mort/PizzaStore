using PizzaStore.Validators;
using Xunit;

namespace PizzaStore.Test
{
    public class UserValidatorTest
    {    
        [Fact]
        public void IsNameValid_LatinAndNumbersShoudValidate()
        {
            // Arrange
            var userValidator = new UserValidator();
            bool expected = true;

            // Act
            bool actual = userValidator.IsNameValid("Petya123");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsNameValid_KyrilicShoudNotValidate()
        {
            // Arrange
            var userValidator = new UserValidator();
            bool expected = false;

            // Act
            bool actual = userValidator.IsNameValid("Серега");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsAmountValid_MoreThanZeroValidate()
        {
            // Arrange
            var userValidator = new UserValidator();
            bool expected = true;

            // Act
            bool actual = userValidator.IsAmountValid(1.0);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsAmountValid_LessThanZeroNotValidate()
        {
            // Arrange
            var userValidator = new UserValidator();
            bool expected = false;

            // Act
            bool actual = userValidator.IsAmountValid(-1);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsAmountValid_ZeroNotValidate()
        {
            // Arrange
            var userValidator = new UserValidator();
            bool expected = false;

            // Act
            bool actual = userValidator.IsAmountValid(0);

            // Assert
            Assert.Equal(expected, actual);
        }


    }
}
