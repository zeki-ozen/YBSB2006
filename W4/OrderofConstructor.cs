using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public class A
    {
        public A() => Console.WriteLine("A");
    }
    public class B : A
    {
        public B() => Console.WriteLine("B");
    }
    // new B() prints A then B
}
