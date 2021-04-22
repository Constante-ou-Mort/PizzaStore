using PizzaStore.Validators;
using NUnit.Framework;

namespace PizzaStoreTests
{
    public class Test
    {
        [Test]
        public void UserValidator_LatinName()
        {
            var expectedResult = true;
            var name = "Mark";

            var userValidator = new UserValidator();
            var actualResult = userValidator.IsNameValid(name);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}