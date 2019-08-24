using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 3, 5, 6, 3, 14, 6 };
            //length
            Console.WriteLine("Length: " + numbers.Length);

            //index
            var index = Array.IndexOf(numbers, 14);
            Console.WriteLine("Index: " + index);

            //clear
            Array.Clear(numbers, 0, 2);
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            //copy
            int[] another = new int[4];
            Array.Copy(numbers, another, 4);
            Console.WriteLine("Copy effect: ");
            foreach (var n in another)
            {
                Console.WriteLine(n);
            }

            //sort
            Array.Sort(numbers);
            foreach (var sorted in numbers)
            {
                Console.WriteLine(sorted);
            }

            //reverse
            Array.Reverse(numbers);
            foreach (var reversed in numbers)
            {
                Console.WriteLine(reversed);
            }


        }
    }
}
