using PizzaStore.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PizzaStore.Test
{
    public class PizzaValidatorTest
    {
        [Fact]
        public void IsPizzaTypeValid_ReturnTrueIfPizzaTypeValid()
        {
            // Arrange
            PizzaValidator pizzaValidator = new PizzaValidator();
            // Act

            // Assert
            Assert.True(pizzaValidator.IsPizzaTypeValid("California", out PizzaType pizzaType));
        }

        [Fact]
        public void IsPizzaTypeValid_ReturnFalseIfPizzaTypeInvalid()
        {
            // Arrange
            PizzaValidator pizzaValidator = new PizzaValidator();
            // Act

            // Assert
            Assert.False(pizzaValidator.IsPizzaTypeValid("Caaalifornicaaaatioooon! Too-do-do-doooo!", out PizzaType pizzaType));
        }
    }
}
