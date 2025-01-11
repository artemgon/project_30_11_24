
namespace project_30_11_24.Classes
{
    public class Money
    {
        public string? Currency { get; set; }
        public int IntAmount { get; set; }
        public int Coins { get; set; }
        public Money()
        {
            Currency = "USD";
            IntAmount = 0;
            Coins = 0;
        }
        public Money(string currency, int intAmount, int coins)
        {
            Currency = currency;
            IntAmount = intAmount;
            Coins = coins;
        }
        public void Print()
        {
            Console.WriteLine($"Currency: {Currency}, Amount: {IntAmount}, Coins: {Coins}");
        }
    }
    public class Product : Money
    {
        public string? Name { get; set; }
        public Product()
        {
            Name = "Unknown";
        }
        public Product(string name, string currency, int intAmount, int coins) : base(currency, intAmount, coins)
        {
            Name = name;
        }
        public void Decrease(int sum)
        {
            if (sum > IntAmount)
            {
                throw new Exception("Not enough money");
            }
            IntAmount -= sum;
        }
        public new void Print()
        {
            Console.WriteLine($"Name: {Name}, Currency: {Currency}, Amount: {IntAmount}, Coins: {Coins}");
        }
    }
}
