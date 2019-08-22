using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstName = "Tom";
            // both of the below string examples are the same string type
            String lastName = "Blais";
            string myName = "Tom Blais";

            var fullName = firstName + " " + lastName;

            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "Tom", "Maddie", "Joe" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var test = "Hi John\nLook into the paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            Console.WriteLine(test);

            var testVerbatimString = @"Hi Tom
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(testVerbatimString);
        }
    }
}
