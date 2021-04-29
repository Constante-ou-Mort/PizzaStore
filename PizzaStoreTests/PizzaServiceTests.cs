using PizzaStore.Services;
using System;
using Xunit;
using PizzaStore.Validators;
using System.Runtime.CompilerServices;
using PizzaStore.Models;

namespace PizzaStoreTests
{
    public class PizzaServiceTests
    {
        [Fact]
        public void InputNumberForChoosePizzaCalifornia()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
             var inputAction = pizzaService.ChoosePizza("1");            
            
            //Assert
            Assert.Equal("California", inputAction.Name);
        }

        [Fact]
        public void InputNameForChoosePizzaCalifornia()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
             var inputAction = pizzaService.ChoosePizza("California");           
            
            //Assert
            Assert.Equal("California", inputAction.Name);
        }

        [Fact]
        public void InputNumberForChoosePizzaDetroit()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var inputAction = pizzaService.ChoosePizza("2");
            //var expected = pizzaService.ChoosePizza("Detroit");

            //Assert
            Assert.Equal("Detroit", inputAction.Name);
        }
        [Fact]
        public void InputNameForChoosePizzaDetroit()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var inputAction = pizzaService.ChoosePizza("Detroit");           

            //Assert
            Assert.Equal("Detroit", inputAction.Name);
        }

        [Fact]
        public void InputNumberChoosePizzaNeapolitan()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var inputAction = pizzaService.ChoosePizza("3");   
            
            //Assert
            Assert.Equal("Neapolitan", inputAction.Name);
        }
         [Fact]
        public void InputNameChoosePizzaNeapolitan()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var inputAction = pizzaService.ChoosePizza("Neapolitan"); 

            //Assert
            Assert.Equal("Neapolitan", inputAction.Name);
        }

        [Fact]
        public void ExeptionForIncorrectChoosePizza()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act & Assert             
            var exception = Assert.Throws<SwitchExpressionException>(() => pizzaService.ChoosePizza("4"));
            var message = "Non-exhaustive switch expression failed to match its input.\r\nUnmatched value was 4.";
            Assert.Equal(message, exception.Message);        
        }

        [Fact]
        public void PriceForChoosePizzaCalifornia()
        {
            //arrange            
            var pizzaService = new PizzaService(new PizzaValidator());
            var pizza = new Pizza();

            //Act
            var pizza1 = pizzaService.ChoosePizza("California");  

            //Assert
            Assert.Equal(8, pizza1.Price);
        }

        [Fact]
        public void PriceForChoosePizzaDetroit()
        {
            //arrange            
            var pizzaService = new PizzaService(new PizzaValidator());
            var pizza = new Pizza();

            //Act
            var pizza1 = pizzaService.ChoosePizza("Detroit");  

            //Assert
            Assert.Equal(10, pizza1.Price);
        }
        [Fact]
        public void PriceForChoosePizzaNeapolitan()
        {
            //arrange            
            var pizzaService = new PizzaService(new PizzaValidator());
            var pizza = new Pizza();

            //Act
            var pizza1 = pizzaService.ChoosePizza("Neapolitan");  

            //Assert
            Assert.Equal(12, pizza1.Price);
        }

    }
}
