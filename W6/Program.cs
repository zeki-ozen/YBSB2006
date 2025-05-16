namespace W6_OOP
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceToOrigin()
          => Math.Sqrt(X * X + Y * Y);
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(3, 4);
            Console.WriteLine(p1.DistanceToOrigin()); // 5



            var art = new Article
            {
                Title = "C# 11 Features",
                Author = "Jane Doe",
                Published = DateTime.Today
            };

            // Print out art
            Console.WriteLine($"Title: {art.Title}");
            Console.WriteLine($"Author: {art.Author}");
            Console.WriteLine($"Published: {art.Published}");
            // art.Title = "C# 12 Features"; // Error: readonly property

            // Compiler error: Required members are not assigned
            // var bad = new Article();

            Console.WriteLine("\n--- Readonly Example ---");

            // Using the OgrenciProfil class            
            var ogrenci1 = new OgrenciProfil(1001);
            ogrenci1.Ad = "Ahmet";
            ogrenci1.Soyad = "Yılmaz";
            ogrenci1.BilgileriGoster();

            var ogrenci2 = new OgrenciProfil(1002, "Ayşe", "Kaya");
            ogrenci2.BilgileriGoster();

            // Name can be changed (normal property)
            ogrenci2.AdDegistir("Fatma");
            ogrenci2.BilgileriGoster();

            // OgrenciNo cannot be changed (readonly field)
            // ogrenci2.OgrenciNo = 2000; // Compilation error!
            // Koordinat struct example
            var konum = new Koordinat(3, 4);
            Console.WriteLine($"Koordinat: {konum}");
            Console.WriteLine($"Distance to center: {konum.MesafeHesapla()}");

            // Koordinat cannot be modified (readonly struct)
            // konum.X = 10; // Compilation error!

            Console.WriteLine("\n--- Partial Class Example ---");

            // Creating an Employee using the partial class
            var employee = new Employee(101, "John Smith");
            employee.DisplayBasicInfo();

            // Using methods from the second part of the partial class
            employee.SetEmploymentDetails(75000, "Software Development");
            employee.DisplayEmploymentDetails();

            // Using a method that combines functionality from both parts
            employee.DisplayAllInfo();
            // Creating a Manager that implements the partial interface
            var managerObj = new Manager();
            managerObj.CalculateTax();
            managerObj.CalculateBonus();

            Console.WriteLine("\n--- Partial Method Example ---");

            // Using the partial method example
            var processor = new DataProcessor();
            string result = processor.ProcessData("Hello 123 World");
            Console.WriteLine($"Processed result: {result}");
            // Note: Only PreProcessData will execute, PostProcessData is not implemented
            


            IEmployee manager = new Manager();
            manager.CalculateBonus();
            manager.CalculateTax();

            IEmployee developer = new Developer();
            developer.CalculateBonus();
            developer.CalculateTax();
        }
    }
}
