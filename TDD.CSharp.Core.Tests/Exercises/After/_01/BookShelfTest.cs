using TDD.CSharp.Core.Exercises.After._01;
using System.Collections.Generic;
using Xunit;

namespace TDD.CSharp.Core.Tests.Exercises.After._01
{
    public class BookShelfTest
    {
        /*
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
    }


}