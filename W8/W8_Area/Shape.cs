using System;
using System.Collections.Generic;
using System.Text;

namespace W8_Area
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape çizildi");
        }
    }

    class SpecialShape : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("SpecialShape çizildi");
        }

        public void SpecialMethod()
        {
            Console.WriteLine("Özel metod çalıştı");
        }
    }
}
