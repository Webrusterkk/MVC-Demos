using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class empdatasController : Controller
    {
        private empEntities db = new empEntities();

        // GET: empdatas
        public ActionResult Index()
        {
            return View(db.empdatas.ToList());
        }

        // GET: empdatas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empdata empdata = db.empdatas.Find(id);
            if (empdata == null)
            {
                return HttpNotFound();
            }
            return View(empdata);
        }

        // GET: empdatas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: empdatas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Designation")] empdata empdata)
        {
            if (ModelState.IsValid)
            {
                db.empdatas.Add(empdata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(empdata);
        }

        // GET: empdatas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empdata empdata = db.empdatas.Find(id);
            if (empdata == null)
            {
                return HttpNotFound();
            }
            return View(empdata);
        }

        // POST: empdatas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Designation")] empdata empdata)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empdata).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(empdata);
        }

        // GET: empdatas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            empdata empdata = db.empdatas.Find(id);
            if (empdata == null)
            {
                return HttpNotFound();
            }
            return View(empdata);
        }

        // POST: empdatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            empdata empdata = db.empdatas.Find(id);
            db.empdatas.Remove(empdata);
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
