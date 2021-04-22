using Xunit;
using PizzaStore.Validators;
using PizzaStore.Services;
using PizzaStore.Models;
namespace PizzaStore.Test
{
    public class UserServiceTest
    {
        [Fact]
        public void CreateUser_CreatesUserWhenNameAndAmountAreValid()
        {
            // Arrange
            var uservalidator = new UserValidator();

            // Act
            var user = new User("Leonid", 100);

            // Assert
            Assert.NotNull(user);                        
        }
    }
}