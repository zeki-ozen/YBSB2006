using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W2
{
    class Staff
    {

        // Public fields (class variables)
        // these are instance variables
        public string firstName;
        public string lastName;
        public string email;
        public string department;
        public string Position { get; set; }


        // This is a static variable
        public static int staffId = 0; // Static field shared by all instances
        // Another static variable
        public static string companyName;


        // Private fields for sensitive data
        private DateTime dateOfBirth;
        private DateTime hireDate;
        private decimal salary;

        // First way to use property (auto-implemented property)
        public string LastName { get; set; }

        // Second way to use property
        public int StaffId
        {
            get { return staffId; }
            set { staffId = value; }
        }

        // Third way to use property 
        public string FirstName
        {
            get => firstName;
            set => firstName = value;
        }


        //Field backed properties
        // The field keyword is a preview feature in C# 13.0.
        // In order to use this keyword,
        // You must be using .NET 9 and
        // set your <LangVersion> element to preview in your project file
        /*
        public string Email
        {
            get;
            set => field = value.ToLower().Trim();
        }
        */

        // Properties with controlled access for sensitive data
        public DateTime DateOfBirth
        {
            get => dateOfBirth;
            set => dateOfBirth = value;
        }

        public DateTime HireDate
        {
            get => hireDate;
            set => hireDate = value;
        }

        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }


        // Method example
        // Calculate the working years of the staff
        public int WorkingYears()
        {
            return DateTime.Now.Year - hireDate.Year;
        }


        /* Constructor Methods */

        /*
        // Constructor method (default constructor)
        public Staff()
        {
            staffId++; // Increment the staffId by 1
        }


        // Constructor method (parameterized constructor)
        public Staff(string firstName, string lastName, string email, string department, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.department = department;
            Position = position;
            staffId++; // Increment the staffId by 1
        }


        // Constructor method (static constructor)
        static Staff()
        {
            // Initialize the static variable (Company Name)
            companyName = "Istanbul University";
            // print company name
            Console.WriteLine($"Company Name: {companyName}");
        }


        // Constructor method (Copy constructor)
        public Staff(Staff existingStaff)
        {
            firstName = existingStaff.firstName;
            // or using this keyword
            // this.firstName = existingStaff.firstName;
            this.lastName = existingStaff.lastName;
            this.email = existingStaff.email;
            this.department = existingStaff.department;
            Position = existingStaff.Position;
            staffId++; // Increment the staffId by 1
        }


        // create static method (can be accessed without creating an instance of the class)
        public static void PrintCompanyName()
        {
            Console.WriteLine($"Company Name: {companyName}");
        }

        */
    }
}
