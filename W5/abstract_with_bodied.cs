using System;

// Examples of abstract methods with implementation body
namespace W5_Polymorphism
{
    // Defining an abstract class named Shape
    public abstract class Sekil
    {
        // Abstract property - contains no implementation
        public abstract string Ad { get; }

        // Abstract method - no implementation
        public abstract double AlanHesapla();

        // Abstract method - no implementation
        public abstract double CevreHesapla();

        // Virtual method - common information printing for all shapes
        public virtual void BilgiYazdir() => 
            Console.WriteLine($"Şekil: {Ad}, Alan: {AlanHesapla()}, Çevre: {CevreHesapla()}");
    }    // Circle class - derived from Shape class
    public class Daire : Sekil
    {
        private readonly double _yaricap;

        public Daire(double yaricap)
        {
            _yaricap = yaricap;
        }

        // Overriding the abstract property
        public override string Ad => "Daire";

        // Overriding the abstract method with body
        public override double AlanHesapla() => Math.PI * _yaricap * _yaricap;

        // Overriding the abstract method with body
        public override double CevreHesapla() => 2 * Math.PI * _yaricap;
    }    // Rectangle class - derived from Shape class
    public class Dikdortgen : Sekil
    {
        private readonly double _genislik;
        private readonly double _yukseklik;

        public Dikdortgen(double genislik, double yukseklik)
        {
            _genislik = genislik;
            _yukseklik = yukseklik;
        }

        // Overriding the abstract property
        public override string Ad => "Dikdörtgen";

        // Overriding the abstract method with body
        public override double AlanHesapla() => _genislik * _yukseklik;

        // Overriding the abstract method with body
        public override double CevreHesapla() => 2 * (_genislik + _yukseklik);
    }    // Triangle class - uses default implementation and overrides only necessary methods
    public class Ucgen : Sekil
    {
        private readonly double _kenar1;
        private readonly double _kenar2;
        private readonly double _kenar3;

        public Ucgen(double kenar1, double kenar2, double kenar3)
        {
            _kenar1 = kenar1;
            _kenar2 = kenar2;
            _kenar3 = kenar3;
        }

        // Overriding the abstract property
        public override string Ad => "Üçgen";

        // Overriding the abstract method with body
        public override double CevreHesapla() => _kenar1 + _kenar2 + _kenar3;

        // Calculating the area of triangle using Heron's formula
        public override double AlanHesapla()
        {
            double s = CevreHesapla() / 2;
            return Math.Sqrt(s * (s - _kenar1) * (s - _kenar2) * (s - _kenar3));
        }
    }    // Example class with a method to demonstrate the usage
    public class AbstractBodyOrnek
    {
        public static void Calistir()
        {
            Console.WriteLine("Abstract Method with Body Example\n");

            Sekil[] sekiller = new Sekil[]
            {
                new Daire(5),
                new Dikdortgen(4, 6),
                new Ucgen(3, 4, 5)
            };

            foreach (var sekil in sekiller)
            {
                sekil.BilgiYazdir();
            }

            Console.WriteLine();
        }
    }
}