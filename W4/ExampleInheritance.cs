using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    internal class Parent
    {
        public void Print() {
            Console.WriteLine("Parent");
        }
    }

    internal class Child : Parent
    {
        public void Echo()
        {
            Console.WriteLine("Child");
        }
    }

    internal class GrandChild : Child
    {
        public void Display()
        {
            Console.WriteLine("Grand Child");
        }
    }

}
