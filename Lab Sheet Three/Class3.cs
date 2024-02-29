using System;

public class Shape
{
    // Fields
    protected string shapeType;
    protected double area;

    // Constructor
    public Shape(string shapeType)
    {
        this.shapeType = shapeType;
    }

    // Method to calculate area (to be overridden by subclasses)
    public virtual void CalculateArea(double val1, double val2 = 0)
    {
        // To be implemented by subclasses
    }

    // Method to display shape information
    public virtual void DisplayShapeInfo()
    {
        Console.WriteLine($"Shape Type: {shapeType}");
        Console.WriteLine($"Area: {area}");
    }
}

public class Rectangle : Shape
{
    // Fields
    private double length;
    private double width;

    // Constructor
    public Rectangle(double length, double width) : base("Rectangle")
    {
        this.length = length;
        this.width = width;
        CalculateArea(length, width);
    }

    // Override CalculateArea method for rectangle
    public override void CalculateArea(double val1, double val2 = 0)
    {
        area = val1 * val2;
    }
}

public class Circle : Shape
{
    // Fields
    private double radius;

    // Constructor
    public Circle(double radius) : base("Circle")
    {
        this.radius = radius;
        CalculateArea(radius);
    }

    // Override CalculateArea method for circle
    public override void CalculateArea(double val1, double val2 = 0)
    {
        area = Math.PI * val1 * val1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of Rectangle
        Rectangle rectangle = new Rectangle(5, 3);
        // Display shape information for the rectangle
        rectangle.DisplayShapeInfo();

        Console.WriteLine();

        // Create an instance of Circle
        Circle circle = new Circle(4);
        // Display shape information for the circle
        circle.DisplayShapeInfo();
    }
}
