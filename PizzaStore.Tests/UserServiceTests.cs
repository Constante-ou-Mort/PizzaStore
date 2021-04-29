using System;
using System.ComponentModel.Design;
using NUnit.Framework;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;
namespace PizzaStore.Tests
{
    public class UserServiceTests
    {
        [TestCase("Svitlana123", 100)]
        [TestCase("Svitlana", 100)]
        public void CreateUserPositive(string name, double amount)
        {
            var userService = new UserService(new UserValidator());
            var user = new User(name, amount);
            
            Assert.AreEqual(user, userService.CreateUser(name, amount));
        }

        [Test]
        public void CreateUserNegativeSum()
        {
            var userService = new UserService(new UserValidator());
            var name = "Svitlana";
            var amount = -100;
            
            var ex = Assert.Throws<ArgumentException>(() => userService.CreateUser(name, amount));
            Assert.That(ex.Message, Is.EqualTo($"{amount} is invalid."));
        }
        
        [Test]
        public void CreateUserNegativeName()
        {
            var userService = new UserService(new UserValidator());
            var name = "Світлана!";
            var amount = 100;
            
            var ex = Assert.Throws<ArgumentException>(() => userService.CreateUser(name, amount));
            Assert.That(ex.Message, Is.EqualTo($"{name} is invalid."));
        }
    }
}