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
                Device[] devices = new Device[4];
                devices[0] = new TeaPot();
                devices[1] = new Microwave();
                devices[2] = new Car();
                devices[3] = new SteamBoat();
                foreach (var device in devices)
                {
                    device.Print();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
