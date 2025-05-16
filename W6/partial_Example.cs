using System;

namespace W6_OOP
{
    // This is the first part of the Employee class (Part 1)
    // The partial keyword allows splitting a class definition across multiple files
    public partial class Employee
    {
        // Fields
        private int _id;
        private string _name;
        private DateTime _hireDate;

        // Properties
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime HireDate { get => _hireDate; set => _hireDate = value; }

        // Constructor
        public Employee(int id, string name)
        {
            _id = id;
            _name = name;
            _hireDate = DateTime.Now;
        }

        // Basic methods in the first part
        public void DisplayBasicInfo()
        {
            Console.WriteLine($"Employee ID: {_id}");
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine($"Hire Date: {_hireDate.ToShortDateString()}");
        }
    }
}