using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };
            numbers.Add(1);
            //iEnumerable means you can use array or list (when hovering over addrange)
            numbers.AddRange(new int[3] { 5, 6, 7 });
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //start index from beggining 
            Console.WriteLine("\nIndex of 1: " + numbers.IndexOf(1));
            //start indexing from end
            Console.WriteLine("\nLast Index of 1: " + numbers.LastIndexOf(1));
            //numbers in list
            Console.WriteLine("\nCount of list: " + numbers.Count);

            //removes 1s
            //foreach wont work because length of numbers changes, use for loop
            /*            foreach (var num in numbers)
                        {
                            if (num == 1)
                            {
                                numbers.Remove(num);
                            }
                        }*/
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            foreach (var number2 in numbers)
            {
                Console.WriteLine(number2);
            }

            //clears list
            numbers.Clear();
            Console.WriteLine("\n Count after clear: " + numbers.Count);
        }
    }
}
