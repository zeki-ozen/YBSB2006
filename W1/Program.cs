// OOP - W1
namespace OOP_W1_Class_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating instance from Person Class");
            // new keyword is used to create an instance of a class
            Person person1 = new Person();

            // Accessing-Setting the properties (data members) of the class
            person1.Name = "John";
            person1.Age = 25;

            // Accessing the methods of the class
            person1.Greet(); // Output: Hello, my name is John and I'm 25 years old.

            Console.WriteLine("");


            Console.WriteLine("Creating another instance from Person Class");
            // We can create multiple instances of the class
            Person person2 = new Person();
            person2.Name = "Bob";
            person2.Age = 30;
            person2.Greet(); // Output: Hello, my name is Bob and I'm 30 years old.
            Console.WriteLine("");



            Console.WriteLine("Creating another instance from Person Class");
            // We can also create an instance of the class using the object initializer syntax
            Person person3 = new Person() { Name = "Zeki", Age = 42 };
            person3.Greet(); // Output: Hello, my name is Zeki and I'm 42 years old.
            Console.WriteLine("");




            Console.WriteLine("Creating instance from Car Class");
            // Creating object from the Car class
            Car myCar = new Car();
            myCar.Make = "Toyota";
            myCar.Model = "Camry";
            myCar.Year = 2022;
            myCar.StartEngine(); // Output: The 2022 Toyota Camry engine has started.
            Console.WriteLine("");


            Console.WriteLine("Creating another instance from Car Class");
            Car anotherCar = new Car();
            anotherCar.Make = "Honda";
            anotherCar.Model = "Civic";
            anotherCar.Year = 2020;
            anotherCar.StartEngine(); // Output: The 2020 Honda Civic engine has started.
            Console.WriteLine("");



            // Create Car object using object initializer syntax


            Console.WriteLine("Creating instance from Book Class");
            // Creating object from the Book class
            Book myBook = new Book() { 
                Title = "1984", 
                Author = "George Orwell" 
            };
            myBook.DisplayInfo();

            Console.ReadLine();
        }
    }
}
