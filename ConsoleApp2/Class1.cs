using System;
namespace ConsoleApp2
{
    class CourseResult
    {
        public string StudentName { get; set; }
        private double marks;
        public double Marks
        {
            get

            {
                return marks;

            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    marks = value;
                }
                else
                {
                    Console.WriteLine("Invalid mark");
                }
            }
        }
        public string Grade
        {
            get
            {
                if (Marks >= 90)
                {
                    return "A";
                }
                else if (Marks >= 80)
                {
                    return "B";
                }

                else if (Marks >= 65)
                {
                    return "C";
                }
                else if (Marks >= 50)
                {
                    return "D";
                }


                else
                {
                    return "F";
                }
            }
        }
        public bool Passed
        {
            get
            {
                return Marks >= 50;
            }
        }
        public void PrintResult()
        {
            Console.WriteLine("Student Name :" +StudentName);
            Console.WriteLine("Mark: " +Marks);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Passed: " + Passed);
        }
    }
}