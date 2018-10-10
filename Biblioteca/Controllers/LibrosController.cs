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
    public class LibrosController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Libros
        public ActionResult Index()
        {
            var libros = db.Libros.Include(l => l.Autor).Include(l => l.Categoria).Include(l => l.Editorial).Include(l => l.Idioma);
            return View(libros.ToList());
        }

        // GET: Libros/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "nombre");
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "nombre");
            ViewBag.EditorialId = new SelectList(db.Editoriales, "EditorialId", "nombre");
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "IdiomaId", "nombre");
            return View();
        }

        // POST: Libros/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LibroId,titulo,fechaLanza,AutorId,CategoriaId,EditorialId,IdiomaId,paginas,descripcion")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                db.Libros.Add(libro);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "nombre", libro.AutorId);
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "nombre", libro.CategoriaId);
            ViewBag.EditorialId = new SelectList(db.Editoriales, "EditorialId", "nombre", libro.EditorialId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "IdiomaId", "nombre", libro.IdiomaId);
            return View(libro);
        }

        // GET: Libros/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "nombre", libro.AutorId);
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "nombre", libro.CategoriaId);
            ViewBag.EditorialId = new SelectList(db.Editoriales, "EditorialId", "nombre", libro.EditorialId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "IdiomaId", "nombre", libro.IdiomaId);
            return View(libro);
        }

        // POST: Libros/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LibroId,titulo,fechaLanza,AutorId,CategoriaId,EditorialId,IdiomaId,paginas,descripcion")] Libro libro)
        {
            if (ModelState.IsValid)
            {
                db.Entry(libro).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AutorId = new SelectList(db.Autores, "AutorId", "nombre", libro.AutorId);
            ViewBag.CategoriaId = new SelectList(db.Categorias, "CategoriaId", "nombre", libro.CategoriaId);
            ViewBag.EditorialId = new SelectList(db.Editoriales, "EditorialId", "nombre", libro.EditorialId);
            ViewBag.IdiomaId = new SelectList(db.Idiomas, "IdiomaId", "nombre", libro.IdiomaId);
            return View(libro);
        }

        // GET: Libros/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Libro libro = db.Libros.Find(id);
            if (libro == null)
            {
                return HttpNotFound();
            }
            return View(libro);
        }

        // POST: Libros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Libro libro = db.Libros.Find(id);
            db.Libros.Remove(libro);
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
