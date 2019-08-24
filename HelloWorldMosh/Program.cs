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
            var random = new System.Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

            for (int x = 0; x < 10; x++)
            {
                //generate random letters using ascii
                Console.Write((char)random.Next(97, 122));
                //below will also generate random letters
                Console.Write((char)('a' + random.Next(0, 26)));
            }
            Console.WriteLine();
        }
    }
}
