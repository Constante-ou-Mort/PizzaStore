using System;

namespace PizzaStore
{
    public class Menu
    {
        private readonly PizzaService _pizzaService;
        private readonly User _user;

        public Menu(PizzaService pizzaService,User user)
        {
            _pizzaService = pizzaService;
            _user = user;
        }

        public void SelectOption()
        {
            Console.WriteLine($"Choose any pizza: (1){PizzaType.California} (8$) , (2){PizzaType.Detroit}(10$), (3){PizzaType.Neapolitan}(12$)");
            var pizzaType = Console.ReadLine();

            var pizza = _pizzaService.ChoosePizza(pizzaType);
            _pizzaService.PayForPizza(_user);
            _pizzaService.CreatePizza(pizza);
        }
    }
}