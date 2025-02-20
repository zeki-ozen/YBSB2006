// OOP - W1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W1_Class_Example
{
    class Person
    {
        // Properties (data members)
        public string Name;
        public int Age;
        // Methods (behaviors)
        public void Greet()
        {
            Console.WriteLine($"Hello, my name is {Name} and I'm {Age} years old.");
        }

    }
}
