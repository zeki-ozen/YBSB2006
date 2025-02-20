// OOP - W1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W1_Class_Example
{
    public class Car
    {
        public string Make;
        public string Model;
        public int Year;

        public void StartEngine()
        {
            Console.WriteLine($"The {Year} {Make} {Model} engine has started.");
        }
    }
}
