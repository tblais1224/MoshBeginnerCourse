using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;
            // normal math order is followed, multiplication and division then add and subtract
            //returns 7
            Console.WriteLine(a + b * c);
            //returns false
            Console.WriteLine(a > b);
            //returns true
            Console.WriteLine(a != b);
            //returns false
            Console.WriteLine(!(a != b));
            //returns false
            Console.WriteLine(c > b && c == a);
            // returns true
            Console.WriteLine(c > b || c == a);
        }
    }
}
