using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System;

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

        public IQueryable<Book> FindBook(string searchString, SearchType type)
        {
            switch (type)
            {
                case SearchType.Title:
                    return this.context.Books.Where(book => book.Title.ToLower().Contains(searchString.ToLower()));
                case SearchType.Category:
                    List<Category?> categories = new List<Category?>();
                    foreach (var category in (Category[])Enum.GetValues(typeof(Category)))
                    {
                        var categoryName = Enum.GetName(typeof(Category), category);
                        if (categoryName.ToLower().Contains(searchString.ToLower()))
                            categories.Add(category);
                    }

                    return this.context.Books.Where(book => categories.Contains(book.Category));
                case SearchType.Price:
                    decimal price;
                    try
                    {
                        price = Convert.ToDecimal(searchString);
                    }
                    catch (Exception)
                    {
                        return null;
                    }

                    return this.context.Books.Where(book => book.Price >= price);
            }

            return null;
        }
    }
}