using System;
using System.ComponentModel.Design;
using NUnit.Framework;
using PizzaStore.Services;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class UserValidatorTests
    {
        [Test]
        public void ValidateAmount()
        {
            var userValidator = new UserValidator();
            double amount = 0;

            Assert.False(userValidator.IsAmountValid(amount));
        }

        [TestCase("Світлана")]
        [TestCase("!@#$%^&*()_-+=")]
        public void ValidateName(string name)
        {
            var userValidator = new UserValidator();
            
            Assert.False(userValidator.IsNameValid(name));
        }
    }
}