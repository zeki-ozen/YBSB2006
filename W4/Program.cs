namespace W4
{

    internal class Program
    {
        static void Main(string[] args)
        {

            Child child = new Child();


            /*
            // Create an instance of Car
            Car myCar = new Car("Toyota", "Corolla", 2020);
            myCar.Start();
            myCar.Stop();
            myCar.getInfo();

            // Attempt to access private members
            /*
            myCar.DisplayYear(); // This will cause a compile-time error
            myCar.RunningStatus(); // This will cause a compile-time error
            myCar.Gear = 1; // This will cause a compile-time error
            myCar.IsRunning = true; // This will cause a compile-time error
            myCar.Year = 2021; // This will cause a compile-time error
            myCar.Model = "Camry"; // This will cause a compile-time error
            */

            /*
            // Create an instance of ElectricCar
            ElectricCar myElectricCar = new ElectricCar("Tesla", "Model S", 2021, 100);
            myElectricCar.Start();
            myElectricCar.Stop();
            myElectricCar.getInfo();
            myElectricCar.DisplayBatteryStatus();



            // Create an instance of SportCar
            SportCar mySportCar = new SportCar("Porsche", "911", "Sport", 2023);
            mySportCar.Horsepower = 450;
            mySportCar.TransmissionType = "Automatic";
            mySportCar.Start();
            mySportCar.TurboBoost();
            mySportCar.getInfo();

            // use parent methods
            mySportCar.Stop(); // Inherited from Car
            */




            // Attempt to create an instance of AttemptedChild
            // AttemptedChild myAttemptedChild = new AttemptedChild(); // This will cause a compile-time error
            // myAttemptedChild.DoSomething(); // This will not compile
            // myAttemptedChild.DoSomethingElse(); // This will not compile


            // Order of Constructor
            // B b = new B();



        }
    }
}
