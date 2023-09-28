namespace ConsoleApp3;

public class Circle : IShape
{
    public double Radius { get; set; }
    public double Area => Math.PI * Radius * Radius;
    public double Perimeter => 2 * Math.PI * Radius;
}

public class Rectangle : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public double Area => Width * Height;
    public double Perimeter => 2 * (Width + Height);
}

public class Triangle : IShape
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }
    public double Area
    {
        get
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
    public double Perimeter => A + B + C;
}

