using System.Collections.Generic;

namespace ABCBookstore.Models
{
    public static class BookRepository
    {
        private static List<BookModel> books = new List<BookModel>();
        
        public static IEnumerable<BookModel> Books {
            get {
                return books;
            }
        }
        
        public static void AddBook(BookModel book)
        {
            books.Add(book);
        }
    }
}