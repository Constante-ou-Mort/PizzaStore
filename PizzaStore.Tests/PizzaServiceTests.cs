using System;
using NUnit.Framework;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class PizzaServiceTests
    {
        [TestCase("1", "California")]
        [TestCase("2", "Detroit")]
        [TestCase("3", "Neapolitan")]
        [Test]
        public void TryChooseExistingPizza(string pizzaName, string pizza)
        {
            var pizzaService = new PizzaService(new PizzaValidator());

            Assert.AreEqual(pizza, pizzaService.ChoosePizza(pizzaName).Name);
        }
        
        [Test]
        public void TryChooseNonExistingPizza()
        {
            var pizzaName = "random";
            var pizzaService = new PizzaService(new PizzaValidator());
            
            var ex = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza(pizzaName));
            Assert.That(ex.Message, Is.EqualTo($"{pizzaName} does not exist. Please choose another."));
        }
    }
}