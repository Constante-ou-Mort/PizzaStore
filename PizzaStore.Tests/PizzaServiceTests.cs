using System;
using System.Collections.Generic;
using NUnit.Framework;
using System;
using PizzaStore;
using PizzaStore.Validators;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore.Tests
{
    class PizzaServiceTests
    {
        [Test]
        public void CaliforniaPizzaTest()
        {
            var validator = new PizzaValidator();
            var pizzaToBake = new PizzaService(validator).ChoosePizza("1");

            Pizza result = new Pizza { Price = 8, Name = nameof(PizzaType.California) };            

            Assert.Multiple(() =>
            {
                Assert.AreEqual(result.Name, pizzaToBake.Name);
                Assert.AreEqual(result.Price, pizzaToBake.Price);
            });
        }

        [Test]
        public void DetroitPizzaTest()
        {
            var validator = new PizzaValidator();
            var pizzaToBake = new PizzaService(validator).ChoosePizza("2");

            Pizza result = new Pizza { Price = 10, Name = nameof(PizzaType.Detroit) };

            Assert.Multiple(() =>
            {
                Assert.AreEqual(result.Name, pizzaToBake.Name);
                Assert.AreEqual(result.Price, pizzaToBake.Price);
            });
        }

        [Test]
        public void NeapolitanPizzaTest()
        {
            var validator = new PizzaValidator();
            var pizzaToBake = new PizzaService(validator).ChoosePizza("3");

            Pizza result = new Pizza { Price = 12, Name = nameof(PizzaType.Neapolitan) };

            Assert.Multiple(() =>
            {
                Assert.AreEqual(result.Name, pizzaToBake.Name);
                Assert.AreEqual(result.Price, pizzaToBake.Price);
            });
        }

        [Test]
        public void PayForPizzaTest (string name = "vasiliy", double amount = 50)
        {
            var validator = new PizzaValidator();
            var pizzaService = new PizzaService(validator);
            var user = new User(name, amount);

            pizzaService.ChoosePizza("0");
            var result = user.Amount - 8;

            pizzaService.PayForPizza(user);

            Assert.AreEqual(result, user.Amount);
        }    
    }
}
