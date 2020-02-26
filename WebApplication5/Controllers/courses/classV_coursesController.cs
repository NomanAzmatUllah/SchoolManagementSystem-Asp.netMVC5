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
    public class classV_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: classV_courses
        public ActionResult Index()
        {
            return View(db.classV_courses.ToList());
        }

        // GET: classV_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classV_courses classV_courses = db.classV_courses.Find(id);
            if (classV_courses == null)
            {
                return HttpNotFound();
            }
            return View(classV_courses);
        }

        // GET: classV_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: classV_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] classV_courses classV_courses)
        {
            if (ModelState.IsValid)
            {
                db.classV_courses.Add(classV_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classV_courses);
        }

        // GET: classV_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classV_courses classV_courses = db.classV_courses.Find(id);
            if (classV_courses == null)
            {
                return HttpNotFound();
            }
            return View(classV_courses);
        }

        // POST: classV_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] classV_courses classV_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classV_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classV_courses);
        }

        // GET: classV_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classV_courses classV_courses = db.classV_courses.Find(id);
            if (classV_courses == null)
            {
                return HttpNotFound();
            }
            return View(classV_courses);
        }

        // POST: classV_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            classV_courses classV_courses = db.classV_courses.Find(id);
            db.classV_courses.Remove(classV_courses);
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
