using System;
using System.IO;

namespace Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Method  
            String path = @"D:\Demo.txt";
           
            

            DirectoryInfo fl = new DirectoryInfo(path);
            fl.Create();
            {
                Console.WriteLine("Directory has been created");
            }
            

            // CreateSubdirectory Method  
            DirectoryInfo dis = fl.CreateSubdirectory("Hello World");
            {
                Console.WriteLine("Directory has been created");
            }

            //fileinfo
            FileInfo[] Files = fl.GetFiles();
            Console.WriteLine("Files in this directory.");
            foreach (FileInfo file in Files)
            {
                Console.WriteLine("File Name : {0}", file.Name);
            }
            Console.ReadKey();
        }

        /* GetFiles method  
        DirectoryInfo di = new DirectoryInfo(@"D:\newfile");
            DirectoryInfo[] dirs = di.GetDirectories();
            foreach (DirectoryInfo diNext in dirs)
            {
                Console.WriteLine("The number of files in {0} is {1}", diNext,
                diNext.GetFiles().Length);
            }*/

        }
    }
