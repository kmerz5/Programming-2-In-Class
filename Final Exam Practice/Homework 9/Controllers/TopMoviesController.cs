using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Homework_9.Models;

namespace Homework_9.Controllers
{
    public class TopMoviesController : Controller
    {
        private DB_128040_practiceEntities db = new DB_128040_practiceEntities();

        // GET: TopMovies
        public ActionResult Movies(int number=10)
        {
            var movies = db.Movies.Include(m => m.Director).OrderByDescending(x => x.gross).Take(number);
            return View(movies.ToList());
        }

      

        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
