
namespace project_30_11_24.Classes
{
    public class Animal
    {
        public string? Name { get; set; }
        public string? Region { get; set; }
        public int Speed { get; set; }
        public int Age { get; set; }
        public Animal()
        {
            Name = "Unknown";
            Region = "Unknown";
            Speed = 0;
            Age = 0;
        }
        public Animal(string name, string region, int speed, int age)
        {
            Name = name;
            Region = region;
            Speed = speed;
            Age = age;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Animal Info: ");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Region: {Region}");
            Console.WriteLine($"Speed: {Speed}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine();
        }
    }
    public class Tiger : Animal
    {
        public Tiger() : base()
        {
            Name = "Tiger";
            Region = "Asia";
            Speed = 60;
            Age = 10;
        }
        public Tiger(string name, string region, int speed, int age) : base(name, region, speed, age)
        {
            Name = name;
            Region = region;
            Speed = speed;
            Age = age;
        }
    }
    public class Crocodile : Animal
    {
        public Crocodile() : base()
        {
            Name = "Crocodile";
            Region = "Africa";
            Speed = 30;
            Age = 20;
        }
        public Crocodile(string name, string region, int speed, int age) : base(name, region, speed, age)
        {
            Name = name;
            Region = region;
            Speed = speed;
            Age = age;
        }
    }
    public class Kangaroo : Animal
    {
        public Kangaroo() : base()
        {
            Name = "Kangaroo";
            Region = "Australia";
            Speed = 70;
            Age = 15;
        }
        public Kangaroo(string name, string region, int speed, int age) : base(name, region, speed, age)
        {
            Name = name;
            Region = region;
            Speed = speed;
            Age = age;
        }
    }
}
