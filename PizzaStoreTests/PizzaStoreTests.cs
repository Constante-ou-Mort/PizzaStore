using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Models;
using System;
using Xunit;
using PizzaStore.Validators;
using System.Security.Authentication;

namespace PizzaStoreTests
{
    public class PizzaStoreTests
    {
        [Fact]
        public void IsAmountValid()
        {
            //arrange
            var userService = new UserService(new UserValidator());      

            //Act & Assert 
            Assert.Throws<ArgumentException>(() => userService.CreateUser("Test", -100));
        }

        [Fact]
        public void MessageForIsAmountValid()
        {
            //arrange
            var userService = new UserService(new UserValidator());

            //Act & Assert 
            var exception = Assert.Throws<ArgumentException>(() => userService.CreateUser("Test", -100));
            var message = "-100 is invalid.";
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void IsNameValid()
        {
            //arrange
            var userService = new UserService(new UserValidator());   

            //Act & Assert   
            Assert.Throws<ArgumentException>(() => userService.CreateUser("тест", 100)); 
        }

        [Fact]
        public void MessageForIsNameValid()
        {
            //arrange
            var userService = new UserService(new UserValidator());

            //Act & Assert             
            var exception = Assert.Throws<ArgumentException>(() => userService.CreateUser("тест", 100));
            var message = "тест is invalid.";
            Assert.Equal(message, exception.Message);
        }

        [Fact]
        public void ChoosePizza()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act & Assert             
            var exception = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza("тест"));
            var message = "тест does not exist. Please choose another.";
            Assert.Equal(message, exception.Message);
        }
    }
}
