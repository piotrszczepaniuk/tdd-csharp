using System.Collections.Generic;

namespace TDD.CSharp.Core.Exercises.After._01
{
    public class BookShelf
    {
        private readonly List<string> _books = new List<string>();

        public void Add(string book)
        {
            _books.Add(book);
        }

        public List<string> GetAllBooks()
        {
            return _books;
        }
    }
}