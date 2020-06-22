using System.Collections.Generic;

namespace TDD.CSharp.Core.Exercises.Before._02
{
    public class BookShelf
    {
        private readonly List<string> _books = new List<string>();

        //3. Refactor the code to allowed add multiple books at once
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