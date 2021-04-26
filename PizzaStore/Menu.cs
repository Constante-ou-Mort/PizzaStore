using System;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore
{
    public class Menu
    {
        private readonly PizzaService _pizzaService;
        private readonly User _user;

        public Menu(PizzaService pizzaService, User user)
        {
            _pizzaService = pizzaService;
            _user = user;
        }

        public void MakeOrder()
        {
            Console.WriteLine($"Choose any pizza: (0){PizzaType.California} (8$) , (1){PizzaType.Detroit}(10$), (2){PizzaType.Neapolitan}(12$)");

            var pizzaType = Console.ReadLine();

            var pizza = _pizzaService.ChoosePizza(pizzaType);
            Pizza createdPizza;

            if (_pizzaService.PayForPizza(_user))
            {
                createdPizza = _pizzaService.CreatePizza(pizza);

                Console.WriteLine($"{_user.Name}, please, take your {createdPizza.Name} pizza.");
            }
            if (_user.Amount >= 8)
            {
                this.MakeOrder();
            }
            else
                Console.WriteLine($"{_user.Name}, please, come back when you'll have enough money for pizza.");
        }
    }
}