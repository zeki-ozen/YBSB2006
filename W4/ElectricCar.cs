using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public class ElectricCar : Car
    {
        private int BatteryCapacity { get; set; }

        private void ChargeBattery()
        {
            Console.WriteLine("The battery is charging...");
        }

        // Override the Start method to include electric car behavior
        public override void Start()
        {
            base.Start(); // Call the base class Start method
            Console.WriteLine($"Starting the electric car.");
        }

        // Override the Stop method to include electric car behavior
        public override void Stop()
        {
            Console.WriteLine("The electric car is stopping silently...");
        }

        // Method specific to ElectricCar
        public void DisplayBatteryStatus()
        {
            Console.WriteLine($"The battery capacity is {BatteryCapacity} kWh.");
        }

        // Constructor
        public ElectricCar(string brand, string model, int year, int batteryCapacity) : base(brand, model, year)
        {
            BatteryCapacity = batteryCapacity;
           
        }



    }

}
