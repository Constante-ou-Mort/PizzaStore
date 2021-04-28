using System;

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
            Console.WriteLine($"Choose any pizza: (1){PizzaType.Neapolitan}(10$), (2){PizzaType.Detroit}(12$), (3){PizzaType.California}(20$)");
            var pizzaType = Console.ReadLine();

            var pizza = _pizzaService.ChoosePizza(pizzaType);
            if (_pizzaService.PayForPizza(_user))
            {
                var createdPizza = _pizzaService.CreatePizza(pizza);

                Console.WriteLine($"{_user.Name}, please, take your {createdPizza.Name} pizza.");
            }
            
        }
    }
}