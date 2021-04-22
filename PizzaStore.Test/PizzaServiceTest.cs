using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;

namespace PizzaStore.Test
{
    
    public class PizzaServiceTest
    {               
        [Fact]
        public void PayForPizza_SubstractsSpecifiedNumberFromUserAmount()
        {
            // Arrange
            User user = new User("Vasya", 100);
            PizzaService pizzaService = new PizzaService(new PizzaValidator());
            pizzaService.ChoosePizza(nameof(PizzaType.Neapolitan));
            var expected = user.Amount - 10;

            // Act
            pizzaService.PayForPizza(user);

            // Assert
            Assert.Equal(expected, user.Amount);
        }
    }
}
