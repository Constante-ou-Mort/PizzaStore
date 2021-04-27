using NUnit.Framework;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class PizzaValiddatorTests
    {
        private PizzaValidator pizzaValidator;

        [SetUp]
        public void Setup()
        {
            pizzaValidator = new PizzaValidator();
        }
        [Test]
        public void UserValiddator_Valid()
        {
            var result1 = pizzaValidator.IsPizzaTypeValid("Detroit", out PizzaType pizzaType1);

            Assert.Multiple(() =>
            {
                Assert.True(result1);
                Assert.AreEqual(PizzaType.Detroit, pizzaType1);
            });
        }

        [Test]
        public void UserValiddator_Invalid()
        {
        var result2 = pizzaValidator.IsPizzaTypeValid("Margarita", out PizzaType pizzaType2);

        Assert.Multiple(() =>
            {
                Assert.False(result2);
                Assert.IsNull(pizzaType2);
            });
        }
    }
}