using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ProjectBv2.Models;

namespace ProjectBv2.Controllers
{
    public class PostesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Postes
        public ActionResult Index()
        {
            return View(db.Postes.ToList());
        }

        // GET: Postes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postes postes = db.Postes.Find(id);
            if (postes == null)
            {
                return HttpNotFound();
            }
            return View(postes);
        }

        // GET: Postes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Postes/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id_postes,adresse,kilometrage")] Postes postes)
        {
            if (ModelState.IsValid)
            {
                db.Postes.Add(postes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(postes);
        }

        // GET: Postes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postes postes = db.Postes.Find(id);
            if (postes == null)
            {
                return HttpNotFound();
            }
            return View(postes);
        }

        // POST: Postes/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id_postes,adresse,kilometrage")] Postes postes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(postes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postes);
        }

        // GET: Postes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Postes postes = db.Postes.Find(id);
            if (postes == null)
            {
                return HttpNotFound();
            }
            return View(postes);
        }

        // POST: Postes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Postes postes = db.Postes.Find(id);
            db.Postes.Remove(postes);
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
