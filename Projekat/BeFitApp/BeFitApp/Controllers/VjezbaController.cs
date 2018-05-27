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
    public class VjezbaController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: Vjezba
        public ActionResult Index()
        {
            var vjezbas = db.Vjezbas.Include(v => v.MisicnaGrupa);
            return View(vjezbas.ToList());
        }

        // GET: Vjezba/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vjezba vjezba = db.Vjezbas.Find(id);
            if (vjezba == null)
            {
                return HttpNotFound();
            }
            return View(vjezba);
        }

        // GET: Vjezba/Create
        public ActionResult Create()
        {
            ViewBag.MisicnaGrupaId = new SelectList(db.MisicnaGrupas, "Id", "Naziv");
            return View();
        }

        // POST: Vjezba/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,MisicnaGrupaId,Naziv,Opis,RedniBrojVjezbe")] Vjezba vjezba)
        {
            if (ModelState.IsValid)
            {
                db.Vjezbas.Add(vjezba);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MisicnaGrupaId = new SelectList(db.MisicnaGrupas, "Id", "Naziv", vjezba.MisicnaGrupaId);
            return View(vjezba);
        }

        // GET: Vjezba/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vjezba vjezba = db.Vjezbas.Find(id);
            if (vjezba == null)
            {
                return HttpNotFound();
            }
            ViewBag.MisicnaGrupaId = new SelectList(db.MisicnaGrupas, "Id", "Naziv", vjezba.MisicnaGrupaId);
            return View(vjezba);
        }

        // POST: Vjezba/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,MisicnaGrupaId,Naziv,Opis,RedniBrojVjezbe")] Vjezba vjezba)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vjezba).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MisicnaGrupaId = new SelectList(db.MisicnaGrupas, "Id", "Naziv", vjezba.MisicnaGrupaId);
            return View(vjezba);
        }

        // GET: Vjezba/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vjezba vjezba = db.Vjezbas.Find(id);
            if (vjezba == null)
            {
                return HttpNotFound();
            }
            return View(vjezba);
        }

        // POST: Vjezba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vjezba vjezba = db.Vjezbas.Find(id);
            db.Vjezbas.Remove(vjezba);
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
