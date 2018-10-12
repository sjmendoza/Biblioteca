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
    public class EjemplaresController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Ejemplares
        public ActionResult Index()
        {
            var ejemplares = db.Ejemplares.Include(e => e.Estado).Include(e => e.Libro);
            return View(ejemplares.ToList());
        }

        // GET: Ejemplares/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ejemplar ejemplar = db.Ejemplares.Find(id);
            if (ejemplar == null)
            {
                return HttpNotFound();
            }
            return View(ejemplar);
        }

        // GET: Ejemplares/Create
        public ActionResult Create()
        {
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "nombre");
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo");
            return View();
        }

        // POST: Ejemplares/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EjemplarId,numeroEjemplar,EstadoId,LibroId")] Ejemplar ejemplar)
        {
            if (ModelState.IsValid)
            {
                db.Ejemplares.Add(ejemplar);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "nombre", ejemplar.EstadoId);
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo", ejemplar.LibroId);
            return View(ejemplar);
        }

        // GET: Ejemplares/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ejemplar ejemplar = db.Ejemplares.Find(id);
            if (ejemplar == null)
            {
                return HttpNotFound();
            }
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "nombre", ejemplar.EstadoId);
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo", ejemplar.LibroId);
            return View(ejemplar);
        }

        // POST: Ejemplares/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "EjemplarId,numeroEjemplar,EstadoId,LibroId")] Ejemplar ejemplar)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ejemplar).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EstadoId = new SelectList(db.Estados, "EstadoId", "nombre", ejemplar.EstadoId);
            ViewBag.LibroId = new SelectList(db.Libros, "LibroId", "titulo", ejemplar.LibroId);
            return View(ejemplar);
        }

        // GET: Ejemplares/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ejemplar ejemplar = db.Ejemplares.Find(id);
            if (ejemplar == null)
            {
                return HttpNotFound();
            }
            return View(ejemplar);
        }

        // POST: Ejemplares/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ejemplar ejemplar = db.Ejemplares.Find(id);
            db.Ejemplares.Remove(ejemplar);
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
