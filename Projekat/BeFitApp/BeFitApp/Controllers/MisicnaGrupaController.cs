using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BeFitApp.Models;

namespace BeFitApp.Controllers
{
    public class MisicnaGrupaController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: MisicnaGrupa
        
        public ActionResult Index()
        {
            return View(db.MisicnaGrupas.ToList());
        }

        // GET: MisicnaGrupa/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MisicnaGrupa misicnaGrupa = db.MisicnaGrupas.Find(id);
            if (misicnaGrupa == null)
            {
                return HttpNotFound();
            }
            return View(misicnaGrupa);
        }

        // GET: MisicnaGrupa/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: MisicnaGrupa/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Create([Bind(Include = "Id,Naziv")] MisicnaGrupa misicnaGrupa)
        {
            if (ModelState.IsValid)
            {
                db.MisicnaGrupas.Add(misicnaGrupa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(misicnaGrupa);
        }

        // GET: MisicnaGrupa/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MisicnaGrupa misicnaGrupa = db.MisicnaGrupas.Find(id);
            if (misicnaGrupa == null)
            {
                return HttpNotFound();
            }
            return View(misicnaGrupa);
        }

        // POST: MisicnaGrupa/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public ActionResult Edit([Bind(Include = "Id,Naziv")] MisicnaGrupa misicnaGrupa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(misicnaGrupa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(misicnaGrupa);
        }

        // GET: MisicnaGrupa/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MisicnaGrupa misicnaGrupa = db.MisicnaGrupas.Find(id);
            if (misicnaGrupa == null)
            {
                return HttpNotFound();
            }
            return View(misicnaGrupa);
        }

        // POST: MisicnaGrupa/Delete/5
        [HttpPost, ActionName("Delete")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MisicnaGrupa misicnaGrupa = db.MisicnaGrupas.Find(id);
            db.MisicnaGrupas.Remove(misicnaGrupa);
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
