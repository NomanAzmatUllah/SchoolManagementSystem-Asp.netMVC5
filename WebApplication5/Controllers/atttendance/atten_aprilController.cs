using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers.atttendance
{
    public class atten_aprilController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: atten_april
        public ActionResult Index()
        {
            var atten_april = db.atten_april.Include(a => a.tbl_enrolment);
            return View(atten_april.ToList());
        }

        // GET: atten_april/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_april atten_april = db.atten_april.Find(id);
            if (atten_april == null)
            {
                return HttpNotFound();
            }
            return View(atten_april);
        }

        // GET: atten_april/Create
        public ActionResult Create()
        {
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name");
            return View();
        }

        // POST: atten_april/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_april atten_april)
        {
            if (ModelState.IsValid)
            {
                db.atten_april.Add(atten_april);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_april.stu_fee_id);
            return View(atten_april);
        }

        // GET: atten_april/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_april atten_april = db.atten_april.Find(id);
            if (atten_april == null)
            {
                return HttpNotFound();
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_april.stu_fee_id);
            return View(atten_april);
        }

        // POST: atten_april/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_april atten_april)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atten_april).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_april.stu_fee_id);
            return View(atten_april);
        }

        // GET: atten_april/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_april atten_april = db.atten_april.Find(id);
            if (atten_april == null)
            {
                return HttpNotFound();
            }
            return View(atten_april);
        }

        // POST: atten_april/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            atten_april atten_april = db.atten_april.Find(id);
            db.atten_april.Remove(atten_april);
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
