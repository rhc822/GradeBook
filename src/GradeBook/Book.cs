using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        // Constructor method on class to avoid null reference error, must have same as class and no return type
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;
        }
        public void AddGrade(double grade)
        {
            
            grades.Add(grade);

        }

        public void ShowStatistics()
        {

            // var grades = new List<double>() {1.1, 2.2, 3.3, 4.4};
            // grades.Add(5.5);
            var result = 0.0;
            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach(var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);
                result += number;
            }

            result /= grades.Count;
            Console.WriteLine($"The average grade is: {result:N1}");
            Console.WriteLine($"The lowest grade is: {lowGrade:N1}");
            Console.WriteLine($"The highest grade is: {highGrade:N1}");

        } 

        private List<double> grades;
        private string name;
    }

}