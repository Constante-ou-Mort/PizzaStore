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
            const string pizzaName = "random";
            var pizzaService = new PizzaService(new PizzaValidator());
            
            var ex = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza(pizzaName));
            Assert.That(ex.Message, Is.EqualTo($"{pizzaName} does not exist. Please choose another."));
        }

        //requires more work
        [Test]
        public void CheckPositiveAmount(int amount = 100, string name = "Svitlana")
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            var user = new User(name, amount);
            
            Assert.That(pizzaService.PayForPizza(user), Is.TypeOf<bool>());
        }

        [Test]
        public void CheckNegativeAmount(int amount = 0, string name = "Svitlana")
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            var user = new User(name, amount);
            var pizza = new Pizza();

            if (pizza.Price > user.Amount)
            {
                Assert.Throws<ArgumentException>(() => pizzaService.PayForPizza(user));
            }
        }
    }
}