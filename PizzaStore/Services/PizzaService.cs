﻿using System;
using System.Threading;
using PizzaStore.Models;
using PizzaStore.Validators;

namespace PizzaStore.Services
{
    public class PizzaService
    {
        private readonly PizzaValidator _pizzaValidator;
        private Pizza _pizza;

        public PizzaService(PizzaValidator pizzaValidator)
        {
            _pizzaValidator = pizzaValidator;
        }

        public Pizza ChoosePizza(string pizzaName)
        {
            if (!_pizzaValidator.IsPizzaTypeValid(pizzaName, out var pizzaType))
                throw new ArgumentException($"{pizzaName} does not exist. Please choose another.");

            _pizza = pizzaType switch
            {
                PizzaType.neapolitan => new Pizza { Price = 12, Name = nameof(PizzaType.neapolitan) },
                PizzaType.detroit => new Pizza { Price = 10, Name = nameof(PizzaType.detroit) },
                PizzaType.california => new Pizza { Price = 8, Name = nameof(PizzaType.california) }
            };

            return _pizza;
        }

        public User PayForPizza(User user)
        {
            if (user.Amount < _pizza.Price)
                throw new ArgumentException("You don't have enough money");

            user.Amount -= _pizza.Price;

            Console.WriteLine($"You paid was successful. Pizza price {_pizza.Price}, you current amount {user.Amount}");
            return user;
        }

        public Pizza CreatePizza(Pizza pizza)
        {
            var ingredients = PizzaIngredientsService.GetIngredientsByPizzaType(pizza.Type);
            pizza.Ingredients = ingredients;

            var bakedPizza = BakePizza(pizza);

            return bakedPizza;
        }

        private Pizza BakePizza(Pizza pizza)
        {
            for (var i = 0; i < 100; i++)
            {
                Console.Write(".");
                Thread.Sleep(100);
            }

            pizza.IsBaked = true;

            Console.WriteLine($"\nYour pizza {pizza.Name} is ready.");

            return pizza;
        }
    }
}