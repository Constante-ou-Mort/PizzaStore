using NUnit.Framework;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;

namespace NUnitTestProject1
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var ex = Assert.Throws<ArgumentException>(() => userService.CreateUser("87#$", 100));

            Assert.That(ex.Message, Is.EqualTo("87#$ is invalid."));                       
        }
    }
}