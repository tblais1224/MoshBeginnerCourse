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
            byte number = 2;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'a';
            string firstName = "Tom";
            bool isWorking = true;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);

            // below returns 0 255
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            // below returns -3.402823E+38 3.402823E+38
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
            
        }
    }
}
