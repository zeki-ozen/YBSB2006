using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{

    public class BaseClass
    {
        public void Show()
        {
            Console.WriteLine("BaseClass Show");
        }
    }

    public class DerivedClass : BaseClass
    {
        // Hides the BaseClass Show method
        public new void Show()
        {
            Console.WriteLine("DerivedClass Show");
        }
    }

}
