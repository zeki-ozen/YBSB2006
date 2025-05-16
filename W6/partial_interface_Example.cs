using System;

namespace W6_OOP
{

// Example of partial interface
    public partial interface IEmployee
    {
        void CalculateTax();
    }

    // Second part of the partial interface
    public partial interface IEmployee
    {
        void CalculateBonus();
    }

    // Implementing the partial interface
    public class Manager : IEmployee
    {
        public void CalculateBonus()
        {
            Console.WriteLine("Manager bonus calculated");
        }

        public void CalculateTax()
        {
            Console.WriteLine("Manager tax calculated");
        }
    }
    public class Developer : IEmployee
    {
        public void CalculateBonus()
        {
            Console.WriteLine("Developer bonus calculated");
        }

        public void CalculateTax()
        {
            Console.WriteLine("Developer tax calculated");
        }
    }
}