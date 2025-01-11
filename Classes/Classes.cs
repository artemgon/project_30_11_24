
namespace project_30_11_24.Classes
{
    public class Human
    {
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public string? Salary { get; set; }
        public int Age { get; set; }
        public Human()
        {
            Name = "";
            Surname = "";
            Salary = "";
            Age = 0;
        }
        public Human(string name) : this()
        {
            Name = name;
        }
        public Human(string name, string surname) : this(name)
        {
            Surname = surname;
        }
        public Human(string name, string surname, string salary) : this(name, surname)
        {
            Salary = salary;
        }
        public Human(string name, string surname, string salary, int age) : this(name, surname, salary)
        {
            Age = age;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Human info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine();
        }
    }
    public class Builder : Human
    {
        public string? Company { get; set; }
        public Builder() : base()
        {
            Company = "";
        }
        public Builder(string name) : base(name)
        {
            Company = "";
        }
        public Builder(string name, string surname) : base(name, surname)
        {
            Company = "";
        }
        public Builder(string name, string surname, string salary) : base(name, surname, salary)
        {
            Company = "";
        }
        public Builder(string name, string surname, string salary, int age) : base(name, surname, salary, age)
        {
            Company = "";
        }
        public Builder(string name, string surname, string salary, int age, string company) : base(name, surname, salary, age)
        {
            Company = company;
        }
        public new void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Builder info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine();
        }
    }
    public class Sailor : Human
    {
        public string? Ship { get; set; }
        public Sailor() : base()
        {
            Ship = "";
        }
        public Sailor(string name) : base(name)
        {
            Ship = "";
        }
        public Sailor(string name, string surname) : base(name, surname)
        {
            Ship = "";
        }
        public Sailor(string name, string surname, string salary) : base(name, surname, salary)
        {
            Ship = "";
        }
        public Sailor(string name, string surname, string salary, int age) : base(name, surname, salary, age)
        {
            Ship = "";
        }
        public Sailor(string name, string surname, string salary, int age, string ship) : base(name, surname, salary, age)
        {
            Ship = ship;
        }
        public new void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Sailor info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Ship: {Ship}");
            Console.WriteLine();
        }
    }
    public class Pilot : Human
    {
        public string? Plane { get; set; }
        public Pilot() : base()
        {
            Plane = "";
        }
        public Pilot(string name) : base(name)
        {
            Plane = "";
        }
        public Pilot(string name, string surname) : base(name, surname)
        {
            Plane = "";
        }
        public Pilot(string name, string surname, string salary) : base(name, surname, salary)
        {
            Plane = "";
        }
        public Pilot(string name, string surname, string salary, int age) : base(name, surname, salary, age)
        {
            Plane = "";
        }
        public Pilot(string name, string surname, string salary, int age, string plane) : base(name, surname, salary, age)
        {
            Plane = plane;
        }
        public new void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Pilot info:");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname: {Surname}");
            Console.WriteLine($"Salary: {Salary}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Plane: {Plane}");
            Console.WriteLine();
        }
    }
}
