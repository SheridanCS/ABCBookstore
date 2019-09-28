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
            if (ModelState.IsValid)
            {
                this.bookRepository.AddBook(book);
                return RedirectToAction("Index");
            } else
            {
                return View();
            }
        }

        public IActionResult FindBook()
        {
            return View();
        }

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