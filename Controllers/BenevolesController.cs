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
    public class BenevolesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Benevoles
        public ActionResult Index()
        {
            return View(db.Benevoles.ToList());
        }

        // GET: Benevoles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Benevoles benevoles = db.Benevoles.Find(id);
            if (benevoles == null)
            {
                return HttpNotFound();
            }
            return View(benevoles);
        }

        // GET: Benevoles/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Benevoles/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,nom,prenom,poste,nb_jour")] Benevoles benevoles)
        {
            if (ModelState.IsValid)
            {
                db.Benevoles.Add(benevoles);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(benevoles);
        }

        // GET: Benevoles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Benevoles benevoles = db.Benevoles.Find(id);
            if (benevoles == null)
            {
                return HttpNotFound();
            }
            return View(benevoles);
        }

        // POST: Benevoles/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,nom,prenom,poste,nb_jour")] Benevoles benevoles)
        {
            if (ModelState.IsValid)
            {
                db.Entry(benevoles).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(benevoles);
        }

        // GET: Benevoles/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Benevoles benevoles = db.Benevoles.Find(id);
            if (benevoles == null)
            {
                return HttpNotFound();
            }
            return View(benevoles);
        }

        // POST: Benevoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Benevoles benevoles = db.Benevoles.Find(id);
            db.Benevoles.Remove(benevoles);
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
