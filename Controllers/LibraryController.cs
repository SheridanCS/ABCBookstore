using Microsoft.AspNetCore.Mvc;
using ABCBookstore.Models;

namespace ABCBookstore.Controllers
{
    public class LibraryController : Controller
    {
        private IBookRepository bookRepository;

        public LibraryController(IBookRepository repository)
        {
            bookRepository = repository;
        }

        public ViewResult Index() => View(bookRepository.Books);

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            // if (ModelState.IsValid)
            // {
            // BookRepository.AddBook(book);
            // var booksList = BookRepository.Books;
            // return View("Index", booksList);
            // }
            // else
            // {
            //     return View();
            // }
            return View();
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