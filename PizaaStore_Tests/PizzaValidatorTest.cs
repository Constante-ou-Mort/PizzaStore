using NUnit.Framework;
using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Validators;


namespace PizaaStore_Tests
{
    public class PizzaValidatorTests
    {
        [Test]
        public void PositivePizzaValidatorNeapolitan()
        {
            // Arrange
            var validator = new PizzaValidator();
            // Act
            validator.IsPizzaTypeValid("1", out var pizzaType);
            // Assert
            Assert.AreEqual("Neapolitan", pizzaType);
        }
        [Test]
        public void PositivePizzaValidatorCalifornia()
        {
            var validator = new PizzaValidator();

            var result = validator.IsPizzaTypeValid("3", out var pizzaType);

            Assert.AreEqual("California", pizzaType);
        }
    }
}
