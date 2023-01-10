using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

        public class GFG
        {

            // Generics method
            public void Display<Z>(string msg, Z value)
            {
                Console.WriteLine("{0}:{1}", msg, value);
            }
        }

        // Driver class
        public class Example
        {

            // Main Method
            public static int Main()
            {

                // creating object of class GFG
                GFG p = new GFG();

                // calling Generics method
                p.Display<int>("Integer", 122);
                p.Display<char>("Character", 'H');
                p.Display<double>("Decimal", 255.67);
                return 0;
            }
        }
}
