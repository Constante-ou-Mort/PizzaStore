using System;
using System.Collections.Generic;
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
            var pizzaService = new PizzaService(new PizzaValidator());
            var userPizza = pizzaService.ChoosePizza("1");

            var expectedPizza = new Pizza { Price = 10, Name = nameof(PizzaType.Neapolitan) };

            Assert.AreEqual(expectedPizza.Name, userPizza.Name);
        }
        
        [Test]
        public void TryBakePizza()
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            var pizza = pizzaService.ChoosePizza("California");

            pizzaService.CreatePizza(pizza);

            Assert.True(pizza.IsBaked);
        }
        
        [Test]
        public void TryChooseNonExistingPizza()
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            const string pizzaName = "random";
            
            var ex = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza(pizzaName));
            Assert.That(ex.Message, Is.EqualTo($"{pizzaName} does not exist. Please choose another."));
        }

        [Test]
        public void CheckPositiveAmount(double amount = 100, string name = "Svitlana")
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            var richUser = new User(name, amount);
            
            pizzaService.ChoosePizza("California");
            var newAmount = richUser.Amount - 8;

            pizzaService.PayForPizza(richUser);

            Assert.AreEqual(newAmount, richUser.Amount);
        }

        [Test]
        public void CheckNegativeAmount(double amount = 1, string name = "Svitlana")
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            var poorUser = new User(name, amount);

            pizzaService.ChoosePizza("California");
            
            var ex = Assert.Throws<ArgumentException>(() => pizzaService.PayForPizza(poorUser));
            Assert.That(ex.Message, Is.EqualTo("You do not have enough funds to buy that pizza."));
        }
        
        [Test]
        public void BakeCalifornia()
        {
            var pizzaService = new PizzaService(new PizzaValidator());
            var california1 = pizzaService.ChoosePizza("California");
            var california = PizzaIngredientsService.GetIngredientsByPizzaType(california1.Type);

            List<string> californiaIngridients = new List<string>() { "Honey", "Olive oil","Flour","Salt","Red onion","Black olives","Mushrooms" };

            Assert.AreEqual(californiaIngridients, california);
        }
    }
}