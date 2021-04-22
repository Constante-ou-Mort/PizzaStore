using System;
using System.ComponentModel.Design;
using NUnit.Framework;
using PizzaStore.Services;
using PizzaStore.Validators;
namespace PizzaStore.Tests
{
    public class PizzaValidatorTests
    {
        [Test]
        public void CheckExistingPizzaType()
        {
            var pizzaValidator = new PizzaValidator();
            var pizzaType = PizzaType.Neapolitan;
            var pizza = "1";
            
            Assert.True(pizzaValidator.IsPizzaTypeValid(pizza, out pizzaType));
        }
    }
}