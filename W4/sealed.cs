using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4
{
    public sealed class FinalClass
    {
        public void DoSomething()
        {
            Console.WriteLine("Cannot be overridden");
        }

        // create sealed method


    }
    // Error: Cannot derive from sealed type 'FinalClass'
    public class AttemptedChild : FinalClass
    {
        // This class cannot inherit from FinalClass because it is sealed
        public void DoSomethingElse()
        {
            Console.WriteLine("This will not compile");
        }
    }

}
