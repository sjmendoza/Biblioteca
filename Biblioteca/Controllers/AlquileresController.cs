using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Biblioteca.DAL;
using Biblioteca.Models;

namespace Biblioteca.Controllers
{
    public class AlquileresController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Alquileres
        public ActionResult Index()
        {
            var alquileres = db.Alquileres.Include(a => a.Lector).Include(a => a.Libro);
            return View(alquileres.ToList());
        }

        // GET: Alquileres/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alquiler alquiler = db.Alquileres.Find(id);
            if (alquiler == null)
            {
                return HttpNotFound();
            }
            return View(alquiler);
        }

        // GET: Alquileres/Create
        public ActionResult Create()
        {
            ViewBag.LectorId = new SelectList(db.Lectores, "LectorId", "apellido");
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo");
            return View();
        }

        // POST: Alquileres/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AlquilerId,LectorId,LibroId,fechaSalida,fechaEntrada")] Alquiler alquiler)
        {
            if (ModelState.IsValid)
            {
                db.Alquileres.Add(alquiler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.LectorId = new SelectList(db.Lectores, "LectorId", "apellido", alquiler.LectorId);
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo", alquiler.LibroId);
            return View(alquiler);
        }

        // GET: Alquileres/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alquiler alquiler = db.Alquileres.Find(id);
            if (alquiler == null)
            {
                return HttpNotFound();
            }
            ViewBag.LectorId = new SelectList(db.Lectores, "LectorId", "apellido", alquiler.LectorId);
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo", alquiler.LibroId);
            return View(alquiler);
        }

        // POST: Alquileres/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AlquilerId,LectorId,LibroId,fechaSalida,fechaEntrada")] Alquiler alquiler)
        {
            if (ModelState.IsValid)
            {
                db.Entry(alquiler).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.LectorId = new SelectList(db.Lectores, "LectorId", "apellido", alquiler.LectorId);
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo", alquiler.LibroId);
            return View(alquiler);
        }

        // GET: Alquileres/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Alquiler alquiler = db.Alquileres.Find(id);
            if (alquiler == null)
            {
                return HttpNotFound();
            }
            return View(alquiler);
        }

        // POST: Alquileres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Alquiler alquiler = db.Alquileres.Find(id);
            db.Alquileres.Remove(alquiler);
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
    }
}
