using MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

namespace MvcMovie.Controllers
{
    public class FilmeController : Controller
    {

        private MovieDBContext movieDb = new MovieDBContext();
        // GET: Filme
        public ViewResult Index(string searchString)
        {
            var movies = from movie in movieDb.Movies
                         select movie;
            if (!String.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Director.Contains(searchString) || s.Title.Contains(searchString));

            }

            
            return View(movies.ToList());
        }

        // GET: Filme/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Filme/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filme/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Filme/Edit/5
        public ActionResult Edit(int id)
        {
            Movie filme = this.movieDb.Movies.Find(id);
            if (filme == null)
            {
                return this.HttpNotFound();
            }
            this.ViewBag.GenreId = new
             SelectList(this.movieDb.Genres, "GenreId", "Name", filme.GenreID);
            return this.View(filme);
        }
        [HttpPost]
        public ActionResult Edit(Movie album)
        {
            if (ModelState.IsValid)
            {
                this.movieDb.Entry(album).State = EntityState.Modified;
                this.movieDb.SaveChanges();
                return this.RedirectToAction("Index");
            }
            this.ViewBag.GenreId = new
            SelectList(this.movieDb.Genres, "GenreId", "Name", album.GenreID);
            return this.View(album);
        }


        // POST: Filme/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Filme/Delete/5
        public ActionResult Delete(int id)
        {
            Movie movie = this.movieDb.Movies.Find(id);
            if (movie == null)
            {
                return this.HttpNotFound();
            }
            return this.View(movie);
        }

        // POST: /Store/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            Movie movie = this.movieDb.Movies.Find(id);
            this.movieDb.Movies.Remove(movie);
            this.movieDb.SaveChanges();
            return this.RedirectToAction("Index");
        }

    }
}
