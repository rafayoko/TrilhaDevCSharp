using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class MovieController : Controller
    {
        private MovieDBContext db = new MovieDBContext();

        // GET: Movie

        public ViewResult Index(string searchString, int? SelectedGenre, string sortOrder)
        {
            var genres = db.Genres.OrderBy(g => g.Name).ToList();
            ViewBag.SelectedGenre = new SelectList(genres, "GenreID", "Name", SelectedGenre);
            int genreID = SelectedGenre.GetValueOrDefault();

            var movies = db.Movies
                .Where(c => !SelectedGenre.HasValue || c.GenreID == genreID);

            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title.Contains(searchString) || s.Director.Contains(searchString));
            }

            ViewBag.RatingSortParm = sortOrder == "Rating" ? "rating_asc" : "Rating";

            switch (sortOrder)
            {
                case "Rating":
                    movies = movies.OrderByDescending(s => s.Rating);
                    break;
                case "rating_asc":
                    movies = movies.OrderBy(s => s.Rating);
            }
            return View(movies);

        }

        // GET: Movie/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movie/Create
        public ActionResult Create()
        {
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name");
            return View();
        }

        // POST: Movie/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Title,Director,ReleaseDate,Gross,Rating,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Movies.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // GET: Movie/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // POST: Movie/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Title,Director,ReleaseDate,Gross,Rating,GenreID")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.GenreID = new SelectList(db.Genres, "GenreID", "Name", movie.GenreID);
            return View(movie);
        }

        // GET: Movie/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movie/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Movie movie = db.Movies.Find(id);
            db.Movies.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        public ActionResult Catalogo(string titulo)
        {
            string filePath = Server.MapPath("~/Content/Catalogo/") + titulo.ToLower() + ".pdf";
            if (System.IO.File.Exists(filePath))
                return new FilePathResult(filePath, "application/pdf");
            else
                return HttpNotFound();
        }

        public JsonResult Filmes()
        {

            var model = from movie in db.Movies
                        select new
                        {
                            Titulo = movie.Title,
                            Diretor = movie.Director,
                            Ano = movie.ReleaseDate.Year,
                            Genero = movie.Genre.Name
                        };
            return Json(model.OrderBy(m => m.Ano), JsonRequestBehavior.AllowGet);
        }


    }
}
    