using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int integer = b;
            Console.WriteLine(integer);

            int i = 1000;
            byte by = (byte)i;
            //returns 232
            Console.WriteLine(by);

            var number = "1234";
            int iNum = Convert.ToInt32(number);
            Console.WriteLine(iNum);



            try
            {
                //this will result in overflow error, so catch will be run   n  
                var number3 = "1234";
                byte iNum3 = Convert.ToByte(number3);
                Console.WriteLine(iNum3);
            }
            catch (Exception)
            {
                Console.WriteLine("the number could not be converted to a byte");
            }

            try
            {
                //this will run the try and avoid a catch error
                string str = "true";
                bool bool1 = Convert.ToBoolean(str);
                Console.WriteLine(bool1);
            }
            catch (Exception)
            {
                Console.WriteLine("the string could not be converted to a boolean");
            }
        }
    }
}
