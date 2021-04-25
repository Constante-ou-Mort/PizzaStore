using NUnit.Framework;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class UserValiddatorTests
    {
        private UserValidator user;

        [SetUp]
        public void Setup()
        {
            user = new UserValidator();
        }

        [Test]
        public void UserValiddator_ValidAmount()
        {
            var positiveAmount = 3;
            var negativeAmount = -12;

            Assert.Multiple(() =>
            {
                Assert.True(user.IsAmountValid(positiveAmount));
                Assert.False(user.IsAmountValid(negativeAmount));
            });
        }

        [Test]
        public void UserValiddator_ValidName()
        {
            var valid = "Kate";
            var invalid = "ÀÂÎÂàù";

            Assert.Multiple(() =>
            {
                Assert.True(user.IsNameValid(valid));
                Assert.False(user.IsNameValid(invalid));
            });
        }
    }
}