using System;

namespace ShapeArea
{
    // Abstract base class
    abstract class Shape
    {
        // Abstract method to be implemented in derived classes
        public abstract double GetArea();
    }

    // Derived class Circle
    class Circle : Shape
    {
        public double Radius { get; set; }

        // Constructor
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Implement the GetArea method
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Derived class Rectangle
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Constructor
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Implement the GetArea method
        public override double GetArea()
        {
            return Width * Height;
        }
    }

    // Main class
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Circle and Rectangle
            Circle circle = new Circle(10);
            Rectangle rectangle = new Rectangle(8, 12);

            // Display their areas
            Console.WriteLine("Area of the circle: " + circle.GetArea()); // Outputs the area of the circle
            Console.WriteLine("Area of the rectangle: " + rectangle.GetArea()); // Outputs the area of the rectangle
        }
    }
}
