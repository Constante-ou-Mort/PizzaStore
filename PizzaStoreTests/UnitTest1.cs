using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Models;
using System;
using Xunit;
using PizzaStore.Validators;

namespace PizzaStoreTests
{
    public class PizzaStoreTests
    {
        [Fact]
        public void IsAmountValid()
        {
            //arrange
            var userValidator = new UserService(new UserValidator());
            //userValidator.CreateUser("Test", -100);

            //act


            //Assert   

            Assert.Throws<ArgumentException>(() => userValidator.CreateUser("Test", -100));
        }
    }
}
