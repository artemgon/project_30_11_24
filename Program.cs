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
                Animal animal = new Animal("Animal", "Unknown", 0, 0);
                animal.Print();
                Tiger tiger = new Tiger("Tiger", "Asia", 60, 10);
                tiger.Print();
                Crocodile crocodile = new Crocodile("Crocodile", "Africa", 30, 20);
                crocodile.Print();
                Kangaroo kangaroo = new Kangaroo("Kangaroo", "Australia", 70, 15);
                kangaroo.Print();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
