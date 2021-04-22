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
        public void CheckPositiveAmount()
        {
            var userValidator = new UserValidator();
            double amount = 1;

            Assert.True(userValidator.IsAmountValid(amount));
        }
        
        [TestCase(-1)]
        [TestCase(0)]
        public void CheckNegativeAmount(double amount)
        {
            var userValidator = new UserValidator();

            Assert.False(userValidator.IsAmountValid(amount));
        }

        [TestCase("Svitlana")]
        [TestCase("123456")]
        [TestCase("Svitlana123")]
        public void CheckPositiveName(string name)
        {
            var userValidator = new UserValidator();
            
            Assert.True(userValidator.IsNameValid(name));
        }
        
        [TestCase("Світлана")]
        [TestCase("!@#$%^&*()_-+=")]
        public void CheckNegativeName(string name)
        {
            var userValidator = new UserValidator();
            
            Assert.False(userValidator.IsNameValid(name));
        }
    }
}