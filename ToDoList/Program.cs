using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace ToDoList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> todofromfile = new List<string>();
            string todofilepath = @"C:\Users\opilane\samples\LOGITpe21\toDoList.txt";
            todofromfile = File.ReadAllLines(todofilepath).ToList();

            foreach (string task in todofromfile)
            {
                Console.WriteLine(task);
            }

            bool loopactive = true;

            while (loopactive)
            {
                Console.WriteLine("Would you like to add a task? Y/N");
                char userinput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userinput == 'y')
                {
                    Console.WriteLine("enter a task");
                    string usertask = Console.ReadLine();
                    todofromfile.Add(usertask);
                    Console.WriteLine($"task {usertask} added.");

                }
                else
                {
                    loopactive = false;
                }

            }
            File.WriteAllLines(todofilepath, todofromfile.ToArray());
        }
    }
}
