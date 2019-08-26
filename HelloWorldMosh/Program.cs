using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            //use defensive programming to catch bugs
            var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            var smallest = GetSmallests(numbers, 3);
            foreach (var num in smallest)
            {
                Console.WriteLine(num);
            }
        }

        public static List<int> GetSmallests(List<int> list, int count)
        {
            //catch a null list before executing code on it
            if (list == null)
            {
                throw new ArgumentNullException("list");
            }

            //catch count error here, tell user where error is, and prevent app from going in the wrong state
            if (count > list.Count || count <= 0)
            {
                throw new ArgumentOutOfRangeException("count", "Count must be between 1 and the number of elements in the list");
            }

            var buffer = new List<int>(list);
            var smallests = new List<int>();

            while (smallests.Count < count)
            {
                var min = GetSmallest(buffer);
                smallests.Add(min);
                buffer.Remove(min);
            }

            return smallests;
        }

        public static int GetSmallest(List<int> list)
        {
            //assume first num is smallest
            var min = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < min)
                {
                    min = list[i];
                }
            }

            return min;
        }
    }
}
