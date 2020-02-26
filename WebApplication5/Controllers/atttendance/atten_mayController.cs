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
    public class atten_mayController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: atten_may
        public ActionResult Index()
        {
            var atten_may = db.atten_may.Include(a => a.tbl_enrolment);
            return View(atten_may.ToList());
        }

        // GET: atten_may/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_may atten_may = db.atten_may.Find(id);
            if (atten_may == null)
            {
                return HttpNotFound();
            }
            return View(atten_may);
        }

        // GET: atten_may/Create
        public ActionResult Create()
        {
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name");
            return View();
        }

        // POST: atten_may/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_may atten_may)
        {
            if (ModelState.IsValid)
            {
                db.atten_may.Add(atten_may);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_may.stu_fee_id);
            return View(atten_may);
        }

        // GET: atten_may/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_may atten_may = db.atten_may.Find(id);
            if (atten_may == null)
            {
                return HttpNotFound();
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_may.stu_fee_id);
            return View(atten_may);
        }

        // POST: atten_may/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_may atten_may)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atten_may).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_may.stu_fee_id);
            return View(atten_may);
        }

        // GET: atten_may/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_may atten_may = db.atten_may.Find(id);
            if (atten_may == null)
            {
                return HttpNotFound();
            }
            return View(atten_may);
        }

        // POST: atten_may/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            atten_may atten_may = db.atten_may.Find(id);
            db.atten_may.Remove(atten_may);
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
