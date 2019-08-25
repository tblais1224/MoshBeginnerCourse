using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new System.DateTime(2015, 1, 1);
            var now = System.DateTime.Now;
            var today = System.DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);


            //Sunday, August 25, 2019
            Console.WriteLine(now.ToLongDateString());
            //8/25/2019
            Console.WriteLine(now.ToShortDateString());
            //4:46:40 PM
            Console.WriteLine(now.ToLongTimeString());
            //4:46 PM
            Console.WriteLine(now.ToShortTimeString());
            //use formatter to get any desired format
            Console.WriteLine(now.ToString("yyyy-mm-dd"));
        }
    }
}
