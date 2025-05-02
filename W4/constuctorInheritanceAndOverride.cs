using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
    }

    public class Student : Person
    {
        public int Id;
        public Student(string name, int id) : base(name)
        {
            this.Id = id;
        }
    }
}
