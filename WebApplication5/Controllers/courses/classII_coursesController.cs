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
    public class classII_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: classII_courses
        public ActionResult Index()
        {
            return View(db.classII_courses.ToList());
        }

        // GET: classII_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classII_courses classII_courses = db.classII_courses.Find(id);
            if (classII_courses == null)
            {
                return HttpNotFound();
            }
            return View(classII_courses);
        }

        // GET: classII_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: classII_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] classII_courses classII_courses)
        {
            if (ModelState.IsValid)
            {
                db.classII_courses.Add(classII_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classII_courses);
        }

        // GET: classII_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classII_courses classII_courses = db.classII_courses.Find(id);
            if (classII_courses == null)
            {
                return HttpNotFound();
            }
            return View(classII_courses);
        }

        // POST: classII_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] classII_courses classII_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classII_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classII_courses);
        }

        // GET: classII_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classII_courses classII_courses = db.classII_courses.Find(id);
            if (classII_courses == null)
            {
                return HttpNotFound();
            }
            return View(classII_courses);
        }

        // POST: classII_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            classII_courses classII_courses = db.classII_courses.Find(id);
            db.classII_courses.Remove(classII_courses);
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
