using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_Polymorphism
{
    internal class VAT_Calculator
    {
        public double VAT { get; set; }

        // vat default value is 18.0
        public VAT_Calculator()
        {
            VAT = 18.0;
        }

        // Method for int parameters
        public int Calc(int price, int vat)
        {
            return price + (price * vat / 100);
        }

        // Method for double parameters
        public double Calc(double price, double vat)
        {
            return price + (price * vat / 100);
        }

        // Method for float parameters
        public float Calc(float price, float vat)
        {
            return price + (price * vat / 100);
        }




        // Overloaded methods that use the default VAT value

        // Method for int price with default VAT
        public int Calc(int price)
        {
            return price + (int)(price * VAT / 100);
        }

        // Method for double price with default VAT
        public double Calc(double price)
        {
            return price + (price * VAT / 100);
        }

        // Method for float price with default VAT
        public float Calc(float price)
        {
            return price + (float)(price * VAT / 100);
        }
    }
}
