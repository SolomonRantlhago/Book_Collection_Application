using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RantlhagoSM_Assign1.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RantlhagoSM_Assign1.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private readonly IBookRepository _bookRepository;
        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Library()
        {
            return View(_bookRepository.GetAllBooks().Where(p=>p.BookIsRead=="true"));
        }
    }
}
