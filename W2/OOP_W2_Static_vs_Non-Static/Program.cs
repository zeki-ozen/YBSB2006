namespace OOP_W2_Static_vs_Non_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Usage
            Counter c1 = new Counter();
            Counter c2 = new Counter();

            c1.Increment();
            c2.Increment();

            
            Console.WriteLine("c1 NonStaticCount: " + c1.NonStaticCount); // Output: 1
            Console.WriteLine("c2 NonStaticCount: " + c2.NonStaticCount); // Output: 1
            Console.WriteLine("Static Count (Counter): " + Counter.StaticCount);  // Output: 2
        }
    }
}
