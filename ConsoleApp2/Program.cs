using System;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CourseResult result = new CourseResult();
            Console.Write("Enter Student name:");
            result.StudentName = Console.ReadLine();
            Console.Write("Enter Mark:");
            result.Marks=double.Parse(Console.ReadLine());
            Console.WriteLine();
            result.PrintResult();
        }
    }
}