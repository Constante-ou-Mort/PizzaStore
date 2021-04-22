﻿using PizzaStore.Services;
using System;
using Xunit;
using PizzaStore.Validators;

namespace PizzaStoreTests
{
    public class PizzaServiceTests
    {
        [Fact]
        public void ChoosePizzaCalifornia()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var actual = pizzaService.ChoosePizza("1");
            var expected = pizzaService.ChoosePizza("California");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChoosePizzaDetroit()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var actual = pizzaService.ChoosePizza("2");
            var expected = pizzaService.ChoosePizza("Detroit");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChoosePizzaNeapolitan()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act   
            var actual = pizzaService.ChoosePizza("3");
            var expected = pizzaService.ChoosePizza("Neapolitan");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExeptionForChoosePizza()
        {
            //arrange
            var pizzaService = new PizzaService(new PizzaValidator());

            //Act & Assert             
            var exception = Assert.Throws<ArgumentException>(() => pizzaService.ChoosePizza("4"));
            var message = "4 does not exist. Please choose another.";
            Assert.Equal(message, exception.Message);           
        } 
    }
}
