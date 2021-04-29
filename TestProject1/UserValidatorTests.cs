using PizzaStore.Validators;
using NUnit.Framework;
using System;

namespace PizzaStoreTests
{
    public class UserValidatorTests
    {
        private UserValidator _userValidator;

        [SetUp]
        public void SetUp()
        {
            _userValidator = new UserValidator();
        }

        [Test]
        public void Positive_UserValidator_LatinName()
        {
            var name = "Mark";

            var actualResult = _userValidator.IsNameValid(name);

            Assert.IsTrue(actualResult);
        }

        [Test]
        public void Negative_UserValidator_CyrillicName()
        {
            var name = "Маша";

            var actualResult = _userValidator.IsNameValid(name);

            Assert.IsFalse(actualResult);
        }

        [Test]
        public void Negative_UserValidator_CyrillicNumbersName()
        {
            var name = "Маша123";

            var actualResult = _userValidator.IsNameValid(name);

            Assert.IsFalse(actualResult);
        }

        [Test]
        public void Negative_UserValidator_SpecialSymbolsName()
        {
            var name = "!@#$%^&*";

            var actualResult = _userValidator.IsNameValid(name);

            Assert.IsFalse(actualResult);
        }

        [Test]
        public void Positive_UserValidator_Amount()
        {
            var amount = 20;

            var actualResult = _userValidator.IsAmountValid(amount);

            Assert.IsTrue(actualResult);
        }

        [Test]
        public void Negative_UserValidator_Amount()
        {
            var amount = -20;

            var actualResult = _userValidator.IsAmountValid(amount);

            Assert.IsFalse(actualResult);
        }
    }
}