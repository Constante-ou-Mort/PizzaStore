using NUnit.Framework;
using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;

namespace UnitTestPizzaStore
{
    public class TestPizzaService
    {
        [Test]
        public void CheckChoosePizzaInvalid()
        {
            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);

            var result = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza("Gavai"));
            Assert.That(result.Message, Is.EqualTo("Gavai does not exist. Please choose another."));
        }

        [Test]
        public void ChoosePizzaCalifornia()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var createdUser = userService.CreateUser("Julia", 100);

            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);

            var pizzaType = "1";
            var pizza = pizzaService.ChoosePizza(pizzaType);

            Assert.AreEqual("California", pizza.Name);
        }
        [Test]
        public void ChoosePizzaDetroit()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var createdUser = userService.CreateUser("Julia", 100);

            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);

            var pizzaType = "2";
            var pizza = pizzaService.ChoosePizza(pizzaType);

            Assert.AreEqual("Detroit", pizza.Name);
        }
        public void ChoosePizzaNeapolitan()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);
            var createdUser = userService.CreateUser("Julia", 100);
            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);
            var pizzaType = "3";
            var pizza = pizzaService.ChoosePizza(pizzaType);

            Assert.AreEqual("Neapolitan", pizza.Name);
        }
        [Test]
        public void PayForPizzaCalifornia()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var createdUser = userService.CreateUser("Julia", 100);

            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);

            var pizzaType = "1";
            var pizza = pizzaService.ChoosePizza(pizzaType);

            var currentAmount = createdUser.Amount - pizza.Price;

            Assert.AreEqual("You paid was successful. Pizza price 8, you current amount 92",
            $"You paid was successful. Pizza price {pizza.Price}, you current amount {currentAmount}");
        }

        [Test]
        public void PayForPizzaDetroit()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var createdUser = userService.CreateUser("Julia", 100);

            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);

            var pizzaType = "2";
            var pizza = pizzaService.ChoosePizza(pizzaType);

            var currentAmount = createdUser.Amount - pizza.Price;

            Assert.AreEqual("You paid was successful. Pizza price 10, you current amount 90",
            $"You paid was successful. Pizza price {pizza.Price}, you current amount {currentAmount}");
        }

        [Test]
        public void PayForPizzaNeapolitan()
        {
            var userValidator = new UserValidator();
            var userService = new UserService(userValidator);

            var createdUser = userService.CreateUser("Julia", 100);

            var pizzaValidator = new PizzaValidator();
            var pizzaService = new PizzaService(pizzaValidator);

            var pizzaType = "3";
            var pizza = pizzaService.ChoosePizza(pizzaType);

            var currentAmount = createdUser.Amount - pizza.Price;

            Assert.AreEqual("You paid was successful. Pizza price 12, you current amount 88",
           $"You paid was successful. Pizza price {pizza.Price}, you current amount {currentAmount}");
        }
    }
}