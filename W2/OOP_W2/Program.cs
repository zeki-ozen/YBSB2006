namespace OOP_W2
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Creating an instance of the Staff class");

            // Creating an instance of the Staff class
            Staff staff = new Staff();

            // Set value to public fields directly
            staff.firstName = "Zeki";
            staff.lastName = "Özen";
            staff.StaffId = 1;

            /***** Set Properties *****/
            // Set the public properties
            staff.FirstName = "Zeki";
            staff.LastName = "Ozen";





            // Set the private properties
            // belowing lines throw an error because of the private setter
            // staff.dateOfBirth = new DateTime(1990, 1, 1);
            // staff.hireDate = new DateTime(2010, 1, 1);
            // staff.salary = 50000;

            // To set value to private properties, we need to use the public methods
            staff.DateOfBirth = new DateTime(1990, 1, 1);
            // set staff hire date
            staff.HireDate = new DateTime(2010, 1, 1);


            // Get staff ID
            int staffId = staff.StaffId;
            Console.WriteLine($"Staff ID: {staffId}");

            // get staff' first name directly (without property)
            string staffName = staff.firstName;
            Console.WriteLine($"Staff name: {staffName}");

            /***** Get Properties *****/
            // get staff' first name indirectly (using get accessor)
            string staffName2 = staff.FirstName;
            Console.WriteLine($"Staff name: {staffName2}");

            /*
            // get staff' last name directly (without property)
            string staffLastName = staff.lastName;
            // get staff' last name indirectly (using get accessor)
            string staffLastName2 = staff.LastName;
            */

            // get staff' hire date
            DateTime hireDate = staff.HireDate;
            // print staff hire date dd/MM/yyyy
            Console.WriteLine($"Staff hire date: {hireDate.ToString("dd/MM/yyyy")}");


            // Invoke the public method
            // calculate work experience of the staff using WorkingYears method
            int workExperience = staff.WorkingYears();
            Console.WriteLine($"Work experience of the staff: {workExperience} years");




            // Create yourself as a new staff
        }
    }

}