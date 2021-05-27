using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_dimentional_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] names = { { "fred", "willma" }, { "blogs", "smith" },{ "doctor", "mr" } };
            Console.WriteLine("{0} {1} {2}", names[2, 0], names[0, 1], names[1, 1]);
        }
    }
}
