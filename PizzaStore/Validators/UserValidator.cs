using System.Text.RegularExpressions;

namespace PizzaStore.Validators
{
    public class UserValidator
    {
        public bool IsNameValid(string name)
        {
            return Regex.IsMatch(name, "^[A-Za-z0-9]+$", RegexOptions.IgnoreCase);
        }

        public bool IsAmountValid(double amount)
        {
            return !(amount < 0);
        }
    }
}