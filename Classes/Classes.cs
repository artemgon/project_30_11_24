
namespace project_30_11_24.Classes
{
    public class MusicalInstrument
    {
        public string? Sound { get; set; }
        public string? Show { get; set; }
        public string? Desc { get; set; }
        public string? History { get; set; }
        public MusicalInstrument() 
        {
            Sound = "Sound";
            Show = "Show";
            Desc = "Desc";
            History = "History";
        }
        public MusicalInstrument(string sound, string show, string desc, string history)
        {
            Sound = sound;
            Show = show;
            Desc = desc;
            History = history;
        }
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"Sound: {Sound}");
            Console.WriteLine($"Show: {Show}");
            Console.WriteLine($"Desc: {Desc}");
            Console.WriteLine($"History: {History}");
        }
    }
    public class Violin : MusicalInstrument
    {
        public Violin() : base("Violin sound", "Violin", "Violin desc", "Violin history")
        { }
    }
    public class Trombone : MusicalInstrument
    {
        public Trombone() : base("Trombone sound", "Trombone", "Trombone desc", "Trombone history")
        { }
    }
    public class Ukulele : MusicalInstrument
    {
        public Ukulele() : base("Ukulele sound", "Ukulele", "Ukulele desc", "Ukulele history")
        { }
    }
    public class Cello : MusicalInstrument
    {
        public Cello() : base("Cello sound", "Cello", "Cello desc", "Cello history")
        { }
    }
}
