using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Mvc;
using Microsoft.Data.Entity;
using MoviesDatabasePractice.Models;
using MoviesDatabasePractice.ViewModels;

namespace MoviesDatabasePractice.Controllers {
    [Produces("application/json")]
    [Route("api/Movies")]
    public class MoviesController : Controller {
        private ApplicationDbContext _db;

        public MoviesController(ApplicationDbContext db) {
            _db = db;
        }

        // GET: api/Movies
        [HttpGet]
        public IActionResult Get() {
            //var movies = _db.Movies.Where(m => m.Category.Name == "Drama"); //Builds the Query
            //var q = movies.ToList(); //Actually hits the database

            //var movies2 = _db.Movies.Where(m => m.Category.Name == "SciFi"); //Builds the Query
            //var q2 = movies.ToList(); //Actually hits the database

            var movies = _db.Movies.Select(m => new MovieViewModel {
                CategoryName = m.Category.Name,
                Director = m.Director,
                MovieId = m.Id,
                Title = m.Title
            }).ToList();

            return Ok(movies);
        }

        private bool MovieExists(int id) {
            return _db.Movies.Count(e => e.Id == id) > 0;
        }
    }
}