using PizzaStore;
using PizzaStore.Models;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;
using System.Collections.Generic;
using Xunit;

namespace PizzaStore.Tests
{
    public class Services
    {
       
        [Fact]
        public void PositiveUserCheck()
        {
            var name = "mario";
            var amount = 100;

            var expectedResult = new User(name, amount);

            var actualResult = new UserService(new UserValidator()).CreateUser(name, amount);

          
            Assert.Equal(expectedResult, actualResult);
        }
        [Fact]
        public void NegativeUserCheck()
        {
            var name = "   МИКОЛ@-";
            var amount = -100;

            var expectedResult = "-100 is invalid.";

            var actualResult =  Assert.Throws<ArgumentException>(()=> new UserService(new UserValidator()).CreateUser(name, amount));

            Assert.Equal(expectedResult, actualResult.Message);
            
        }
        
             [Fact]
        public void PositiveChoosePizza()
        {
            Pizza expectedResult = new Pizza { Price = 10, Name = nameof(PizzaType.Neapolitan) };
  
            Pizza actualResult = new PizzaService(new PizzaValidator()).ChoosePizza("Neapolitan");

            Assert.True(expectedResult.Equals(actualResult));
        }
        
               [Fact]
        public void PositiveChoosePizzaIngredients()
        {
            var expectedResult = new List<string>  { "Flour", "Mozzarella", "Tomato", "Tomato sauce", "Basil", "Yeast", "Olive oil" };

            var actualResult = PizzaIngredientsService.GetIngredientsByPizzaType(PizzaType.Neapolitan);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
