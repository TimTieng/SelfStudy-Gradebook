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
    public class TypeTests
    {
        [Fact]
        public void ValueTypeAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x); 
        }

        private void SetInt(ref int z)
        {
            z = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpPassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);  
        }

        [Fact]
        public void CSharpPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }

        [Fact]
        public void CanSetBookNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1, "New Name");

            Assert.Equal("New Name", book1.Name);
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]//Attribute in C#. Xunit looks for methods that have FACT attached to it
        public void GetBookReturnsDifferentObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            //Asert
            Assert.Equal("Book 1", book1.Name); //Syntax ("Expected Value", ActualValue)
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1, book2);
        }
        [Fact]
        public void CanTwoVariablesReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1; //Copies value of book 1 to book2

            //Asert
            Assert.Same(book1,book2);
            Assert.True(Object.ReferenceEquals(book1, book2));
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
