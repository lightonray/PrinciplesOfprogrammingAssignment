using System;
using System.Collections.Generic;

namespace POPA1
{
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            try
            {
                var newStudent = new Student();
                var newAddress = new Address();


                Console.WriteLine("Student First Name: ");
                newStudent.FirstName = Console.ReadLine();
                if (string.IsNullOrEmpty(newStudent.FirstName))
                {
                    Console.WriteLine("Please enter valid value");
                }

                Console.WriteLine("Student Last Name: ");
                newStudent.LastName = Console.ReadLine();

                if (string.IsNullOrEmpty(newStudent.LastName))
                {
                    Console.WriteLine("Please enter valid value");
                }

                Console.WriteLine("Student Number: ");
                newStudent.StudentNumber = Console.ReadLine();

                if (string.IsNullOrEmpty(newStudent.StudentNumber))
                {
                    Console.WriteLine("Please enter valid value");
                }

                Console.WriteLine("Student Age: ");
                newStudent.Age = int.Parse(Console.ReadLine());
             

                Console.WriteLine("Student Street: ");
                newAddress.Street = (Console.ReadLine());

                if (string.IsNullOrEmpty(newAddress.Street))
                {
                    Console.WriteLine("Please enter valid value");
                }

                Console.WriteLine("Student City: ");
                newAddress.City = (Console.ReadLine());

                if (string.IsNullOrEmpty(newAddress.City))
                {
                    Console.WriteLine("Please enter valid value");
                }

                Console.WriteLine("Student Country: ");
                newAddress.Country = (Console.ReadLine());

                if (string.IsNullOrEmpty(newAddress.Country))
                {
                    Console.WriteLine("Please enter valid value");
                }

                newStudent.FullAddress = newAddress.address;
                newStudent.City = newAddress.City;

                Console.WriteLine("How many scores to input?: ");
                int n = int.Parse(Console.ReadLine());
                Console.Write($"Input {n} number of score:\n");
                int[] arr = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Score - {i + 1} : ");
                    arr[i] = int.Parse(Console.ReadLine());
                }

                int sum = 0;
                int average = 0;
                for (int i = 0; i < n; i++)
                {
                    sum += arr[i];
                }
                average = sum / n;
                newStudent.AverageScore = average;

                Console.WriteLine(newStudent);


            }
            catch
            {
                Console.WriteLine("Please enter valid data");
            }
        }
    }
}