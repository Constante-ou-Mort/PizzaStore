using NUnit.Framework;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;
using System.Collections.Generic;
using System.IO;

namespace PizzaStore.Tests
{
    public class PizzaServiceTests
    {
        private PizzaService pizzaService;
        private User user1;

        [SetUp]
        public void Setup()
        {
            pizzaService = new PizzaService(new PizzaValidator());
            user1 = new User("Kate", 20);
        }

        [Test]
        public void ChoosingPizza()
        {
            var neapolitan = pizzaService.ChoosePizza("Neapolitan");
            var detroit = pizzaService.ChoosePizza("Detroit");
            var california = pizzaService.ChoosePizza("California");

            var invalidPizzaException = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza("neapolitan"));

            Assert.Multiple(() =>
            {
                Assert.AreEqual("Neapolitan", neapolitan.Name);
                Assert.AreEqual("Detroit", detroit.Name);
                Assert.AreEqual("California", california.Name);
                Assert.That(invalidPizzaException.Message, Is.EqualTo("neapolitan does not exist. Please choose another."));
            });
        }

        [Test]
        public void PayForPizza_Success()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            pizzaService.ChoosePizza("Neapolitan");

            var result1 = pizzaService.PayForPizza(user1);
            var amount1 = user1.Amount;
           
            Assert.Multiple(() =>
            {
                Assert.IsTrue(result1);
                Assert.AreEqual(8, amount1);
                Assert.That(output.ToString(), Is.EqualTo("You paid was successful. Pizza price 12, you current amount 8\r\n"));
            });
        }

        [Test]
        public void PayForPizza_Failed()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var pizzaService2 = new PizzaService(new PizzaValidator());
            var user2 = new User("Kate", 10);

            pizzaService2.ChoosePizza("Neapolitan");

            var result2 = pizzaService2.PayForPizza(user2);

            Assert.Multiple(() =>
            {
                Assert.IsFalse(result2);
                Assert.That(output.ToString(), Is.EqualTo("You don't have anough money. Pizza price 12, your amount 10\r\n"));
            });
        }

        [Test]
        public void CreatePizzaNeapolitan()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var pizza = pizzaService.ChoosePizza("Neapolitan");

            pizzaService.CreatePizza(pizza);

            var ingridients = new List<string>() { "Flour", "Mozzarella", "Tomato", "Tomato sauce", "Basil", "Yeast", "Olive oil" };

            Assert.Multiple(() =>
            {
                Assert.AreEqual(ingridients, pizza.Ingredients);
                Assert.IsTrue(pizza.IsBaked);
                Assert.That(output.ToString(), Is.EqualTo("....................................................................................................\nYour pizza Neapolitan is ready.\r\n"));
            });
        }

        [Test]
        public void CreatePizzaDetroit()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var pizza2 = pizzaService.ChoosePizza("Detroit");

            pizzaService.CreatePizza(pizza2);

            var ingridients2 = new List<string>() { "White sugar", "Olive oil", "Bread flour", "Kosher salt", "Red onion", "Garlic", "Mushrooms" };

            Assert.Multiple(() =>
            {
                Assert.AreEqual(ingridients2, pizza2.Ingredients);
                Assert.IsTrue(pizza2.IsBaked);
                Assert.That(output.ToString(), Is.EqualTo("....................................................................................................\nYour pizza Detroit is ready.\r\n"));
            });
        }

        [Test]
        public void CreatePizzaCalifornia()
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var pizza2 = pizzaService.ChoosePizza("California");

            pizzaService.CreatePizza(pizza2);

            var ingridients2 = new List<string>() { "Honey", "Olive oil", "Flour", "Salt", "Red onion", "Black olives", "Mushrooms" };

            Assert.Multiple(() =>
            {
                Assert.AreEqual(ingridients2, pizza2.Ingredients);
                Assert.IsTrue(pizza2.IsBaked);
                Assert.That(output.ToString(), Is.EqualTo("....................................................................................................\nYour pizza California is ready.\r\n"));
            });
        }
    }
}