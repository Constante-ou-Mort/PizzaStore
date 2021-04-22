using NUnit.Framework;
using PizzaStore;
using PizzaStore.Validators;
using PizzaStore.Models;
using PizzaStore.Services;

namespace PizzaStore.Tests
{
    [TestFixture]
    public class Tests
    {        
        [Test]
        public void Test1()
        {            
            var validator = new UserValidator();

            var result = validator.IsNameValid("Nice01");            
            
            Assert.AreEqual(true, result);
        }
    }
}