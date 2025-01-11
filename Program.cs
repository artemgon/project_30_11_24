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
                MusicalInstrument violin = new Violin();
                MusicalInstrument trombone = new Trombone();
                MusicalInstrument ukulele = new Ukulele();
                MusicalInstrument cello = new Cello();
                violin.Print();
                trombone.Print();
                ukulele.Print();
                cello.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
