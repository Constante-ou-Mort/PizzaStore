using NUnit.Framework;
using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Validators;

namespace PizzaStoreTests
{
    public class UserServiceTests
    {
        [Test]
        public void NameLatinAndNumbersValidate()
        {
            // Arrange
            var userValidator = new PizzaStore.Validators.UserValidator();
            bool expected = true;

            // Act
            bool actualrerult = userValidator.IsNameValid("Roman95");

            // Assert
            Assert.AreEqual(expected, actualrerult);
        }
        [Test ]
        public void NameLatinAndNumbersValidNotValidate()
        {
            // Arrange
            var userValidator = new PizzaStore.Validators.UserValidator();
            bool expected = false;

            // Act
            bool actualrerult = userValidator.IsNameValid("/Rom@");

            // Assert
            Assert.AreEqual(expected,actualrerult);
        }
    }
    public class UserValidateTests
    {
        [Test]
        public void UserValidate ()
        {
            var userValidator = new PizzaStore.Validators.UserValidator();
            var userService = new UserService(userValidator);
            var ex = Assert.Throws<System.ArgumentException>(() => userService.CreateUser("!@#!", 123));
            Assert.That(ex.Message, Is.EqualTo("!@#!2 is invalid."));
        }
        [Test]
        public void IsAmountNotValideTest()
        {
            var userValidator = new PizzaStore.Validators.UserValidator();
            var result = userValidator.IsAmountValid(-25);
            Assert.IsFalse(result);

        }
        [Test]
        public void IsAmountValideTest()
        {
            var userValidator = new PizzaStore.Validators.UserValidator();
            var result = userValidator.IsAmountValid(25);
            Assert.IsFalse(result);

        }
    }
    public class PizzaValidatorTests
    {
        [Test]
        public void PositivePizzaValidator()
        {
            // Arrange
            var validator = new PizzaValidator();
            // Act
            var result = validator.IsPizzaTypeValid("California", out var pizzaType);
            // Assert
            Assert.IsTrue(result);
        }
    }
}