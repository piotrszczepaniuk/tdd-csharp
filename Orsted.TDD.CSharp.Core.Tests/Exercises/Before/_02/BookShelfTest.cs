using TDD.CSharp.Core.Exercises.Before._02;
using System.Collections.Generic;
using Xunit;

namespace TDD.CSharp.Core.Tests.Exercises.Before._02
{
    public class BookShelfTest
    {
        /*
        1. Refactor code to initialize bookshelf before each test 
        User Story:
            As a user, I want to add multiple books to my bookshelf so that I can read
            them later.
        Task: Develop User Stories with Test Driven Development
        Test Case 1:
            Bookshelf is empty when no book was added
        */
        [Fact]
        public void ShouldBeEmptyWhenNoBookAdded()
        {
            //Given
            BookShelf shelf = new BookShelf();
            //When
            List<string> books = shelf.GetAllBooks();
            //Then
            Assert.Empty(books);
        }

        /*
        Task: Develop User Stories with Test Driven Development
        Test Case 2:
        Bookshelf contains two books when two books were added
        */

        [Fact]
        public void ShouldContainsTwoBooksWhenTwoBooksAdded()
        {
            //Given
            BookShelf shelf = new BookShelf();
            //When
            shelf.Add("xUnit Test Patterns");
            shelf.Add("Code Complete");
            List<string> books = shelf.GetAllBooks();
            //Then
            Assert.True(books.Count.Equals(2), "BookShelf should have two books.");
        }


        /*Task: Develop User Stories with Test Driven Development
          2. Write a test to allowed add multiple books at once
        */
        [Fact]
        public void ShouldAllowedToAddMultipleBooksAtOnce()
        {
            //Given

            //When

            //Then
        }

    }


}