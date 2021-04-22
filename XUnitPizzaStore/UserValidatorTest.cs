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
        public void IsNameValid_KyrrilicShoudNotValidate()
        {
            // Arrange
            var userValidator = new UserValidator();
            bool expected = false;

            // Act
            bool actual = userValidator.IsNameValid("Серега");

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
