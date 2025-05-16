using System;

namespace W6_OOP
{
    // This is the second part of the Employee class (Part 2)
    // The partial keyword allows adding more functionality to the same class
    public partial class Employee
    {
        // Additional fields for the second part
        private decimal _salary;
        private string _department;

        // Additional properties
        public decimal Salary { get => _salary; set => _salary = value; }
        public string Department { get => _department; set => _department = value; }

        // Methods specific to the second part
        public void SetEmploymentDetails(decimal salary, string department)
        {
            _salary = salary;
            _department = department;
        }

        public void DisplayEmploymentDetails()
        {
            Console.WriteLine($"Department: {_department}");
            Console.WriteLine($"Salary: ${_salary}");
        }

        // This method uses data from both parts of the class
        public void DisplayAllInfo()
        {
            Console.WriteLine("\n--- Employee Complete Information ---");
            DisplayBasicInfo();
            DisplayEmploymentDetails();
            Console.WriteLine($"Years of Service: {CalculateYearsOfService()}");
            Console.WriteLine("-------------------------------------");
        }

        // Private helper method
        private int CalculateYearsOfService()
        {
            return DateTime.Now.Year - HireDate.Year;
        }
    }

    
}
