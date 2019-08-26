using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace SummarizeTexts
{
    class Program
    {
        static void Main(string[] args)
        {
            var sentence = "this is going to be a really long sentence to test different text options within c sharp";
            var summary = StringUtility.SummarizeText(sentence, 30);
            Console.WriteLine(summary);
        }
    }
}