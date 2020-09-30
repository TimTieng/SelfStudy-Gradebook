/*
Student: Tim Tieng
Pluralsight C# Learning Path - Scott Allen

Task Requirement: Create an electronic gradebook to read the scores of an individual 
student and then compute some simple statistics form the scores.

Constraints/Explicit Guidelines:
1. Grades are entered as Floating Point INT
2. Grades are from 0 - 100 only
3. Statistics should show us the highest grade, lowest grade, and the average grade (Mathematical Operations)
4. Create a project that include unit testing using xUnit
*/
using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Book //Blueprint, used to create new objects of a class that has the same properties and methods
    {
        public Book(string name)//Explicit Constructor of the Book Class. Must be same name of Class
        {
            grades = new List<double>();
            Name = name;
        }
        public void AddGrade (double grade)
        {
            grades.Add(grade);//Listname Add (grade value)
        }
        public Statistics GetStatistics()
        {
            //Create an object of Statistics
            var result = new Statistics();
            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach(double grade in grades)//Loop through a collection
            {

                //Low Grade= grade;//One method to determine and set highest grade in the list
                result.Low = Math.Min(grade, result.Low);//method two to determine and set highest grad ein lest
                //Same for High grade
                result.High = Math.Max(grade, result.High);
                result.Average += grade; // add then assign calculation result to the variable
            }
            result.Average /= grades.Count;

            return result;
        }
        private List<double> grades;//Private members are always lowercase or start with an underscore
        public string Name;//field of the book class
    }
}