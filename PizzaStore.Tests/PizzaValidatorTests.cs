using NUnit.Framework;
using System;
using PizzaStore;
using PizzaStore.Validators;
using PizzaStore.Models;
using PizzaStore.Services;


namespace PizzaStore.Tests
{
    class PizzaValidatorTests
    {
        [Test]
        public void PositiveNeapolitanPizzaValidator()
        {
            var validator = new PizzaValidator();

            var result = validator.IsPizzaTypeValid("1", out var pizzaType);            

            Assert.AreEqual("California", pizzaType.ToString());
        }

        [Test]
        public void PositiveDetroitPizzaValidator()
        {
            var validator = new PizzaValidator();

            var result = validator.IsPizzaTypeValid("2", out var pizzaType);

            Assert.AreEqual("Detroit", pizzaType.ToString());
        }

        [Test]
        public void PositiveCaliforniaPizzaValidator()
        {
            var validator = new PizzaValidator();

            var result = validator.IsPizzaTypeValid("3", out var pizzaType);

            Assert.AreEqual("Neapolitan", pizzaType.ToString());
        }
    }
}
