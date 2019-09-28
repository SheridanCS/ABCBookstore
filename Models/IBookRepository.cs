using System.Linq;
namespace ABCBookstore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }
    }
}