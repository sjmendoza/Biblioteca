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
    public class LectoresController : Controller
    {
        private BibliotecaContext db = new BibliotecaContext();

        // GET: Lectores
        public ActionResult Index()
        {
            return View(db.Lectores.ToList());
        }

        // GET: Lectores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lector lector = db.Lectores.Find(id);
            if (lector == null)
            {
                return HttpNotFound();
            }
            return View(lector);
        }

        // GET: Lectores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Lectores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LectorId,apellido,nombre,telefono,direccion,codigoPostal,observaciones")] Lector lector)
        {
            if (ModelState.IsValid)
            {
                db.Lectores.Add(lector);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lector);
        }

        // GET: Lectores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lector lector = db.Lectores.Find(id);
            if (lector == null)
            {
                return HttpNotFound();
            }
            return View(lector);
        }

        // POST: Lectores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LectorId,apellido,nombre,telefono,direccion,codigoPostal,observaciones")] Lector lector)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lector).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lector);
        }

        // GET: Lectores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Lector lector = db.Lectores.Find(id);
            if (lector == null)
            {
                return HttpNotFound();
            }
            return View(lector);
        }

        // POST: Lectores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Lector lector = db.Lectores.Find(id);
            db.Lectores.Remove(lector);
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
