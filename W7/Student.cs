using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W7_OOP
{
    internal class Student
    {
        public int studentID;
        public string studentName;
        public string studentSurname;

        
        public Student(int stdntID, string name, string surname)
        {
            // mysql.Connect(username, pass, IP, port, database, schema, table);
            studentID = stdntID;
            studentName = name;
            studentSurname = surname;
            Console.WriteLine("Student class created.");
        }

        public Student(double stdntID, string name, string surname)
        {
            studentID = Convert.ToInt32( stdntID);
            studentName = name;
            studentSurname = surname;
            Console.WriteLine("Student class created.");
        }


        public void TakeExam()
        {
            Console.WriteLine($"{this.studentName} takes an exam");
        }

        // Destructor example
        ~Student() {
            Console.WriteLine("Student class destructed.");
            // mysql.Close();
        }
    }
}
