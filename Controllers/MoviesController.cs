using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private VidlyDBContext _context;

        public MoviesController()
        {
            _context = new VidlyDBContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        //called when going to /movies/random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //returns when we navigate to movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            var movies = _context.Movies.Include(m => m.Genre).ToList();

            var viewModel = new IndexMovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }

        [Route("Movies/Details/{ID}")]
        public ActionResult Details(int id) 
        {
            var movies = _context.Movies.SingleOrDefault(c => c.ID == id);

            if (movies == null)
            {
                return HttpNotFound();
            }

            return View(movies);
        }

        //custom route created can be accessed by /movies/released/{year}/{month}
        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private List<Movie> GetMovies() 
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Shrek", ID = 1},
                new Movie { Name = "Wall-e", ID = 2}
            };

            return movies;
        }
    }
}