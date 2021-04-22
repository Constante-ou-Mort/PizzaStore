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
            var userService = new UserService(new UserValidator());
            
            // Act
            var user = userService.CreateUser("Leonid", 100);            

            // Assert
            Assert.NotNull(user);                        
        }
    }
}
