using System.Collections.Generic;

namespace PizzaStore
{
    public static class PizzaIngredientsService
    {
        private static readonly Dictionary<PizzaType, List<string>> _ingredients = new Dictionary<PizzaType, List<string>>
        {
            {
                PizzaType.neapolitan, new List<string>
                {
                    "Flour", "Mozzarella", "Tomato", "Tomato sauce", "Basil", "Yeast", "Olive oil"
                }
            },
            {
                PizzaType.california, new List<string>
                {
                    "Honey", "Olive oil","Flour","Salt","Red onion","Black olives","Mushrooms"
                }
            },
            {
                PizzaType.detroit, new List<string>
                {
                    "White sugar", "Olive oil","Bread flour","Kosher salt","Red onion","Garlic","Mushrooms"
                }
            }
        };

        public static List<string> GetIngredientsByPizzaType(PizzaType pizzaType)
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