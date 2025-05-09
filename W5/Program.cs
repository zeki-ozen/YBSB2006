namespace W5_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VAT Calculator Examples:");
            // Creating a VAT_Calculator instance
            VAT_Calculator calculator = new VAT_Calculator();

            // Using methods with both price and VAT parameters
            Console.WriteLine($"Calc with int: {calculator.Calc(100, 18)}");
            Console.WriteLine($"Calc with double: {calculator.Calc(100.50, 18.5)}");
            Console.WriteLine($"Calc with float: {calculator.Calc(100.25f, 18.0f)}");

            // Using methods with only price (default VAT is used)
            Console.WriteLine($"Calc with int (default VAT): {calculator.Calc(100)}");
            Console.WriteLine($"Calc with double (default VAT): {calculator.Calc(100.50)}");
            Console.WriteLine($"Calc with float (default VAT): {calculator.Calc(100.25f)}");

            Console.WriteLine("\nOperator Overloading Example (% operator):");
            
            // Creating StringConcat objects
            StringConcat s1 = new StringConcat("C# ");
            StringConcat s2 = new StringConcat("Programming");
            
            // Concatenation using % operator between two StringConcat objects
            StringConcat result = s1 % s2;
            Console.WriteLine($"s1 % s2 = {result}"); // Output: C# Programming
            
            // Concatenation using % operator between StringConcat and string
            StringConcat result2 = s1 % "Language";
            Console.WriteLine($"s1 % \"Language\" = {result2}"); // Output: C# Language
            
            // Concatenation using % operator between string and StringConcat
            StringConcat result3 = "Object Oriented " % s2;
            Console.WriteLine($"\"Object Oriented \" % s2 = {result3}"); // Output: Object Oriented Programming
            
            // Chaining operations with % operator
            StringConcat result4 = s1 % s2 % "!";
            Console.WriteLine($"s1 % s2 % \"!\" = {result4}"); // Output: C# Programming!

            // Creating a StringConcat object with two strings
            StringConcat s3 = new StringConcat("Turkey ", "Republic");
            Console.WriteLine($"Concatenated two strings: {s3}"); // Output: Turkey Republic


            // Create an instance of abstract class Circle
            AbstractCircle circle = new AbstractCircle(5.0);
            Console.WriteLine($"Circle Area: {circle.Area()}"); // Output: Circle Area: 78.53981633974483

            // Create an instance of abstract class Rectangle
            Rectangle rectangle = new Rectangle(4.0, 6.0);
            Console.WriteLine($"Rectangle Area: {rectangle.Area()}"); // Output: Rectangle Area: 24.0


            // Create an instance of Class implementing the interface 
            IShape circleShape = new InterfaceCircle(3.0);
            IShape rectangleShape = new Rectangle(4.0, 5.0);
            circleShape.Display(); // Output: Circle - Radius: 3, Area: 28.27
            rectangleShape.Display(); // Output: Rectangle - Width: 4, Height: 5, Area: 20.00

            // the interface type to store different shapes
            List<IShape> shapes = new List<IShape>();
            shapes.Add(new InterfaceCircle(2.0));
            shapes.Add(new Rectangle(3.0, 4.0));
            foreach (var shape in shapes)
            {
                shape.Display(); // Calls the appropriate Display method for each shape
            }


            // example of Dynamic Polymorphism with dynamic keyword
            dynamic dynCircle = new InterfaceCircle(2.0);
            dynamic dynRectangle = new Rectangle(3.0, 4.0);
            Console.WriteLine($"Dynamic Circle Area: {dynCircle.Area()}"); // Output: Dynamic Circle Area: 12.566370614359172
            Console.WriteLine($"Dynamic Rectangle Area: {dynRectangle.Area()}"); // Output: Dynamic Rectangle Area: 12.0

            // example of upcasting and downcasting
            Shape shape1 = new Circle(5.0); // Upcasting
            Console.WriteLine($"Upcasting Circle Area: {shape1.Area()}"); // Output: Upcasting Circle Area: 78.53981633974483

            // Downcasting
            if (shape1 is Circle circleShape1)
            {
                Console.WriteLine($"Downcasting Circle Area: {circleShape1.Area()}"); // Output: Downcasting Circle Area: 78.53981633974483
            }
            else
            {
                Console.WriteLine("Downcasting failed.");
            }


        }
    }
}
