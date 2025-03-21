using System;
namespace AccessModifierExample
{
    public class Car
    {
        public string Model = "Toyota";               // Accessible everywhere
        private int speed = 0;                        // Accessible only within Car class
        protected string Color = "Red";               // Accessible in Car and derived classes
        internal int Year = 2020;                     // Accessible within the same assembly
        protected internal string Owner = "Alice";    // Accessible in same assembly and derived classes
        private protected int Mileage = 5000;         // Accessible in Car and derived classes in same assembly

        // Method to demonstrate access within the class
        public void DisplayCarInfo()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Speed: {speed}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Owner: {Owner}");
            Console.WriteLine($"Mileage: {Mileage}");
        }
    }

    public class SportsCar : Car
    {
        public void DisplaySportsCarInfo()
        {
            // Model is public, so accessible
            Console.WriteLine($"Model: {Model}");

            // speed is private, so NOT accessible
            Console.WriteLine(speed); // Error: 'Car.speed' is inaccessible due to its protection level

            // Color is protected, so accessible in derived class
            Console.WriteLine($"Color: {Color}");

            // Year is internal, so accessible within the same assembly
            Console.WriteLine($"Year: {Year}");

            // Owner is protected internal, so accessible
            Console.WriteLine($"Owner: {Owner}");

            // Mileage is private protected, so accessible within the same assembly
            Console.WriteLine($"Mileage: {Mileage}");
        }

    }
}

