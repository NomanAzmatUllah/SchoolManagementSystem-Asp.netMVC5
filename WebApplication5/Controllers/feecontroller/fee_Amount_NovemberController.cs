using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class fee_Amount_NovemberController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: fee_Amount_November
        public ActionResult Index(string search)
        {
            int id = Convert.ToInt32(search);

            if (search == null)
            {
                var fee_Amount_November = db.fee_Amount_November.Include(f => f.tbl_enrolment);
                return View(fee_Amount_November.ToList());
            }
            else
            {
                return View(db.fee_Amount_November.Where(item => item.stu_fee_id == id).ToList());
            }
            
        }

        // GET: fee_Amount_November/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fee_Amount_November fee_Amount_November = db.fee_Amount_November.Find(id);
            if (fee_Amount_November == null)
            {
                return HttpNotFound();
            }
            return View(fee_Amount_November);
        }

        // GET: fee_Amount_November/Create
        public ActionResult Create()
        {
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name");
            return View();
        }

        // POST: fee_Amount_November/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "fee_id,fee_Advance,Fee_Amount,fee_month_name,fee_status,fee_date,stu_fee_id")] fee_Amount_November fee_Amount_November)
        {
            if (ModelState.IsValid)
            {
                db.fee_Amount_November.Add(fee_Amount_November);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", fee_Amount_November.stu_fee_id);
            return View(fee_Amount_November);
        }

        // GET: fee_Amount_November/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fee_Amount_November fee_Amount_November = db.fee_Amount_November.Find(id);
            if (fee_Amount_November == null)
            {
                return HttpNotFound();
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", fee_Amount_November.stu_fee_id);
            return View(fee_Amount_November);
        }

        // POST: fee_Amount_November/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "fee_id,fee_Advance,Fee_Amount,fee_month_name,fee_status,fee_date,stu_fee_id")] fee_Amount_November fee_Amount_November)
        {
            if (ModelState.IsValid)
            {
                db.Entry(fee_Amount_November).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.stu_fee_id = new SelectList(db.tbl_enrolment, "Stu_id", "Stu_f_name", fee_Amount_November.stu_fee_id);
            return View(fee_Amount_November);
        }

        // GET: fee_Amount_November/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            fee_Amount_November fee_Amount_November = db.fee_Amount_November.Find(id);
            if (fee_Amount_November == null)
            {
                return HttpNotFound();
            }
            return View(fee_Amount_November);
        }

        // POST: fee_Amount_November/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            fee_Amount_November fee_Amount_November = db.fee_Amount_November.Find(id);
            db.fee_Amount_November.Remove(fee_Amount_November);
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
