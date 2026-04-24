using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace OOP_WEEK8
{
    internal interface AcmeCoop
    {
        public void Info();

        public void Display()
        {
            Console.WriteLine("Departmen1 için Display oluşturuldu.");
        }

    }

    internal class Department1() : AcmeCoop
    {
        public void Info()
        {
            Console.WriteLine("Department1 Info oluşturuldu");
        }
        public void Display()
        {
            Console.WriteLine("Departmen1 için Display oluşturuldu.");
        }
    }
    internal class Department2 : AcmeCoop
    {
        public void Welcome()
        {
            string className = MethodBase.GetCurrentMethod().DeclaringType.Name;
            Console.WriteLine($"Welcome to {className}");
        }
        public void Info()
        {
            Console.WriteLine("Department2 Info oluşturuldu");
        }
        public void Display()
        {
            Console.WriteLine("Departmen2 için Display oluşturuldu.");
        }
    }
    //internal class Department3(): AcmeCoop { }

}
