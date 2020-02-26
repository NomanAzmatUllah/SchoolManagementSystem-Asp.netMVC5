using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers.courses
{
    public class classIV_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: classIV_courses
        public ActionResult Index()
        {
            return View(db.classIV_courses.ToList());
        }

        // GET: classIV_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classIV_courses classIV_courses = db.classIV_courses.Find(id);
            if (classIV_courses == null)
            {
                return HttpNotFound();
            }
            return View(classIV_courses);
        }

        // GET: classIV_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: classIV_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] classIV_courses classIV_courses)
        {
            if (ModelState.IsValid)
            {
                db.classIV_courses.Add(classIV_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classIV_courses);
        }

        // GET: classIV_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classIV_courses classIV_courses = db.classIV_courses.Find(id);
            if (classIV_courses == null)
            {
                return HttpNotFound();
            }
            return View(classIV_courses);
        }

        // POST: classIV_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] classIV_courses classIV_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classIV_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classIV_courses);
        }

        // GET: classIV_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classIV_courses classIV_courses = db.classIV_courses.Find(id);
            if (classIV_courses == null)
            {
                return HttpNotFound();
            }
            return View(classIV_courses);
        }

        // POST: classIV_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            classIV_courses classIV_courses = db.classIV_courses.Find(id);
            db.classIV_courses.Remove(classIV_courses);
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
