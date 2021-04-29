using Xunit;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;

namespace PizzaStore.Test
{    
    public class PizzaServiceTests
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

        [Fact]
        public void PayForPizza_ThrowsExceptionIfAmountLessThanPrice()
        {
            // Arrange
            User user = new User("Vasya", 1);
            PizzaService pizzaService = new PizzaService(new PizzaValidator());
            pizzaService.ChoosePizza(nameof(PizzaType.Neapolitan));            

            // Act            

            // Assert
            Assert.Throws<ArgumentException>(() => pizzaService.PayForPizza(user));
        }


        [Fact]
        public void CreatePizza_CreatesBakedPizza()
        {
            // Arrange
            PizzaService pizzaService = new PizzaService(new PizzaValidator());
            Pizza pizza = pizzaService.ChoosePizza("Neapolitan");

            // Act
            pizzaService.CreatePizza(pizza);

            //Assert
            Assert.True(pizza.IsBaked);
        }

        [Fact]
        public void ChoosePizza_CorrectExceptionMessageWithInvalidPizzaType()
        {
            // Arrange
            PizzaService pizzaService = new PizzaService(new PizzaValidator());            
            var expectedMessage = "Neapolitanskaya does not exist. Please choose another.";

            // Act
            var exception = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza("Neapolitanskaya"));

            //Assert
            Assert.Equal(expectedMessage, exception.Message);
        }
    }
}
