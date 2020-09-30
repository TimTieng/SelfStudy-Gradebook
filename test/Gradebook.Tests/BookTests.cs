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
using Xunit;//Required to run Xunit unit testing
using GradeBook;

namespace Gradebook.Tests
{
    public class BookTests
    {
        [Fact]//Attribute in C#. Xunit looks for methods that have FACT attached to it
        public void BookCalculatesAverageGrades()
        {
            //ARRANGE - create an actual instance of the class you want to test (Book)
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //ACT
            var result = book.GetStatistics();
            
            //ASSERT Xunit Namespace. .Equal tests to see if the actual variable matches expected value
            Assert.Equal(85.6, result.Average, 1);//Syntax = Assert.Equal(testvalue, expected value, decimal place for int)
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);
        }
    }
}
