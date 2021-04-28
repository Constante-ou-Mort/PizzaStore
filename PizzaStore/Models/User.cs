namespace PizzaStore
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
    }
}