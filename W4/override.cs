using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public class Shape
    {
        public virtual void Draw() => 
            Console.WriteLine("Drawing shape");
    }

    public class Circle : Shape
    {
        public override void Draw() => 
            Console.WriteLine("Drawing circle");
    }
}
