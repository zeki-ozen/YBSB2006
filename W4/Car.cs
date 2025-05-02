using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public class Car
    {
        public string Brand { get; set; }
        protected string Model { get; set; }
        private int Year { get; set; }
        protected int Gear { get; set; }
        protected bool IsRunning { get; set; }

        public string EnergyType = "Petrol"; // Backing field for EnergyType property  
   
        public virtual void Start() // Marked as virtual to allow overriding  
        {
            Console.WriteLine("The car is starting...");
        }

        public virtual void Stop() // Marked as virtual to allow overriding  
        {
            Console.WriteLine("The car is stopping...");
        }

        public void getInfo()
        {
            Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
        }

        protected void RunningStatus()
        {
            Console.WriteLine(IsRunning ? "The car is running." : "The car is not running.");
        }

        private void DisplayYear()
        {
            Console.WriteLine($"Year: {Year}");
        }

        // Constructor
        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Gear = 0;
        }
    }

}
