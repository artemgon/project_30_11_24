
namespace project_30_11_24.Classes
{
    public class Device
    {
        public string? Sound { get; set; }
        public string? Desc { get; set; }
        public Device()
        {
            Sound = "Default sound";
            Desc = "Default description";
        }
        public Device(string sound, string desc)
        {
            Sound = sound;
            Desc = desc;
        }
        public void Print()
        {
            Console.WriteLine($"Sound: {Sound}, Desc: {Desc}");
        }
    }
    public class TeaPot : Device
    {
        public TeaPot() : base("Whistle", "Boils water")
        {
        }
        public new void Print()
        {
            Console.WriteLine($"Sound: {Sound}, Desc: {Desc}");
        }
    }
    public class Microwave : Device
    {
        public Microwave() : base("Beep", "Heats food")
        {
        }
        public new void Print()
        {
            Console.WriteLine($"Sound: {Sound}, Desc: {Desc}");
        }
    }
    public class Car : Device
    {
        public Car() : base("Beep, beep", "Drives")
        {
        }
        public new void Print()
        {
            Console.WriteLine($"Sound: {Sound}, Desc: {Desc}");
        }
    }
    public class SteamBoat : Device
    {
        public SteamBoat() : base("Choo, choo", "Floats")
        {
        }
        public new void Print()
        {
            Console.WriteLine($"Sound: {Sound}, Desc: {Desc}");
        }
    }
}
