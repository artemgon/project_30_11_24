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
                Worker[] workers = new Worker[3];
                workers[0] = new President
                {
                    SNP = "Volodymyr Oleksandrovych Zelensky",
                    Salary = "500000 UAH",
                    Position = "President",
                    Age = 43,
                    Country = "Ukraine"
                };
                workers[1] = new Security
                {
                    SNP = "Ivan Ivanovych Ivanov",
                    Salary = "20000 UAH",
                    Position = "Security",
                    Age = 35,
                    Rank = "Senior"
                };
                workers[2] = new Manager
                {
                    SNP = "Petro Petrovych Petrov",
                    Salary = "30000 UAH",
                    Position = "Manager",
                    Age = 40,
                    Department = "HR"
                };
                foreach (var worker in workers)
                {
                    worker.Print();
                    Console.WriteLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
