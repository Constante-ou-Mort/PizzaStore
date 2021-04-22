using PizzaStore;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;
using Xunit;

namespace PizzaStore.Tests
{
    public class Services
    {
        [Fact]
        public void PositiveUserCheck()
        {
            var name = "mario";
            var amount = 100;

            var expectedResult = new User(name, amount);

            var actualResult = new UserService(new UserValidator()).CreateUser(name, amount);

            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void NegativeUserCheck()
        {
            var name = "   МИКОЛ@-";
            var amount = -100;

            var expectedResult = new User(name, amount);

            var actualResult = new UserService(new UserValidator()).CreateUser(name, amount);

            Assert.Equal(expectedResult, actualResult);
        }
        
             [Fact]
        public void PositiveChoosePizza()
        {
            var expectedResult = new Pizza { Price = 10, Name = nameof(PizzaType.Neapolitan) };
  
            var actualResult = new PizzaService(new PizzaValidator()).ChoosePizza("Neapolitan");

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
