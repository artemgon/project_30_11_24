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
                Human human = new Human
                {
                    Name = "John",
                    Surname = "Doe",
                    Salary = "1000",
                    Age = 30
                };
                human.Print();
                Builder builder = new Builder
                {
                    Name = "Jane",
                    Surname = "Doe",
                    Salary = "2000",
                    Age = 25,
                    Company = "Company"
                };
                builder.Print();
                Sailor sailor = new Sailor
                {
                    Name = "Jack",
                    Surname = "Sparrow",
                    Salary = "3000",
                    Age = 35,
                    Ship = "Black Pearl"
                };
                sailor.Print();
                Pilot pilot = new Pilot
                {
                    Name = "John",
                    Surname = "Travolta",
                    Salary = "4000",
                    Age = 40,
                    Plane = "Boeing 747"
                };
                pilot.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
