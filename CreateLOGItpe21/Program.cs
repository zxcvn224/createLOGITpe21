using System;
using System.IO;

namespace CreateLOGItpe21
{
    class Program
    {
        static void Main(string[] args)
        {

            string newDirectory = "LOGITpe21";

            CreateMyDirectory(newDirectory);


        }

        private static void CreateMyDirectory(string myDirectoryName)
        {
            string rootDirectory = @"C:\Users\opilane\Samples";
            string directoryFullPath = @$"{rootDirectory}\{myDirectoryName}";

            if(Directory.Exists(directoryFullPath))
            {
                Console.WriteLine($"Directory {myDirectoryName} already exists in {directoryFullPath}.");

            }
            else
            {
                Directory.CreateDirectory(directoryFullPath);
                Console.WriteLine($"Directory {myDirectoryName} has been created.");
            }

        }
    }
}
