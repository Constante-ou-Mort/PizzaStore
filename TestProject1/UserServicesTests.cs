using NUnit.Framework;
using System;
using PizzaStore.Services;
using PizzaStore.Models;
using PizzaStore;
using PizzaStore.Validators;

namespace PizzaStoreTests
{
    class UserServicesTests
    {
        private UserService _userService;

        [Test]
        public void CreateUser_ExceptionWithInvalidName()
        {
            _userService = new UserService(new UserValidator());
            var expectedResult = Assert.Throws<ArgumentException>(() => _userService.CreateUser("!@#!", 20));
            Assert.That(expectedResult.Message, Is.EqualTo("!@#! is invalid."));
        }

        [Test]
        public void CreateUser_ExceptionWithInvalidAmount()
        {
            _userService = new UserService(new UserValidator());
            var expectedResult = Assert.Throws<ArgumentException>(() => _userService.CreateUser("Masha", -123));
            Assert.That(expectedResult.Message, Is.EqualTo("-123 is invalid."));
        }
    }
}
