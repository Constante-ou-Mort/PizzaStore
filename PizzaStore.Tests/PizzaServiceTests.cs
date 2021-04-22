using System;
using NUnit.Framework;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class PizzaServiceTests
    {
        [Test]
        public void TryChooseExistingPizza()
        {
            var pizzaName = "1";
            var pizzaService = new PizzaService(new PizzaValidator());
            var pizza = new Pizza {Price = 10, Name = nameof(PizzaType.Neapolitan)};

            Assert.AreEqual(pizza, pizzaService.ChoosePizza(pizzaName));
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