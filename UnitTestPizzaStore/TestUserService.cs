using NUnit.Framework;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;

namespace UnitTestPizzaStore
{
    public class TestUserService
    {
        [Test]
        public void CheckCreateUserInvalidName()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var result = Assert.Throws<ArgumentException>(() => userService.CreateUser("87#$", 100));

            Assert.That(result.Message, Is.EqualTo("87#$ is invalid."));
        }

        [Test]
        public void CheckCreateUserNameInCyrillic()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var result = Assert.Throws<ArgumentException>(() => userService.CreateUser("Юлія", 100));

            Assert.That(result.Message, Is.EqualTo("Юлія is invalid."));
        }

        [Test]
        public void CheckCreateUserInvalidAmount()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var result = Assert.Throws<ArgumentException>(() => userService.CreateUser("Julia", -100));

            Assert.That(result.Message, Is.EqualTo("-100 is invalid."));
        }

        [Test]
        public void CheckCreateUserValid()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var result = userService.CreateUser("Julia", 100);

            Assert.Multiple(() =>
            {
                Assert.IsTrue(result.Name == "Julia");
                Assert.IsTrue(result.Amount == 100);
            });
        }
    }
}