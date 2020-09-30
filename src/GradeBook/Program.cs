/*
Student: Tim Tieng
Pluralsight C# Learning Path - Scott Allen

Task Requirement: Create an electronic gradebook to read the scores of an individual 
student and then compute some simple statistics form the scores.

Constraints/Explicit Guidelines:
1. Grades are entered as Floating Point INT
2. Grades are from 0 - 100 only
3. Statistics should show us the highest grade, lowest grade, and the average grade (Mathematical Operations)
4. Include Unit Testing
*/
using System;
using System.Collections.Generic; //Used to use list collection List are more dynamic than array

namespace GradeBook 
{
    class Program
    {
        static void Main(string[] args)//Opposite of static = instance member
        {
            var book = new Book("Tim's Gradebook");//instanace "book" of the Book Class.
            book.AddGrade(89.1);//Instance can invoke method outlined in Book Class due to method's access modifier
            book.AddGrade(90.5);
            book.AddGrade(77.5); 
            
            var stats = book.GetStatistics();
            //Print out low Grade
            Console.WriteLine($"The highest grade in your book is: {stats.Low}");
            //Print out high Grade
            Console.WriteLine($"The lowest grade in your book is: {stats.High}");
           //Print out Average
            Console.WriteLine($"The average of your grades is: {stats.Average:N1}");
        }
    }
}
