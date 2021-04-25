using NUnit.Framework;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;

namespace PizzaStore.Tests
{
    public class UserServiceTests
    {
        private UserService userService;

        [SetUp]
        public void Setup()
        {
            userService = new UserService(new UserValidator());
        }
        
        [Test]
        public void CreateUser_ThrowsExceptions()
        {
            var invalidName = Assert.Throws<ArgumentException>(() => userService.CreateUser("@#$$@!", 123));
            var invalidAmount = Assert.Throws<ArgumentException>(() => userService.CreateUser("Kate", -434));
            
            Assert.Multiple(() =>
            {
                Assert.That(invalidName.Message, Is.EqualTo("@#$$@! is invalid."));
                Assert.That(invalidAmount.Message, Is.EqualTo("-434 is invalid."));
            });
        }
    }
}