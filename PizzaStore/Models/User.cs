namespace PizzaStore.Models
{
    public class User
    {
        public string Name { get; }
        public double Amount { get; set; }

        public User(string name, double amount)
        {
            Name = name;
            Amount = amount;
        }
        public override bool Equals(object obj)
        {
            User user = obj as User;
            return user != null && user.Name == Name && user.Amount == Amount;

        }
    }
}