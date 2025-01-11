
namespace project_30_11_24.Classes
{
    public abstract class Figure
    {
        public abstract double Area();
        public abstract double Perimeter();
    }
    public class Rectangle : Figure
    {
        private double _width;
        private double _height;
        public Rectangle(double width, double height)
        {
            _width = width;
            _height = height;
        }
        public override double Area()
        {
            return _width * _height;
        }
        public override double Perimeter()
        {
            return 2 * (_width + _height);
        }
    }
    public class Circle : Figure
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public override double Area()
        {
            return Math.PI * _radius * _radius;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * _radius;
        }
    }
    public class RightTriangle : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        public RightTriangle(double a, double b, double c)
        {
            _a = a;
            _b = b;
            _c = c;
        }
        public override double Area()
        {
            return 0.5 * _a * _b;
        }
        public override double Perimeter()
        {
            return _a + _b + _c;
        }
    }
    public class Trapezoid : Figure
    {
        private double _a;
        private double _b;
        private double _c;
        private double _d;
        private double _h;
        public Trapezoid(double a, double b, double c, double d, double h)
        {
            _a = a;
            _b = b;
            _c = c;
            _d = d;
            _h = h;
        }
        public override double Area()
        {
            return 0.5 * (_a + _b) * _h;
        }
        public override double Perimeter()
        {
            return _a + _b + _c + _d;
        }
    }
}
