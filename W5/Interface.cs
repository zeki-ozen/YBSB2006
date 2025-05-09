using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_Polymorphism
{
    // Define an interface instead of an abstract class
    public interface IShape
    {
        double Area();  // Interface methods are abstract by default, they don't have bodies
        void Display(); // Added an extra method
    }

    // Class implementing the interface
    public class InterfaceCircle : IShape
    {
        public double Radius { get; }
        
        public InterfaceCircle(double r) => Radius = r;
        
        // Implementation of the method from the interface
        public double Area() => Math.PI * Radius * Radius;
        
        // Implementation of the second method from the interface
        public void Display() => Console.WriteLine($"Circle - Radius: {Radius}, Area: {Area():F2}");
    }

    // Another class implementing the same interface
    public class Rectangle : IShape
    {
        public double Width { get; }
        public double Height { get; }
        
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }
        
        // Implementation of the method from the interface
        public double Area() => Width * Height;
        
        // Implementation of the second method from the interface
        public void Display() => Console.WriteLine($"Rectangle - Width: {Width}, Height: {Height}, Area: {Area():F2}");
    }
}