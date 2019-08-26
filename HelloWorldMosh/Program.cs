using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace FileInfoClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Copy("c:\\temp\\myfile.jpg", "d:\\temp\\myfile.jpg", true);

            //use @ to get rid of using double backslash

            var path = @"c:\somefile.jpg";

            File.Copy(@"c:\temp\myfile.jpg", @"d:\temp\myfile.jpg", true);

            File.Delete(path);
            if (File.Exists(path))
            {
                //
            }

            var content = File.ReadAllText(path);

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                //
            }



            Directory.CreateDirectory(@"c:\temp\folder1");
            var files = Directory.GetFiles(@"C:\Users\tomal\Documents\c#Code", "*.*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"C:\Users\tomal\Documents\c#Code", "*.*", SearchOption.AllDirectories);
            foreach (var x in directories)
            {
                Console.WriteLine(x);
            }

            //            Directory.Exists("..put path here")


            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();



            //path
            var path = @"C:\Users\tomal\Documents\c#Code\CSharpTutuorials\Mosh\beginner\Classes.mp4";

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name without extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("directory name: " + Path.GetDirectoryName(path));

        }
    }
}