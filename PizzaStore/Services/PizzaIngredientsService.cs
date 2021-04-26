using System.Collections.Generic;

namespace PizzaStore
{
    public static class PizzaIngredientsService
    {
        private static readonly Dictionary<string, List<string>> _ingredients = new Dictionary<string, List<string>>
        {
            {
                "Neapolitan", new List<string>
                {
                    "Flour", "Mozzarella", "Tomato", "Tomato sauce", "Basil", "Yeast", "Olive oil"
                }
            },
            {
                "California", new List<string>
                {
                    "Honey", "Olive oil","Flour","Salt","Red onion","Black olives","Mushrooms"
                }
            },
            {
                "Detroit", new List<string>
                {
                    "White sugar", "Olive oil","Bread flour","Kosher salt","Red onion","Garlic","Mushrooms"
                }
            }
        };

        public static List<string> GetIngredientsByPizzaType(string pizzaType)
        {
            var ingredients = new List<string>();

            if (_ingredients.ContainsKey(pizzaType))
            {
                ingredients = _ingredients[pizzaType];
            }

            return ingredients;
        }
    }
}