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
    public class X_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: X_courses
        public ActionResult Index()
        {
            return View(db.X_courses.ToList());
        }

        // GET: X_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            X_courses x_courses = db.X_courses.Find(id);
            if (x_courses == null)
            {
                return HttpNotFound();
            }
            return View(x_courses);
        }

        // GET: X_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: X_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] X_courses x_courses)
        {
            if (ModelState.IsValid)
            {
                db.X_courses.Add(x_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(x_courses);
        }

        // GET: X_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            X_courses x_courses = db.X_courses.Find(id);
            if (x_courses == null)
            {
                return HttpNotFound();
            }
            return View(x_courses);
        }

        // POST: X_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] X_courses x_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(x_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(x_courses);
        }

        // GET: X_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            X_courses x_courses = db.X_courses.Find(id);
            if (x_courses == null)
            {
                return HttpNotFound();
            }
            return View(x_courses);
        }

        // POST: X_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            X_courses x_courses = db.X_courses.Find(id);
            db.X_courses.Remove(x_courses);
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
