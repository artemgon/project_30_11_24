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
                Figure[] figures = new Figure[4];
                figures[0] = new Rectangle(5, 10);
                figures[1] = new Circle(5);
                figures[2] = new RightTriangle(3, 4, 5);
                figures[3] = new Rectangle(10, 20);
                foreach (var figure in figures)
                {
                    Console.WriteLine($"Area: {figure.Area()}");
                    Console.WriteLine($"Perimeter: {figure.Perimeter()}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
