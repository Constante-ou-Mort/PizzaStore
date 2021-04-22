using System.Collections.Generic;

namespace PizzaStore.Models
{
    public class Pizza
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public PizzaType Type { get; set; }
        public bool IsBaked { get; set; }
        public List<string> Ingredients { get; set; } = new List<string>();

       
        public bool Equals(Pizza actualPizza)
        {
            for(int i = 0; i < Ingredients.Count; i++)
            {
                if (!actualPizza.Ingredients[i].Equals(Ingredients[i])) return false;
            }
            return Price.Equals(actualPizza.Price) && Name.Equals(actualPizza.Name) && Type.Equals(actualPizza.Type) && IsBaked.Equals(actualPizza.IsBaked);
        }
    }
}