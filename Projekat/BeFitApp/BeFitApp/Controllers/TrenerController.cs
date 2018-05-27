﻿using System;
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
    public class TrenerController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: Trener
        public ActionResult Index()
        {
            return View(db.Trener.ToList());
        }

        // GET: Trener/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Trener.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // GET: Trener/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trener/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Ime,Prezime,Username,Password,Email,Biografija,Lokacija,KontaktTelefon")] Trener trener)
        {
            if (ModelState.IsValid)
            {
                db.Trener.Add(trener);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trener);
        }

        // GET: Trener/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Trener.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // POST: Trener/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Ime,Prezime,Username,Password,Email,Biografija,Lokacija,KontaktTelefon")] Trener trener)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trener).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trener);
        }

        // GET: Trener/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trener trener = db.Trener.Find(id);
            if (trener == null)
            {
                return HttpNotFound();
            }
            return View(trener);
        }

        // POST: Trener/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Trener trener = db.Trener.Find(id);
            db.Trener.Remove(trener);
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
