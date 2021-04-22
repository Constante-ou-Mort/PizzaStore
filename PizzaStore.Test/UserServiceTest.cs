using Xunit;
using PizzaStore.Validators;
using PizzaStore.Services;
using PizzaStore.Models;
using System;

namespace PizzaStore.Test
{
    public class UserServiceTest
    {
        [Fact]
        public void CreateUser_CreatesUserWhenNameAndAmountAreValid()
        {
            // Arrange
            var userService = new UserService(new UserValidator());
            
            // Act
            var user = userService.CreateUser("Leonid", 100);            

            // Assert
            Assert.NotNull(user);                        
        }

        [Fact]
        public void CreateUser_CorrectExceptionMessageWithValidNameAndNotValidAmount()
        {
            // Arrange
            var userService = new UserService(new UserValidator());
            var expectedMessage = "-1 is invalid.";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => userService.CreateUser("Lenid", -1));

            // Assert
            Assert.Equal(expectedMessage, exception.Message);
        }

        [Fact]
        public void CreateUser_CorrectExceptionMessageWithNotValidNameAndValidAmount()
        {
            // Arrange
            var userService = new UserService(new UserValidator());
            var expectedMessage = "Вергилий is invalid.";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => userService.CreateUser("Вергилий", 100));

            // Assert
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}
