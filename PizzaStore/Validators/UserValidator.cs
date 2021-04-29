using System;
using System.Text.RegularExpressions;

namespace PizzaStore.Validators
{
    public class UserValidator
    {
        public bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, "[a-z0-9 ]+", RegexOptions.IgnoreCase);
        }

        public bool IsAmountValid(double amount)
        {
            if (amount < 1)
                throw new ArgumentException("You need to have some money to buy pizza!");
            
            return !(amount < 0);
        }
    }
}