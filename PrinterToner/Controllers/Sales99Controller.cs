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
    public class Sales99Controller : Controller
    {
        private PrinterTonerContext db = new PrinterTonerContext();

        // GET: Sales99
        public ActionResult Index()
        {
            var sales = db.Sales.Include(s => s.Printer).Include(s => s.Toner);
            return View(sales.ToList());
        }

        // GET: Sales99/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // GET: Sales99/Create
        public ActionResult Create()
        {
            ViewBag.PrinterID = new SelectList(db.Printers, "PrinterID", "PrinterManufacturer");
            ViewBag.TonerID = new SelectList(db.Toners, "TonerID", "TonerID");
            return View();
        }

        // POST: Sales99/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SaleID,SaleDate,Price,a,PrinterID,TonerID")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Sales.Add(sale);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PrinterID = new SelectList(db.Printers, "PrinterID", "PrinterManufacturer", sale.PrinterID);
            ViewBag.TonerID = new SelectList(db.Toners, "TonerID", "TonerID", sale.TonerID);
            return View(sale);
        }

        // GET: Sales99/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            ViewBag.PrinterID = new SelectList(db.Printers, "PrinterID", "PrinterManufacturer", sale.PrinterID);
            ViewBag.TonerID = new SelectList(db.Toners, "TonerID", "TonerID", sale.TonerID);
            return View(sale);
        }

        // POST: Sales99/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SaleID,SaleDate,Price,a,PrinterID,TonerID")] Sale sale)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sale).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PrinterID = new SelectList(db.Printers, "PrinterID", "PrinterManufacturer", sale.PrinterID);
            ViewBag.TonerID = new SelectList(db.Toners, "TonerID", "TonerID", sale.TonerID);
            return View(sale);
        }

        // GET: Sales99/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sale sale = db.Sales.Find(id);
            if (sale == null)
            {
                return HttpNotFound();
            }
            return View(sale);
        }

        // POST: Sales99/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sale sale = db.Sales.Find(id);
            db.Sales.Remove(sale);
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
