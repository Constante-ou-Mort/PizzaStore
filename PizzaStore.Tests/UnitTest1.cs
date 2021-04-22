using NUnit.Framework;
using PizzaStore.Validators;

namespace PizzaStore.Tests
{
    public class UserValiddatorTests
    {
        private UserValidator _user;

        [SetUp]
        public void Setup()
        {
            _user = new UserValidator();
        }

        [Test]
        public void UserValiddator_ValidAmount()
        {
            var positiveAmount = 3;
            var negativeAmount = -12;

            Assert.Multiple(() =>
            {
                Assert.True(_user.IsAmountValid(positiveAmount));
                Assert.False(_user.IsAmountValid(negativeAmount));
            });
        }

        [Test]
        public void UserValiddator_ValidName()
        {
            var valid = "Kate";
            var notValid = "@##!1";

            Assert.Multiple(() =>
            {
                Assert.True(_user.IsNameValid(valid));
                Assert.False(_user.IsNameValid(notValid));
            });
        }
    }
}