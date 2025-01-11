using project_30_11_24.Classes;

namespace project_30_11_24
{
    internal class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            try
            {
                Money money = new Money
                {
                    Currency = "USD",
                    IntAmount = 100,
                    Coins = 50
                };
                money.Print();
                Product product = new Product
                {
                    Name = "Product",
                    Currency = "USD",
                    IntAmount = 50,
                    Coins = 25
                };
                product.Print();
                product.Decrease(10);
                product.Print();
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
