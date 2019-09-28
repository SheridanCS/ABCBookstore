using System.Linq;
namespace ABCBookstore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
        Book FindById(string bookId);
        void AddBook(Book book);
        void UpdateBook(Book book);
        int DeleteBookById(string bookId);
    }
}