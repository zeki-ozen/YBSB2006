using System;
using System.Collections.Generic;
using System.Text;

namespace W8_Area
{
    internal class Area
    {
        public double area;


        // Constructor Overloading Example
        public Area(double side) { 
            this.area = side * side; // Square
        }

        public Area(double side1, double side2)
        {
            this.area = side1 * side2; // Rectangle
        }


        public Area(string something, double r)
        {
            this.area = Math.PI * r * r; // Circle
        }

    }
}
