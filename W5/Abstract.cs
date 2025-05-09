using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_Polymorphism
{
      public abstract class Shape
    {
        public abstract double Area();  // no body
    }
    public class AbstractCircle : Shape
    {
        public double Radius { get; }
        public AbstractCircle(double r) => Radius = r;
        public override double Area()  // must implement
            => Math.PI * Radius * Radius;
    }

}
