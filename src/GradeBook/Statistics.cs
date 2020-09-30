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

namespace GradeBook
{
    public class Statistics
    {
        public double Average;
        public double High;
        public double Low;
    }
}