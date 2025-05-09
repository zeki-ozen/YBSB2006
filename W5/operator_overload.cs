using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W5_Polymorphism
{
    public class StringConcat
    {
        private string text;

        // Constructor taking two strings
        public StringConcat(string value1, string value2)
        {
            text = value1 + value2;
        }

        // Constructor taking a single string
        public StringConcat(string value)
        {
            text = value;
        }

        // returns the concatenated string
        public override string ToString()
        {
            return text;
        }

        // overload % operator for StringConcat objects
        public static StringConcat operator %(StringConcat sc1, StringConcat sc2)
        {
            return new StringConcat(sc1.text + sc2.text);
        }

        // overload % operator for StringConcat and string
        public static StringConcat operator %(StringConcat sc, string str)
        {
            return new StringConcat(sc.text + str);
        }

        // overload % operator for string and StringConcat
        public static StringConcat operator %(string str, StringConcat sc)
        {
            return new StringConcat(str + sc.text);
        }
    }
}