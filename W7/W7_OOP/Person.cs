using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7_OOP
{
    internal interface Person
    {
        void Work();
        void GetSalary();
        void LeaveVacation();
  
    }

    internal class Worker : Person
    {
        public void Work()
        {
            Console.WriteLine("Worker is working");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker is getting his/her salary.");
        }

        public void LeaveVacation()
        {
            Console.WriteLine("Worker is now at the vacation.");
        }

    }

}
