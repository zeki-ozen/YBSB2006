using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public class Animal          // base
    {
        public void Eat() => Console.WriteLine("Nom-nom");
    }

    public class Dog : Animal     // derived
    {
        public void Voice() => Console.WriteLine("Hav!");
    }


}
