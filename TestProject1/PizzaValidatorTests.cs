using NUnit.Framework;
using System;
using PizzaStore.Validators;

namespace PizzaStoreTests
{
    class PizzaValidatorTests
    {
        private PizzaValidator _pizzaValidator;
        private PizzaStore.PizzaType _pizzaType;

        [SetUp]
        public void SetUp()
        {
            _pizzaValidator = new PizzaValidator();
        }

        [Test]
        public void PizzaTypeCaliforniaIsTrue()
        {
            _pizzaType = PizzaStore.PizzaType.California;

            Assert.IsTrue(_pizzaValidator.IsPizzaTypeValid("1", out _pizzaType));
        }

        [Test]
        public void PizzaTypeDetroitIsTrue()
        {
            _pizzaType = PizzaStore.PizzaType.Detroit;

            Assert.IsTrue(_pizzaValidator.IsPizzaTypeValid("2", out _pizzaType));
        }

        [Test]
        public void PizzaTypeNeapolitanIsTrue()
        {
            _pizzaType = PizzaStore.PizzaType.Neapolitan;

            Assert.IsTrue(_pizzaValidator.IsPizzaTypeValid("3", out _pizzaType));
        }

        [Test]
        public void InvalidStringForNeapolitanIsFalse()
        {
            _pizzaType = PizzaStore.PizzaType.Neapolitan;

            Assert.IsFalse(_pizzaValidator.IsPizzaTypeValid("4", out _pizzaType));
        }

        [Test]
        public void InvalidStringForCaliforniaIsFalse()
        {
            _pizzaType = PizzaStore.PizzaType.California;

            Assert.IsFalse(_pizzaValidator.IsPizzaTypeValid("6", out _pizzaType));
        }

        [Test]
        public void InvalidStringForDetroitIsFalse()
        {
            _pizzaType = PizzaStore.PizzaType.Detroit;

            Assert.IsFalse(_pizzaValidator.IsPizzaTypeValid("aaa", out _pizzaType));
        }
    }
}
