using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Strings2
{
    class Program
    {
        static void Main(string[] args)
        {
            var fullName = "Tom Blais    ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine("fname: " + firstName);
            Console.WriteLine("lname: " + lastName);


            var names = fullName.Split(' ');
            Console.WriteLine("Fname: " + names[0]);
            Console.WriteLine("Lname: " + names[1]);


            Console.WriteLine(fullName.Replace("Tom", "Maddie"));

            if (String.IsNullOrWhiteSpace(" "))
            {
                Console.WriteLine("invalid");
            }

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            //the C will convert to dollar sign
            Console.WriteLine(price.ToString("C")
            );
            // round to whole dollars
            Console.WriteLine(price.ToString("C0")
            );
        }
    }
}