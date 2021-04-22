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

        [Test]
        public void ValidateName()
        {
            var userValidator = new UserValidator();
            var name1 = "Світлана";
            var name2 = "!@#$%^&*()_-+=";
            
            Assert.Multiple(() =>
            {
                Assert.False(userValidator.IsNameValid(name1));
                Assert.False(userValidator.IsNameValid(name2));
            });
        }
    }
}