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
    public class classI_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: classI_courses
        public ActionResult Index()
        {
            return View(db.classI_courses.ToList());
        }

        // GET: classI_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classI_courses classI_courses = db.classI_courses.Find(id);
            if (classI_courses == null)
            {
                return HttpNotFound();
            }
            return View(classI_courses);
        }

        // GET: classI_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: classI_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] classI_courses classI_courses)
        {
            if (ModelState.IsValid)
            {
                db.classI_courses.Add(classI_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(classI_courses);
        }

        // GET: classI_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classI_courses classI_courses = db.classI_courses.Find(id);
            if (classI_courses == null)
            {
                return HttpNotFound();
            }
            return View(classI_courses);
        }

        // POST: classI_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] classI_courses classI_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classI_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(classI_courses);
        }

        // GET: classI_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            classI_courses classI_courses = db.classI_courses.Find(id);
            if (classI_courses == null)
            {
                return HttpNotFound();
            }
            return View(classI_courses);
        }

        // POST: classI_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            classI_courses classI_courses = db.classI_courses.Find(id);
            db.classI_courses.Remove(classI_courses);
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
