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
            bool isRunning = true;

            while (isRunning)
            {
                int studentCount = GetNumberFromUser("Please enter the number of students:");

                Console.WriteLine("\nEnter in the name of the students: ");

                string[] studentNames = new string[studentCount];
                for (int i = 0; i < studentNames.Length; i++)
                {
                    studentNames[i] = GetStringFromUser($"Student {i + 1}'s name:");
                }

                Console.WriteLine("\nHere they are aphabetically: ");

                Array.Sort(studentNames);

                for (int i = 0; i < studentNames.Length; i++)
                {
                    Console.WriteLine(studentNames[i]);
                }

                Console.ReadKey();
                break; //Exit program

            }
        }

        //Function for Checking # from user.
        static int GetNumberFromUser(string message)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(message);
                isValid = int.TryParse(Console.ReadLine(), out result);
            }
            return result;
        }
        //Function for string/character input.
        static string GetStringFromUser(string message)
        {
            string result = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine(message);
                result = Console.ReadLine() ?? "";
                isValid = result.Length > 0;
            }
            return result;
        }
    }
}
