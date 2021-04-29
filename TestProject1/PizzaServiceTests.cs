using NUnit.Framework;
using System;
using PizzaStore.Services;
using PizzaStore.Models;
using PizzaStore;
using PizzaStore.Validators;

namespace PizzaStoreTests
{
    class PizzaServiceTests
    {
        private PizzaService _pizzaService;
        private Pizza _pizza;

        [SetUp]
        public void SetUp()
        {
            _pizzaService = new PizzaService(new PizzaValidator());
            _pizza = new Pizza();
        }

        [Test]
        public void ChoosePizza_Input2_ReturnDetroit()
        {
            var actualResult = _pizzaService.ChoosePizza("2");

            var expectedResult = new Pizza { Price = 8, Name = nameof(PizzaType.Detroit) };

            Assert.AreEqual(expectedResult.Name, actualResult.Name);
        }

        [Test]
        public void ChoosePizza_InputDetroit_ReturnDetroit()
        {
            var actualResult = _pizzaService.ChoosePizza("detroit");

            var expectedResult = new Pizza { Price = 8, Name = nameof(PizzaType.Detroit) };

            Assert.AreEqual(expectedResult.Name, actualResult.Name);
        }

        [Test]
        public void ChoosePizza_InputCalifornia_ReturnCalifornia()
        {
            var actualResult = _pizzaService.ChoosePizza("california");

            var expectedResult = new Pizza { Price = 10, Name = nameof(PizzaType.Detroit) };

            Assert.AreEqual(expectedResult.Name, actualResult.Name);
        }

        [Test]
        public void ChoosePizza_InputNeapolitan_ReturnNeapolitan()
        {
            var actualResult = _pizzaService.ChoosePizza("neapolitan");

            var expectedResult = new Pizza { Price = 12, Name = nameof(PizzaType.Neapolitan) };

            Assert.AreEqual(expectedResult.Name, actualResult.Name);
        }

        [Test]
        public void ChoosePizza_Input1_ReturnCalifornia()
        {
            var actualResult = _pizzaService.ChoosePizza("1");

            var expectedResult = new Pizza { Price = 8, Name = nameof(PizzaType.California) };

            Assert.AreEqual(expectedResult.Name, actualResult.Name);
        }

        [Test]
        public void ChoosePizza_Input3_ReturnNeapolitan()
        {
            var actualResult = _pizzaService.ChoosePizza("3");

            var expectedResult = new Pizza { Price = 8, Name = nameof(PizzaType.Neapolitan) };

            Assert.AreEqual(expectedResult.Name, actualResult.Name);
        }

        [Test]
        public void CreatePizza_ReturnCalifornia()
        {
            _pizza.Type = PizzaType.California;

            var ex = _pizza.Type = PizzaType.California;
            var actual = _pizzaService.CreatePizza(_pizza);

            Assert.AreEqual(ex, actual.Type);
        }

        [Test]
        public void CreatePizza_ReturnDetroit()
        {
            _pizza.Type = PizzaType.Detroit;

            var ex = _pizza.Type = PizzaType.Detroit;
            var actual = _pizzaService.CreatePizza(_pizza);

            Assert.AreEqual(ex, actual.Type);
        }

        [Test]
        public void CreatePizza_ReturnNeapolitan()
        {
            _pizza.Type = PizzaType.Neapolitan;

            var ex = _pizza.Type = PizzaType.Neapolitan;
            var actual = _pizzaService.CreatePizza(_pizza);

            Assert.AreEqual(ex, actual.Type);
        }
    }
}
