using System;
using System.Collections.Generic;
using System.Text;

namespace W8_Area
{
    internal class SpecialArea : Area
    {
        public SpecialArea(double side) : base(side)
        {
            this.area = base.area * 6;
        }

   
    }
}
