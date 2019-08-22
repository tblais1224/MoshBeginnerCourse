using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            //2, 4, 8, 10
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("\n");
            // 10, 8, 4, 2
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


            Console.WriteLine("\n");
            //prints all letters in name
            var name = "Tom Blais";
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }

            Console.WriteLine("\n");
            //also prints all letters in name
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }



            Console.WriteLine("\n");
            //prints all numbers in array
            var numbers = new int[] { 1, 2, 3, 4 };
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }



            Console.WriteLine("\n");
            //does same as first above for loop
            var j = 1;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }
                j++;
            }

            Console.WriteLine("\n");
            while (true)
            {
                Console.WriteLine("type your name");
            }
        }
    }
}
