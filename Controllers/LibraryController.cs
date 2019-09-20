using Microsoft.AspNetCore.Mvc;

namespace ABCBookstore.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddBook()
        {
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