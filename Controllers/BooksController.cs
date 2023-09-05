using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RantlhagoSM_Assign1.Data;
using RantlhagoSM_Assign1.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RantlhagoSM_Assign1.Controllers
{
    public class BooksController : Controller
    {
        // GET: /<controller>/
        private readonly IBookRepository _bookRepository;
        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Book book)
        {
            if (ModelState.IsValid)
            {
                _bookRepository.AddBook(book);

                return RedirectToAction("Feedback");
            }
            else
            {
                return View(book);
            }
           
        }
        public IActionResult Feedback()
        {
            var Book = _bookRepository.GetBookById();

            return View(Book);
        }
    }
}
