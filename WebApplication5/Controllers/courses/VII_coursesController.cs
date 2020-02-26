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
    public class VII_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: VII_courses
        public ActionResult Index()
        {
            return View(db.VII_courses.ToList());
        }

        // GET: VII_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VII_courses vII_courses = db.VII_courses.Find(id);
            if (vII_courses == null)
            {
                return HttpNotFound();
            }
            return View(vII_courses);
        }

        // GET: VII_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VII_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] VII_courses vII_courses)
        {
            if (ModelState.IsValid)
            {
                db.VII_courses.Add(vII_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vII_courses);
        }

        // GET: VII_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VII_courses vII_courses = db.VII_courses.Find(id);
            if (vII_courses == null)
            {
                return HttpNotFound();
            }
            return View(vII_courses);
        }

        // POST: VII_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] VII_courses vII_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vII_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vII_courses);
        }

        // GET: VII_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VII_courses vII_courses = db.VII_courses.Find(id);
            if (vII_courses == null)
            {
                return HttpNotFound();
            }
            return View(vII_courses);
        }

        // POST: VII_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VII_courses vII_courses = db.VII_courses.Find(id);
            db.VII_courses.Remove(vII_courses);
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
