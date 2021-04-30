using System.Text.RegularExpressions;

namespace PizzaStore.Validators
{
    public class UserValidator
    {
        public bool IsNameValid(string name)
        {            
            var check = @"[a-zA-Z0-9 ]+";
            return Regex.IsMatch(name, check);
        }

        public bool IsAmountValid(double amount)
        {
            return !(amount < 0);
        }
    }
}