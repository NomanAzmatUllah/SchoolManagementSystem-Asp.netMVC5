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
    public class classIII_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: classIII_courses
        public ActionResult Index()
        {
            return View(db.classIII_courses.ToList());
        }

        // GET: classIII_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classIII_courses classIII_courses = db.classIII_courses.Find(id);
            if (classIII_courses == null)
            {
                return HttpNotFound();
            }
            return View(classIII_courses);
        }

        // GET: classIII_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: classIII_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] classIII_courses classIII_courses)
        {
            if (ModelState.IsValid)
            {
                db.classIII_courses.Add(classIII_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classIII_courses);
        }

        // GET: classIII_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classIII_courses classIII_courses = db.classIII_courses.Find(id);
            if (classIII_courses == null)
            {
                return HttpNotFound();
            }
            return View(classIII_courses);
        }

        // POST: classIII_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] classIII_courses classIII_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classIII_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classIII_courses);
        }

        // GET: classIII_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classIII_courses classIII_courses = db.classIII_courses.Find(id);
            if (classIII_courses == null)
            {
                return HttpNotFound();
            }
            return View(classIII_courses);
        }

        // POST: classIII_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            classIII_courses classIII_courses = db.classIII_courses.Find(id);
            db.classIII_courses.Remove(classIII_courses);
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
