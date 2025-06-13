using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7_OOP
{


    class Base
    {
        public void A() { Console.WriteLine("Base:A"); }
    }
    class Derived : Base
    {
        // method hiding using with new keyword
        public new void A()
        {
            Console.WriteLine("Derived:A");
        }
    }
}




