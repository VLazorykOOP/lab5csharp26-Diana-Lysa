using System;

abstract class Figure
{
    public string Name { get; set; }

    protected Figure(string name)
    {
        Name = name;
    }

    public abstract double GetArea();
    public abstract double GetPerimeter();

    public virtual void Show()
    {
        Console.WriteLine($" {Name} ");
        Console.WriteLine($"Периметр: {GetPerimeter():F2}");
        Console.WriteLine($"Площа: {GetArea():F2}");
    }
}

// 2. Прямокутник
class Rectangle : Figure
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double w, double h) : base("Прямокутник")
    {
        Width = w;
        Height = h;
    }

    public override double GetArea() => Width * Height;
    public override double GetPerimeter() => 2 * (Width + Height);
}

// 3. Коло
class Circle : Figure
{
    public double Radius { get; set; }

    public Circle(double r) : base("Коло")
    {
        Radius = r;
    }

    public override double GetArea() => Math.PI * Math.Pow(Radius, 2);
    public override double GetPerimeter() => 2 * Math.PI * Radius;
}

// 4. Трикутник
class Triangle : Figure
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public Triangle(double a, double b, double c) : base("Трикутник")
    {
        A = a; B = b; C = c;
    }

    public override double GetPerimeter() => A + B + C;

    public override double GetArea()
    {
        double p = GetPerimeter() / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }
}

