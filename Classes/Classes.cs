
namespace project_30_11_24.Classes
{
    public abstract class Worker
    {
        public string? SNP { get; set; }
        public string? Salary { get; set; } // amount and currency
        public string? Position { get; set; }
        public int Age { get; set; }
        public Worker()
        {
            SNP = "Unknown";
            Salary = "Unknown";
            Position = "Unknown";
            Age = 0;
        }
        public Worker(string snp, string salary, string position, int age)
        {
            SNP = snp;
            Salary = salary;
            Position = position;
            Age = age;
        }
        public abstract void Print();
    }
    public class President : Worker
    {
        public string? Country { get; set; }
        public President() : base()
        {
            Country = "Unknown";
        }
        public President(string snp, string salary, string position, int age, string country) : base(snp, salary, position, age)
        {
            Country = country;
        }
        public override void Print()
        {
            Console.WriteLine($"SNP: {SNP}\nSalary: {Salary}\nPosition: {Position}\nAge: {Age}\nCountry: {Country}");
        }
    }
    public class Security : Worker
    {
        public string? Rank { get; set; }
        public Security() : base()
        {
            Rank = "Unknown";
        }
        public Security(string snp, string salary, string position, int age, string rank) : base(snp, salary, position, age)
        {
            Rank = rank;
        }
        public override void Print()
        {
            Console.WriteLine($"SNP: {SNP}\nSalary: {Salary}\nPosition: {Position}\nAge: {Age}\nRank: {Rank}");
        }
    }
    public class Manager : Worker
    {
        public string? Department { get; set; }
        public Manager() : base()
        {
            Department = "Unknown";
        }
        public Manager(string snp, string salary, string position, int age, string department) : base(snp, salary, position, age)
        {
            Department = department;
        }
        public override void Print()
        {
            Console.WriteLine($"SNP: {SNP}\nSalary: {Salary}\nPosition: {Position}\nAge: {Age}\nDepartment: {Department}");
        }
    }
    public class Engineer : Worker
    {
        public string? Specialization { get; set; }
        public Engineer() : base()
        {
            Specialization = "Unknown";
        }
        public Engineer(string snp, string salary, string position, int age, string specialization) : base(snp, salary, position, age)
        {
            Specialization = specialization;
        }
        public override void Print()
        {
            Console.WriteLine($"SNP: {SNP}\nSalary: {Salary}\nPosition: {Position}\nAge: {Age}\nSpecialization: {Specialization}");
        }
    }
}
