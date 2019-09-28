using System.Collections.Generic;
using System.Linq;
namespace ABCBookstore.Models
{
    public class MockBookRepository : IBookRepository
    {
        public IQueryable<Book> Books => new List<Book> {
            new Book {
                Title = "The Hobbit",
                Authors = "J.R.R. Tolkien",
                ISBN = "0345339683",
                Publisher = Publisher.International.ToString(),
                PublishDate = new System.DateTime(1937, 9, 21),
                Category = Category.Fantasy,
                Pages = 310,
                Price = 15
            },
            new Book {
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Authors = "J.R.R. Tolkien",
                ISBN = "0345339703",
                Publisher = Publisher.International.ToString(),
                PublishDate = new System.DateTime(1954, 7, 29),
                Category = Category.Fantasy,
                Pages = 423,
                Price = 20
            },
            new Book {
                Title = "The Lord of the Rings: The Two Towers",
                Authors = "J.R.R. Tolkien",
                ISBN = "0007522916",
                Publisher = Publisher.International.ToString(),
                PublishDate = new System.DateTime(1954, 11, 11),
                Category = Category.Fantasy,
                Pages = 325,
                Price = 25
            },
            new Book {
                Title = "The Lord of the Rings: The Return of the King",
                Authors = "J.R.R. Tolkien",
                ISBN = "0395272211",
                Publisher = Publisher.International.ToString(),
                PublishDate = new System.DateTime(1955, 10, 20),
                Category = Category.Fantasy,
                Pages = 416,
                Price = 25
            },
        }.AsQueryable<Book>();
    }
}