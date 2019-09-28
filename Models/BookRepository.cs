using System.Collections.Generic;
using System.Linq;

namespace ABCBookstore.Models
{
    public class BookRepository : IBookRepository
    {
        private ApplicationDbContext context;
        private static List<Book> books = new List<Book>();

        public BookRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Book> Books => context.Books;

        public Book FindById(string bookId)
        {
            return this.context.Books.Where(book => book.BookId == bookId).First();
        }

        public void AddBook(Book book)
        {
            this.context.Add(book);
            this.context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            this.context.Update(book);
            this.context.SaveChanges();
        }

        public int DeleteBookById(string bookId)
        {
            Book bookToRemove = this.FindById(bookId);
            this.context.Books.Remove(bookToRemove);

            return this.context.SaveChanges();
        }
    }
}