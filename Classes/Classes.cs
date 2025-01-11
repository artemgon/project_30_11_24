
namespace project_30_11_24.Classes
{
    public class Passport
    {
        public string? SNP { get; set; }
        public string? Sex { get; set; }
        public string? BirthDate { get; set; }
        public int Age { get; set; }
        public string? Number { get; set; }
        public Passport()
        {
            SNP = "";
            Sex = "";
            BirthDate = "";
            Age = 0;
            Number = "";
        }
        public Passport(string sNP, string sex, string birthDate, int age, string number)
        {
            SNP = sNP;
            Sex = sex;
            BirthDate = birthDate;
            Age = age;
            Number = number;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Passport Info:");
            Console.WriteLine($"SNP: {SNP}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"BirthDate: {BirthDate}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Number: {Number}");
            Console.WriteLine();
        }
    }
    public class ForeignPassport : Passport
    {
        public string? VisaData { get; set; }
        public string? FNumber { get; set; }
        public ForeignPassport()
        {
            VisaData = "";
            FNumber = "";
        }
        public ForeignPassport(string VisaData, string FNumber)
        {
            this.VisaData = VisaData;
            this.FNumber = FNumber;
        }
        public new void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Foreign Passport Info:");
            Console.WriteLine($"SNP: {SNP}");
            Console.WriteLine($"Sex: {Sex}");
            Console.WriteLine($"BirthDate: {BirthDate}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Visa Data: {VisaData}");
            Console.WriteLine($"Foreign Number: {FNumber}");
            Console.WriteLine();
        }
    }
}
