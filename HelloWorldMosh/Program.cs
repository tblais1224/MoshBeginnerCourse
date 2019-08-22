using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("Its morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("its afternoon");
            }
            else
            {
                Console.WriteLine("Its evenign");
            }

            //ternary
            bool isGoldCustomer = true;
            float price = (isGoldCustomer) ? 19.95f : 29.95f;
            Console.WriteLine(price);

            var season = Season.Autumn;
            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its Autumn");
                    break;
                case Season.Summer:
                    Console.WriteLine("Its summer");

                    break;
                default:
                    Console.WriteLine("Dont understand");
                    break;
            }


            var season1 = Season.Autumn;
            switch (season1)
            {
                case Season.Autumn:
                case Season.Summer:
                    Console.WriteLine("seasons are working");
                    break;
                default:
                    Console.WriteLine("Dont understand");
                    break;
            }
        }
    }
}
