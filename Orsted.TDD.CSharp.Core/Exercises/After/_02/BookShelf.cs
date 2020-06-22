
using System;
using System.Collections.Generic;


namespace TDD.CSharp.Core.Exercises.After._02
{
    public class BookShelf
    {
        private readonly List<string> _books = new List<string>();

        //3. Refactor the code to allowed add multiple books at once
        //public void Add(String book)
        public void Add(params string[] booksToAdd)
        {
            Array.ForEach(booksToAdd, book => _books.Add(book));
        }

        public List<string> GetAllBooks()
        {
            return _books;
        }

    }
}