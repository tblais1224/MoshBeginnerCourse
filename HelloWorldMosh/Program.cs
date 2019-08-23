using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace Enums
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }
    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            // returns 3
            Console.WriteLine((int)method);

            var methodId = 3;
            //returns Express 
            Console.WriteLine((ShippingMethod)methodId);

            //returns Express
            Console.WriteLine(method.ToString());

            //returns Express
            Console.WriteLine(method);

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            // return Express
            Console.WriteLine(shippingMethod);
        }
    }
}
