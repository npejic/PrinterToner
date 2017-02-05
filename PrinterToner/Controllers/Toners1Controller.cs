using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PrinterToner.DAL;
using PrinterToner.Models;

namespace PrinterToner.Controllers
{
    public class Toners1Controller : Controller
    {
        private PrinterTonerContext db = new PrinterTonerContext();

        // GET: Toners1
        public ActionResult Index()
        {
            return View(db.Toners.ToList());
        }

        // GET: Toners1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toner toner = db.Toners.Find(id);
            if (toner == null)
            {
                return HttpNotFound();
            }
            return View(toner);
        }

        // GET: Toners1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Toners1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TonerID,TonerModel,TonerIsOriginal")] Toner toner)
        {
            if (ModelState.IsValid)
            {
                db.Toners.Add(toner);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(toner);
        }

        // GET: Toners1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toner toner = db.Toners.Find(id);
            if (toner == null)
            {
                return HttpNotFound();
            }
            return View(toner);
        }

        // POST: Toners1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TonerID,TonerModel,TonerIsOriginal")] Toner toner)
        {
            if (ModelState.IsValid)
            {
                db.Entry(toner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(toner);
        }

        // GET: Toners1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Toner toner = db.Toners.Find(id);
            if (toner == null)
            {
                return HttpNotFound();
            }
            return View(toner);
        }

        // POST: Toners1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Toner toner = db.Toners.Find(id);
            db.Toners.Remove(toner);
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
