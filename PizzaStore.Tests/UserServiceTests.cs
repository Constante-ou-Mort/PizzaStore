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
        
        [TearDown]
        public void TearDown()
        {
            _userService = null;
            _userService = null;
        }

        [Test]
        public void CheckValid()
        {           
             var user = _userService.CreateUser("Vasya", 15);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(user.Name == "Vasya");

                Assert.IsTrue(user.Amount == 15);
            });
        }

        [Test]
        public void CheckInvalidName()
        {
            var ex = Assert.Throws<ArgumentException>(() => _userService.CreateUser("###", 20));

            Assert.That(ex.Message, Is.EqualTo("### is invalid."));
        }

        [Test]
        public void CheckInvalidAmount()
        {
            var ex = Assert.Throws<ArgumentException>(() => _userService.CreateUser("Vasya", -20));

            Assert.That(ex.Message, Is.EqualTo("-20 is invalid."));
        }
    }
}
