using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using registration.Models;

namespace registration.Controllers
{
    public class regsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: regs
        public ActionResult Index()
        {
            return View(db.regs.ToList());
        }

        // GET: regs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            regs regs = db.regs.Find(id);
            if (regs == null)
            {
                return HttpNotFound();
            }
            return View(regs);
        }

        // GET: regs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: regs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "regsid,regsname,regsrollno,regsage,regsemailid,regscontactno")] regs regs)
        {
            if (ModelState.IsValid)
            {
                db.regs.Add(regs);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(regs);
        }

        // GET: regs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            regs regs = db.regs.Find(id);
            if (regs == null)
            {
                return HttpNotFound();
            }
            return View(regs);
        }

        // POST: regs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "regsid,regsname,regsrollno,regsage,regsemailid,regscontactno")] regs regs)
        {
            if (ModelState.IsValid)
            {
                db.Entry(regs).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(regs);
        }

        // GET: regs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            regs regs = db.regs.Find(id);
            if (regs == null)
            {
                return HttpNotFound();
            }
            return View(regs);
        }

        // POST: regs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            regs regs = db.regs.Find(id);
            db.regs.Remove(regs);
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
