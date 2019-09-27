using Microsoft.AspNetCore.Mvc;
using ABCBookstore.Models;

namespace ABCBookstore.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            var booksList = BookRepository.Books;
            return View("Index", booksList);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookModel book)
        {
            BookRepository.AddBook(book);
            var booksList = BookRepository.Books;
            return View("Index", booksList);
        }

        public IActionResult FindBook()
        {
            return View();
        }

        public IActionResult EditBook()
        {
            return View();
        }

        public IActionResult DeleteBook()
        {
            return View();
        }
    }
}