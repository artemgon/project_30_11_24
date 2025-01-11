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
                Passport passport = new Passport
                {
                    SNP = "Ivanov Ivan Ivanovich",
                    Sex = "Male",
                    BirthDate = "01.01.2000",
                    Age = 25,
                    Number = "123456789",
                };
                passport.Print();
                ForeignPassport foreignPassport = new ForeignPassport
                {
                    SNP = "Ivanov Ivan Ivanovich",
                    Sex = "Male",
                    BirthDate = "01.01.2000",
                    Age = 25,
                    Number = "123456789",
                    VisaData = "01.01.2022",
                    FNumber = "987654321",
                };
                foreignPassport.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
