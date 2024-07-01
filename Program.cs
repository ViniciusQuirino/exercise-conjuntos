using System;
using Entities;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> set = new HashSet<Student>();

            System.Console.Write("How many students for course A? ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                set.Add(new Student { Number = studentNumber });
            }

            System.Console.Write("How many students for course B? ");
            int numberTwo = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberTwo; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                set.Add(new Student { Number = studentNumber });
            }

            System.Console.Write("How many students for course C? ");
            int numberThree = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberThree; i++)
            {
                int studentNumber = int.Parse(Console.ReadLine());
                set.Add(new Student { Number = studentNumber });
            }

            Console.WriteLine("Total students: " + set.Count);
        }
    }
}