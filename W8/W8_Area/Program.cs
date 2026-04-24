using OOP_WEEK8;

namespace W8_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area alan1 = new Area(5); // Square
            Console.WriteLine("Square area: " + alan1.area);


            Area alan2 = new Area(5, 4); // Rectangle
            Console.WriteLine("Rectangle area: " + alan2.area);


            Area alan3 = new Area("r", 3); // Circle
            Console.WriteLine("Circle area: " + alan3.area);


            SpecialArea alan4 = new SpecialArea(5);
            Console.WriteLine("Cube area: " + alan4.area);

            
            Area alan5 = new SpecialArea(5);
            Console.WriteLine("Cube area: " + alan5.area);
            



            // Upcasting
            Shape cisim = new SpecialShape();
            cisim.Draw(); // SpecialShape çizildi


            // cisim.SpecialMethod(); // ❌ HATA!

            // Çözüm
            if (cisim is SpecialShape special)
            {
                special.SpecialMethod();
            }


            /* Scenario: The business force to write for each department to build a class named AcmeCoop that should include a method Info and Display. 
 * Tip: Abstract or Interface structure should be used.
 */

            // AcmeCoop acme = new AcmeCoop();  // interface in örneği oluşturulamaz

            Department1 department1 = new Department1();
            department1.Info();
            department1.Display();

            Department2 department2 = new Department2();
            department2.Info();
            department2.Display();
        }
    }
}
