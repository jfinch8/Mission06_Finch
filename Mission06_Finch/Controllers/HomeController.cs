using Microsoft.AspNetCore.Mvc;
using Mission06_Finch.Models;
using System.Diagnostics;

namespace Mission06_Finch.Controllers
{
    public class HomeController : Controller
    {
        private FormContext _context;
        public HomeController(FormContext temp)
        {
            _context = temp; 
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnow()
        {
            return View();
        }


        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMovies(Form response)
        {
            _context.Forms.Add(response); //add record to database
            _context.SaveChanges();
            return View("Confirmation");

        }
       

    }
}
