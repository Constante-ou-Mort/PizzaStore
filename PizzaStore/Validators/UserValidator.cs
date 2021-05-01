using System.Text.RegularExpressions;

namespace PizzaStore.Validators
{
    public class UserValidator
    {
        public bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, "[a-z]+", RegexOptions.IgnoreCase);
        }

        public bool IsAmountValid(double amount)
        {
            return !(amount <= 0);
        }
    }
}