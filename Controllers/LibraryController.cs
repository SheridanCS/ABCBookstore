using Microsoft.AspNetCore.Mvc;
using ABCBookstore.Models;
using System.Diagnostics;
using System.Linq;

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

        [HttpPost]
        public ViewResult Index(string searchBy, SearchType type)
        {
            if (string.IsNullOrEmpty(searchBy))
                return View(bookRepository.Books);

            var books = bookRepository.FindBook(searchBy, type);
            if (books == null)
                return View(Enumerable.Empty<Book>().AsQueryable());

            return View(books);
        }

        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                this.bookRepository.AddBook(book);
                return RedirectToAction("Index");
            } 

            return View();
        }


        //[HttpPost]
        //[Route("FindBook/{searchString:string}")]
        //public IActionResult FindBook([FromRoute] string searchString)
        //{
        //    var books = this.bookRepository.FindBook(searchString);
        //    return View(books);
        //}


        [HttpGet]
        [Route("Details/{id:guid}")]
        public IActionResult Details([FromRoute] string id)
        {
            Book book = bookRepository.FindById(id);
            return View(book);
        }

        [HttpPost]
        [Route("Details/{id:guid}")]
        public IActionResult EditBook(Book book)
        {
            if (ModelState.IsValid)
            {
                this.bookRepository.UpdateBook(book);
                return RedirectToAction(nameof(Index));
            } else
            {
                return View(book);
            }
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteBook(string bookId)
        {
            this.bookRepository.DeleteBookById(bookId);

            return RedirectToAction(nameof(Index));
        }
    }
}