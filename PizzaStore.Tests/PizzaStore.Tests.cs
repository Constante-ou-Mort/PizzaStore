using NUnit.Framework;
using PizzaStore;
using PizzaStore.Validators;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore.Tests
{
    [TestFixture]
    public class Tests
    {        
        [Test]
        public void PositiveTestForNameValidator()
        {            
            var validator = new UserValidator();

            var result = validator.IsNameValid("Nice 01");            
            
            Assert.AreEqual(true, result);
        }

        [Test]
        public void NegativeTestForNameValidator()
        {
            var validator = new UserValidator();

            var result = validator.IsNameValid("Nice01 ###");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void PositiveTestForAmountValidatior()
        {
            var validator = new UserValidator();

            var result = validator.IsAmountValid(40);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void NegativeTestForAmountValidatior()
        {
            var validator = new UserValidator();

            var result = validator.IsAmountValid(-20);

            Assert.AreEqual(false, result);
        }
    }
}