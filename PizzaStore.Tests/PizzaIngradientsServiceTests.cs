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
    class PizzaIngradientsServiceTests
    {
        [Test]
        public void CheckIngredientsNeapolitanPizza()
        {
            var listForCheck = new List<string> { "Flour", "Mozzarella", "Tomato", "Tomato sauce", "Basil", "Yeast", "Olive oil" };
            var resultInList = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaStore.PizzaType.Neapolitan);

            Assert.AreEqual(resultInList, listForCheck);
        }

        [Test]
        public void CheckIngredientsDetroidPizza()
        {
            var listForCheck = new List<string> { "White sugar", "Olive oil", "Bread flour", "Kosher salt", "Red onion", "Garlic", "Mushrooms" };
            var resultInList = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaStore.PizzaType.Detroit);

            Assert.AreEqual(resultInList, listForCheck);
        }

        [Test]
        public void CheckIngredientsCaliforniaPizza()
        {
            var listForCheck = new List<string> { "Honey", "Olive oil", "Flour", "Salt", "Red onion", "Black olives", "Mushrooms" };
            var resultInList = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaStore.PizzaType.California);

            Assert.AreEqual(resultInList, listForCheck);
        }
    }
}
