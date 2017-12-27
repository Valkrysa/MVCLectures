using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCLectures.Models;
using MVCLectures.ViewModels;

namespace MVCLectures.Controllers {
    public class MoviesController : Controller {

        private ApplicationDbContext _context;

        public MoviesController() {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing) {
            _context.Dispose();
            base.Dispose(disposing);
        }

        public ViewResult Index() {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id) {
            var movie = _context.Movies.Include(m => m.Genre).SingleOrDefault(m => m.Id == id);

            if (movie == null) {
                return HttpNotFound();
            }

            return View(movie);
        }

        /*[Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month) {
            return Content(year + "/" + month);
        }
        
        public ActionResult Random() {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer> {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            // return Content("hello wolrd");
            // return HttpNotFound();
            // return new EmptyResult();
            // return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id) {
            return Content("id=" + id);
        }*/
    }
}