// filepath: c:\Users\ozen\source\repos\W6_OOP\readonly_Example.cs
using System;

namespace W6_OOP
{
    // Example of using the readonly keyword
    public class OgrenciProfil
    {
        // readonly field: can only be assigned a value in the constructor or at field declaration
        public readonly int OgrenciNo;
        public readonly string KayitTarihi;          // Normal properties - defined as nullable
        public string? Ad { get; set; }
        public string? Soyad { get; set; }
        
        // readonly property: only has a getter
        public string TamAd => $"{Ad} {Soyad}";
        
        // Different constructor types
        public OgrenciProfil(int ogrenciNo)
        {
            // readonly field can be assigned a value in the constructor
            OgrenciNo = ogrenciNo;
            KayitTarihi = DateTime.Now.ToString("dd.MM.yyyy");
        }
          public OgrenciProfil(int ogrenciNo, string ad, string soyad) : this(ogrenciNo)
        {
            Ad = ad;
            Soyad = soyad;
        }
        
        public void BilgileriGoster()
        {
            Console.WriteLine($"Öğrenci No: {OgrenciNo}");
            Console.WriteLine($"Ad Soyad: {TamAd}");
            Console.WriteLine($"Kayıt Tarihi: {KayitTarihi}");
            Console.WriteLine("---------------------");
        }
        
        public void AdDegistir(string yeniAd)
        {
            // Normal property can be changed
            Ad = yeniAd;
            
            // This would cause an error, readonly field cannot be changed outside constructor
            // OgrenciNo = 5555;
        }    }
    
    // readonly struct example: the entire struct becomes immutable
    public readonly struct Koordinat
    {
        public readonly double X { get; }
        public readonly double Y { get; }
        
        public Koordinat(double x, double y)
        {
            X = x;
            Y = y;
        }
        
        // readonly method: guarantees that it won't modify the struct's state
        public readonly double MesafeHesapla() => Math.Sqrt(X * X + Y * Y);
        
        public readonly override string ToString() => $"({X}, {Y})";
    }
}