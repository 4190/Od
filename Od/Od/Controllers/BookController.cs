using Microsoft.AspNetCore.Mvc;
using Od.Data.EfCore;
using Od.Models;

namespace Od.Controllers
{
    public class BookController : Controller
    {

        private readonly EfCoreBookRepository _bookRepository;

        public BookController(EfCoreBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        
        [HttpPost]
        public async Task<IActionResult> Add(Book model)
        {
            await _bookRepository.Add(model);

            return Content(model.Title + " by " + model.Author);
        }   
    }
}
