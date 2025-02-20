// OOP - W1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_W1_Class_Example
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"\"{Title}\" by {Author}");
        }
    }
}
