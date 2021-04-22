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
        public void ValidatePizzaType()
        {
            var pizzaValidator = new PizzaValidator();
            var pizzaType = PizzaType.California;
            var pizza = "4";
            
            Assert.False(pizzaValidator.IsPizzaTypeValid(pizza, out pizzaType));
        }
    }
}