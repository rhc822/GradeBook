using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var grades = new List<double>() {1.1, 2.2, 3.3, 4.4};
            grades.Add(5.5);
            var result = 0.0;

            foreach(var number in grades)
            {
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N1}");
        }
    }
}
