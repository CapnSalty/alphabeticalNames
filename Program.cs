using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;

namespace alphabeticalName
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of students: ");
            string[] studentNames = new string[int.Parse(Console.ReadLine())];


            Console.WriteLine("\nEnter in the name of the students: ");

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine("\nHere they are aphabetically: ");

            Array.Sort(studentNames);

            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.WriteLine(studentNames[i]);
            }

            //Wait before closing
            Console.ReadKey();
        }
    }
}