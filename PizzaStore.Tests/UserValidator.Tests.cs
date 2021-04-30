using NUnit.Framework;
using PizzaStore;
using PizzaStore.Validators;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore.Tests
{
    [TestFixture]
    public class UserValidatorTests
    {        
        [Test]
        public void PositiveTestForName()
        {            
            var validator = new UserValidator();

            var result = validator.IsNameValid("Nice 01");            
            
            Assert.AreEqual(true, result);
        }

        [Test]
        public void NegativeTestForName()
        {
            var validator = new UserValidator();
            
            var result = validator.IsNameValid("¹¹!");

            Assert.AreEqual(false, result);
        }

        [Test]
        public void PositiveTestForAmount()
        {
            var validator = new UserValidator();

            var result = validator.IsAmountValid(40);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void NegativeTestForAmount()
        {
            var validator = new UserValidator();

            var result = validator.IsAmountValid(-20);

            Assert.AreEqual(false, result);
        }        
    }
}