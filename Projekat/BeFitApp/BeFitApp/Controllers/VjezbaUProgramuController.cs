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
    public class VjezbaUProgramuController : Controller
    {
        private OOADContext db = new OOADContext();

        // GET: VjezbaUProgramu
        public ActionResult Index()
        {
            var vjezbaUProgramus = db.VjezbaUProgramus.Include(v => v.Vjezba);
            return View(vjezbaUProgramus.ToList());
        }

        // GET: VjezbaUProgramu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VjezbaUProgramu vjezbaUProgramu = db.VjezbaUProgramus.Find(id);
            if (vjezbaUProgramu == null)
            {
                return HttpNotFound();
            }
            return View(vjezbaUProgramu);
        }

        // GET: VjezbaUProgramu/Create
        public ActionResult Create()
        {
            ViewBag.VjezbaId = new SelectList(db.Vjezbas, "Id", "Naziv");
            return View();
        }

        // POST: VjezbaUProgramu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VjezbaId,BrojSetova,BrojRepova,Vrijeme,Dan")] VjezbaUProgramu vjezbaUProgramu)
        {
            if (ModelState.IsValid)
            {
                if (BeFitApp.Static.ProgramId != -1)
                    vjezbaUProgramu.ProgramId = Static.ProgramId;
                db.VjezbaUProgramus.Add(vjezbaUProgramu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.VjezbaId = new SelectList(db.Vjezbas, "Id", "Naziv", vjezbaUProgramu.VjezbaId);
            return View(vjezbaUProgramu);
        }

        // GET: VjezbaUProgramu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VjezbaUProgramu vjezbaUProgramu = db.VjezbaUProgramus.Find(id);
            if (vjezbaUProgramu == null)
            {
                return HttpNotFound();
            }
            ViewBag.VjezbaId = new SelectList(db.Vjezbas, "Id", "Naziv", vjezbaUProgramu.VjezbaId);
            return View(vjezbaUProgramu);
        }

        // POST: VjezbaUProgramu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VjezbaId,BrojSetova,BrojRepova,Vrijeme,Dan")] VjezbaUProgramu vjezbaUProgramu)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vjezbaUProgramu).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VjezbaId = new SelectList(db.Vjezbas, "Id", "Naziv", vjezbaUProgramu.VjezbaId);
            return View(vjezbaUProgramu);
        }

        // GET: VjezbaUProgramu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VjezbaUProgramu vjezbaUProgramu = db.VjezbaUProgramus.Find(id);
            if (vjezbaUProgramu == null)
            {
                return HttpNotFound();
            }
            return View(vjezbaUProgramu);
        }

        // POST: VjezbaUProgramu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VjezbaUProgramu vjezbaUProgramu = db.VjezbaUProgramus.Find(id);
            db.VjezbaUProgramus.Remove(vjezbaUProgramu);
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
