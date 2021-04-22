using PizzaStore;
using PizzaStore.Services;
using PizzaStore.Validators;
using System;
using Xunit;

namespace PizzaStore.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var user = new UserService(new UserValidator()).CreateUser("Mario", 100);
            
            var expectedResult = true;

            var actualResult = new UserValidator().IsNameValid("Mario");

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Test2()
        {
            var user = new UserService(new UserValidator()).CreateUser("Mario", 100);

            var expectedResult = false;

            var actualResult = new UserValidator().IsNameValid("|V| è |< 0 ë @");

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
