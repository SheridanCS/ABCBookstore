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
    }
}