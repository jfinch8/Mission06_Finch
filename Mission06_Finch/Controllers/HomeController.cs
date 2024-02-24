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
            ViewBag.Categories = _context.Categories.OrderBy(x=> x.CategoryName).ToList();
            return View("AddMovies", new Form());
        }
        [HttpPost]
        public IActionResult AddMovies(Form response)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(response); //add record to database
                _context.SaveChanges();
                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();

                return View(response);
            }
            

        }

        public IActionResult MovieList()
        {
            //Linq
            var movies = _context.Movies
                .Where(x => x.Year >= 1888)
                .OrderBy(x => x.Year).ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies.Single(x => x.MovieId == id);
            ViewBag.Categories = _context.Categories.OrderBy(x => x.CategoryName).ToList();

            return View("AddMovies", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Form updatedInfo) 
        {
            _context.Update(updatedInfo);
            _context.SaveChanges();
            return RedirectToAction("MoviesList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies.Single(x => x.MovieId == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(Form movie)
        {
            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
    }
}
