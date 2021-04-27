using System;
using System.ComponentModel.Design;
using NUnit.Framework;
using PizzaStore.Services;
using PizzaStore.Validators;
namespace PizzaStore.Tests
{
    public class PizzaValidatorTests
    {
        [TestCase("1")]
        [TestCase("2")]
        [TestCase("3")]
        public void CheckPizzaTypesPositive(string pizza)
        {
            var pizzaValidator = new PizzaValidator();
            PizzaType PizzaType;
            
            Assert.True(pizzaValidator.IsPizzaTypeValid(pizza, out PizzaType));
        }
        
        [TestCase("0")]
        [TestCase("4")]
        public void CheckPizzaTypesNegative(string pizza)
        {
            var pizzaValidator = new PizzaValidator();
            PizzaType PizzaType;
            
            Assert.False(pizzaValidator.IsPizzaTypeValid(pizza, out PizzaType));
        }
    }
}