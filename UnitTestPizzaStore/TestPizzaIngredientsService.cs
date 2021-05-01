using NUnit.Framework;
using PizzaStore;
using System.Collections.Generic;

namespace UnitTestPizzaStore
{
    public class TestPizzaIngredientsService
    {
        [Test]
        public void CheckIngredientsNeapolitanPizza()
        {
            var list = new List<string> { "Flour", "Mozzarella", "Tomato", "Tomato sauce", "Basil", "Yeast", "Olive oil" };
            var result = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaType.Neapolitan);

            Assert.AreEqual(result, list);
        }
        [Test]
        public void CheckIngredientsDetroidPizza()
        {
            var list = new List<string> { "White sugar", "Olive oil", "Bread flour", "Kosher salt", "Red onion", "Garlic", "Mushrooms" };
            var result = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaType.Detroit);

            Assert.AreEqual(result, list);
        }

        [Test]
        public void CheckIngredientsCaliforniaPizza()
        {
            var list = new List<string> { "Honey", "Olive oil", "Flour", "Salt", "Red onion", "Black olives", "Mushrooms" };
            var result = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaType.California);

            Assert.AreEqual(result, list);
        }
    }
}