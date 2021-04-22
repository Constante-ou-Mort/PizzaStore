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
        public void PositivePizzaValidator()
        {
            var validator = new PizzaValidator();

            var result = validator.IsPizzaTypeValid("Neapolitan", out var pizzaType);

            Assert.IsTrue(result);
        }
    }
}
