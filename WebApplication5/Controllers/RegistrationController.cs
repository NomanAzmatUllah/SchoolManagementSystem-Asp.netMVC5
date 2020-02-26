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
    public class RegistrationController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: Registration
        public ActionResult Index(string search)

        {
            int id = Convert.ToInt32(search);

            if (search == null)
            {
                return View(db.tbl_registration.ToList()); 
            }
            else
            {
                return View(db.tbl_registration.Where(item => item.Stu_reg_id == id).ToList());
            }
                        
        }

        // GET: Registration/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_registration tbl_registration = db.tbl_registration.Find(id);
            if (tbl_registration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_registration);
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Registration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Stu_reg_id,Stu_f_name,Stu_l_name,Stu_father_name,stu_father_cnic,stu_nationality,stu_reg_date,Stu_gender,Stu_address,stu_contact,stu_A_Contact,stu_date_of_birth,Stu_religion,stu_class")] tbl_registration tbl_registration)
        {
            try
            {
                //List<tbl_registration> t = new List<tbl_registration>();
                

                if (ModelState.IsValid)
                {
                    db.tbl_registration.Add(tbl_registration);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                throw;
            }
            

            return View(tbl_registration);
        }

        // GET: Registration/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_registration tbl_registration = db.tbl_registration.Find(id);
            if (tbl_registration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_registration);
        }

        // POST: Registration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Stu_reg_id,Stu_f_name,Stu_l_name,Stu_father_name,stu_father_cnic,stu_nationality,stu_reg_date,Stu_gender,Stu_address,stu_contact,stu_A_Contact,stu_date_of_birth,Stu_religion,stu_class")] tbl_registration tbl_registration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_registration).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_registration);
        }

        // GET: Registration/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_registration tbl_registration = db.tbl_registration.Find(id);
            if (tbl_registration == null)
            {
                return HttpNotFound();
            }
            return View(tbl_registration);
        }

        // POST: Registration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_registration tbl_registration = db.tbl_registration.Find(id);
            db.tbl_registration.Remove(tbl_registration);
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
