namespace W4
{
    public class SportCar : Car
    {
        public string Make { get; set; }
        public int Year { get; set; }
        public int Horsepower { get; set; }
        public string TransmissionType { get; set; } = "Automatic"; // Default value to avoid null

        /*
        // Constructor with three arguments
        public SportCar(string brand, string make, string model, int year) : base(brand)
        {
            Make = make;
            Model = model;
            Year = year;
            TransmissionType = "Automatic"; // Default value for TransmissionType
        }
        */
        public void Start()
        {
            Console.WriteLine("SportCar is starting...");
        }

        public void TurboBoost()
        {
            Console.WriteLine("Turbo boost activated!");
        }

        public void getInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, Year: {Year}, Horsepower: {Horsepower}, Transmission: {TransmissionType}");
        }
    }
}