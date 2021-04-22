using NUnit.Framework;
using System;
using PizzaStore;
using PizzaStore.Validators;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore.Tests
{
    class UserServiceTests
    {

        public static UserValidator _userValidator;
        public static UserService _userService;

        [SetUp]
        public void SetUp()
        {
            _userValidator = new UserValidator();
            _userService = new UserService(_userValidator);   
        } 

        [Test]
        public void checkValid()
        {
            

            var user = _userService.CreateUser("Vasya", 15);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(user.Name == "Vasya");

                Assert.IsTrue(user.Amount == 15);
            });
        }

        
    }
}
