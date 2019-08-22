using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace RefAndValTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            // creates two memory locations in the stack
            var b = a;
            b++;

            // returns a = 10 and b = 11
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

            var array1 = new int[3] { 1, 2, 3 };
            // both arrays in the stack will point to same object in memory heap
            var array2 = array1;
            // this will change both arrays
            array2[0] = 0;
            // both 1 and 2 will return 0
            Console.WriteLine(string.Format("1[0]: {0}, 2[0]: {1}", array1[0], array2[0]));

        }
    }
}
