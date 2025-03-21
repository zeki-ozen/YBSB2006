namespace AccessModifierExample
{


    public class Program
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("12345", 1000, "John Doe", "Acme Bank", "Main");
            account.Deposit(500);
            account.Withdraw(200);
            Console.WriteLine($"Balance: {account.GetBalance()}"); // Accessing balance through a public method

            // account._balance = 5000; // Error: _balance is inaccessible due to its protection level (private)
            // account.OwnerName = ""; // Error: OwnerName is inaccessible due to its protection level (protected)

            SavingsAccount savingsAccount = new SavingsAccount("67890", 2000, "Jane Smith", "Acme Bank", "Downtown", 0.05m);
            savingsAccount.ApplyInterest();
            Console.WriteLine($"Savings Account Balance: {savingsAccount.GetBalance()}");
            Console.WriteLine($"Bank Name: {savingsAccount.BankName}"); // Ok, internal accessible.
                                                                        //Console.WriteLine($"Internal Id: {savingsAccount.InternalId}"); // Error, private protected.

            // Accessing AccountNumber's getter is allowed, but the setter is private:
            Console.WriteLine(account.AccountNumber);
            // account.AccountNumber = "54321"; // Error:  'BankAccount.AccountNumber.set' accessor is inaccessible



            /*
            Car car = new Car();
            SportsCar sportsCar = new SportsCar();

            // Accessing public members
            Console.WriteLine("Accessing public members from Car object:");
            Console.WriteLine($"Model: {car.Model}");

            // Accessing private members (will cause error)
            // Console.WriteLine(car.speed); // Error: 'Car.speed' is inaccessible due to its protection level

            // Accessing internal members (accessible within the same assembly)
            Console.WriteLine($"Year: {car.Year}");

            // Accessing protected internal members (accessible within the same assembly)
            Console.WriteLine($"Owner: {car.Owner}");

            // Displaying information from derived class
            Console.WriteLine("\nAccessing members from SportsCar object:");
            sportsCar.DisplaySportsCarInfo();

            */


            /*

    Output:


    Accessing public members from Car object:
    Model: Toyota
    Year: 2020
    Owner: Alice

    Accessing members from SportsCar object:
    Model: Toyota
    Color: Red
    Year: 2020
    Owner: Alice
    Mileage: 5000
    Explanation:

    The public member Model is accessible everywhere.
    The private member speed is only accessible within the Car class.
    The protected member Color is accessible in the Car class and its derived class SportsCar.
    The internal member Year is accessible within the same assembly.
    The protected internal member Owner is accessible within the same assembly and in derived classes.
    The private protected member Mileage is accessible only within the Car class and derived classes in the same assembly.
            */
        }
    }

}