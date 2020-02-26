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
    public class stu_enrolmentController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: stu_enrolment
        public ActionResult Index(string search)
        {
            int id = Convert.ToInt16(search);
            if (search == null)
            {
                return View(db.tbl_enrolment.ToList());


            }
            else
            {
                return View(db.tbl_enrolment.Where(item => item.Stu_id == id).ToList());
            }
        }

        // GET: stu_enrolment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_enrolment tbl_enrolment = db.tbl_enrolment.Find(id);
            if (tbl_enrolment == null)
            {
                return HttpNotFound();
            }
            return View(tbl_enrolment);
        }

        // GET: stu_enrolment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: stu_enrolment/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Stu_id,Stu_f_name,Stu_l_name,Stu_father_name,Stu_father_mobile_Number,Stu_father_cnic,Stu_religion,Stu_gender,Stu_contact,Stu_address,Stu_date_of_birth,Stu_nationality,Stu_birth_place,Stu_Emergency_contact,Stu_city,Stu_email_address,Stu_country,Stu_class")] tbl_enrolment tbl_enrolment)
        {
            if (ModelState.IsValid)
            {
                db.tbl_enrolment.Add(tbl_enrolment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_enrolment);
        }

        // GET: stu_enrolment/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_enrolment tbl_enrolment = db.tbl_enrolment.Find(id);
            if (tbl_enrolment == null)
            {
                return HttpNotFound();
            }
            return View(tbl_enrolment);
        }

        // POST: stu_enrolment/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Stu_id,Stu_f_name,Stu_l_name,Stu_father_name,Stu_father_mobile_Number,Stu_father_cnic,Stu_religion,Stu_gender,Stu_contact,Stu_address,Stu_date_of_birth,Stu_nationality,Stu_birth_place,Stu_Emergency_contact,Stu_city,Stu_email_address,Stu_country,Stu_class")] tbl_enrolment tbl_enrolment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_enrolment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_enrolment);
        }

        // GET: stu_enrolment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_enrolment tbl_enrolment = db.tbl_enrolment.Find(id);
            if (tbl_enrolment == null)
            {
                return HttpNotFound();
            }
            return View(tbl_enrolment);
        }

        // POST: stu_enrolment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_enrolment tbl_enrolment = db.tbl_enrolment.Find(id);
            db.tbl_enrolment.Remove(tbl_enrolment);
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
