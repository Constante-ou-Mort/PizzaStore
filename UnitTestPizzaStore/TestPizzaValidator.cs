using NUnit.Framework;
using PizzaStore.Validators;

namespace UnitTestPizzaStore
{
    public class TestPizzaValidator
    {
        [Test]
        public void CheckPizzaValidator()
        {
            var pizzaValidator = new PizzaValidator();

            var result = pizzaValidator.IsPizzaTypeValid("California", out var pizzaType);

            Assert.IsTrue(result);
        }
        [Test]
        public void CheckPizzaValidatorInvalid()
        {
            var pizzaValidator = new PizzaValidator();

            var result = pizzaValidator.IsPizzaTypeValid("Gavai", out var pizzaType);

            Assert.IsFalse(result);
        }
    }
}