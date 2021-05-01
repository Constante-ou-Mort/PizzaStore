using NUnit.Framework;
using PizzaStore.Validators;

namespace UnitTestPizzaStore
{
    public class TestUserValidator
    {
        [Test]
        public void CheckAmountInvalid()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsAmountValid(-1);

            Assert.IsFalse(result);
        }
        [Test]
        public void CheckNameValidation()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsNameValid("Julia");

            Assert.IsTrue(result);
        }
    }
}