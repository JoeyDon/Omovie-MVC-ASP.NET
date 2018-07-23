 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Omovie_MVC_ASP.NET.Models;


namespace Omovie_MVC_ASP.NET.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = GetMovies();

   
            return View(movies);
        }

        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Id = 1, Name = "Shrek"},
                new Movie(){Id = 2, Name = "Wall-e"}
            };
        }



        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month );
        }  

        
        


    }
}