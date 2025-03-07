using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W2_Static_vs_Non_Static
{
    public class Counter
    {
        public static int StaticCount = 0;  // Static member
        public int NonStaticCount = 0;      // Non-static member

        public void Increment()
        {
            StaticCount++;
            NonStaticCount++;
        }




        public static void StaticMethod()
        {
            Console.WriteLine(StaticCount); // Allowed

            // Non-static members are not allowed in static methods
            // Console.WriteLine(NonStaticCount); // Not allowed (error)
        }

        public void InstanceMethod()
        {
            // Both static and non-static members are allowed in non-static methods
            Console.WriteLine(StaticCount);      // Allowed
            Console.WriteLine(NonStaticCount);   // Allowed
        }
    }
}
