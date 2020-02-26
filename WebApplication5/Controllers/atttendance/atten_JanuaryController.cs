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
    public class atten_JanuaryController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: atten_January
        public ActionResult Index()
        {
            var atten_January = db.atten_January.Include(a => a.tbl_enrolment);
            return View(atten_January.ToList());
        }

        // GET: atten_January/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_January atten_January = db.atten_January.Find(id);
            if (atten_January == null)
            {
                return HttpNotFound();
            }
            return View(atten_January);
        }

        // GET: atten_January/Create
        public ActionResult Create()
        {
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name");
            return View();
        }

        // POST: atten_January/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_January atten_January)
        {
            if (ModelState.IsValid)
            {
                db.atten_January.Add(atten_January);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_January.stu_fee_id);
            return View(atten_January);
        }

        // GET: atten_January/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_January atten_January = db.atten_January.Find(id);
            if (atten_January == null)
            {
                return HttpNotFound();
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_January.stu_fee_id);
            return View(atten_January);
        }

        // POST: atten_January/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fee_id,total_days,present,Absents,late,leave,stu_fee_id")] atten_January atten_January)
        {
            if (ModelState.IsValid)
            {
                db.Entry(atten_January).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", atten_January.stu_fee_id);
            return View(atten_January);
        }

        // GET: atten_January/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            atten_January atten_January = db.atten_January.Find(id);
            if (atten_January == null)
            {
                return HttpNotFound();
            }
            return View(atten_January);
        }

        // POST: atten_January/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            atten_January atten_January = db.atten_January.Find(id);
            db.atten_January.Remove(atten_January);
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
