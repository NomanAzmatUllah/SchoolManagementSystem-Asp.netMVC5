using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers.feecontroller
{
    public class fee_Amount_JanuaryController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: fee_Amount_January
        public ActionResult Index(string search)
        {
            int id = Convert.ToInt32(search);

            if (search == null)
            {
                var fee_Amount_January = db.fee_Amount_January.Include(f => f.tbl_enrolment);
                return View(fee_Amount_January.ToList());
            }
            else
            {
                return View(db.fee_Amount_January.Where(item => item.stu_fee_id == id).ToList());
            }

           
        }

        // GET: fee_Amount_January/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fee_Amount_January fee_Amount_January = db.fee_Amount_January.Find(id);
            if (fee_Amount_January == null)
            {
                return HttpNotFound();
            }
            return View(fee_Amount_January);
        }

        // GET: fee_Amount_January/Create
        public ActionResult Create()
        {
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name");
            return View();
        }

        // POST: fee_Amount_January/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fee_id,fee_Advance,Fee_Amount,fee_month_name,fee_status,fee_date,stu_fee_id")] fee_Amount_January fee_Amount_January)
        {
            if (ModelState.IsValid)
            {
                db.fee_Amount_January.Add(fee_Amount_January);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", fee_Amount_January.stu_fee_id);
            return View(fee_Amount_January);
        }

        // GET: fee_Amount_January/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fee_Amount_January fee_Amount_January = db.fee_Amount_January.Find(id);
            if (fee_Amount_January == null)
            {
                return HttpNotFound();
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", fee_Amount_January.stu_fee_id);
            return View(fee_Amount_January);
        }

        // POST: fee_Amount_January/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fee_id,fee_Advance,Fee_Amount,fee_month_name,fee_status,fee_date,stu_fee_id")] fee_Amount_January fee_Amount_January)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fee_Amount_January).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", fee_Amount_January.stu_fee_id);
            return View(fee_Amount_January);
        }

        // GET: fee_Amount_January/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fee_Amount_January fee_Amount_January = db.fee_Amount_January.Find(id);
            if (fee_Amount_January == null)
            {
                return HttpNotFound();
            }
            return View(fee_Amount_January);
        }

        // POST: fee_Amount_January/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fee_Amount_January fee_Amount_January = db.fee_Amount_January.Find(id);
            db.fee_Amount_January.Remove(fee_Amount_January);
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
