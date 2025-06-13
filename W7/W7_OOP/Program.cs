namespace W7_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Student student = new Student();
            student.studentID = 1;
            student.studentName = "Fatih";
            student.studentSurname = "Sungur";
            */

            /*
            Student student = new Student(1, "Fatih", "Sungur");
            student.TakeExam();



            student = null; // Referansı bırak
            GC.Collect();   // Zorla GC'yi çağır
            GC.WaitForPendingFinalizers(); // Yıkıcıların çalışmasını bekle

            Console.WriteLine("Program bitti.");
            */

            // We can not create an instance of interface and abstract.
            // Person prsn = new Person();


            Worker isci = new Worker();
            isci.Work();
            isci.GetSalary();
            isci.LeaveVacation();


        }
    }
}
