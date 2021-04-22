using NUnit.Framework;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class UserValiddatorTests
    {

        [Test]
        public void UserValiddator_ValidAmount()
        {
            var userAmount = new UserValidator();
            var positiveAmount = 3;
            var negativeAmount = -12;

            Assert.Multiple(() =>
            {
                Assert.True(userAmount.IsAmountValid(positiveAmount));
                Assert.False(userAmount.IsAmountValid(negativeAmount));
            });
        }
    }
}