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
    public class atten_JulyController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: atten_July
        public ActionResult Index()
        {
            var atten_July = db.atten_July.Include(a => a.tbl_enrolment);
            return View(atten_July.ToList());
        }

        // GET: atten_July/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_July atten_July = db.atten_July.Find(id);
            if (atten_July == null)
            {
                return HttpNotFound();
            }
            return View(atten_July);
        }

        // GET: atten_July/Create
        public ActionResult Create()
        {
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name");
            return View();
        }

        // POST: atten_July/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_July atten_July)
        {
            if (ModelState.IsValid)
            {
                db.atten_July.Add(atten_July);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_July.stu_fee_id);
            return View(atten_July);
        }

        // GET: atten_July/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_July atten_July = db.atten_July.Find(id);
            if (atten_July == null)
            {
                return HttpNotFound();
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_July.stu_fee_id);
            return View(atten_July);
        }

        // POST: atten_July/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_July atten_July)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atten_July).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_July.stu_fee_id);
            return View(atten_July);
        }

        // GET: atten_July/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_July atten_July = db.atten_July.Find(id);
            if (atten_July == null)
            {
                return HttpNotFound();
            }
            return View(atten_July);
        }

        // POST: atten_July/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            atten_July atten_July = db.atten_July.Find(id);
            db.atten_July.Remove(atten_July);
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
