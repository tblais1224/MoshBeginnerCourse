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


            var timeSpan = new TimeSpan(1, 2, 3);

            //the next two lines are the same 
            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = System.DateTime.Now;
            var end = System.DateTime.Now.AddMinutes(12);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            //Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(3)));

            //to string
            Console.WriteLine("ToString: " + timeSpan.ToString());

            //parse
            Console.WriteLine("parse: " + TimeSpan.Parse("02:03:04"));
        }
    }
}
