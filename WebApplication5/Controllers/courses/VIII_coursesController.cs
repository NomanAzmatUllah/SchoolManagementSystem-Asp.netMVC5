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
    public class VIII_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: VIII_courses
        public ActionResult Index()
        {
            return View(db.VIII_courses.ToList());
        }

        // GET: VIII_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VIII_courses vIII_courses = db.VIII_courses.Find(id);
            if (vIII_courses == null)
            {
                return HttpNotFound();
            }
            return View(vIII_courses);
        }

        // GET: VIII_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VIII_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] VIII_courses vIII_courses)
        {
            if (ModelState.IsValid)
            {
                db.VIII_courses.Add(vIII_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vIII_courses);
        }

        // GET: VIII_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VIII_courses vIII_courses = db.VIII_courses.Find(id);
            if (vIII_courses == null)
            {
                return HttpNotFound();
            }
            return View(vIII_courses);
        }

        // POST: VIII_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] VIII_courses vIII_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vIII_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vIII_courses);
        }

        // GET: VIII_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VIII_courses vIII_courses = db.VIII_courses.Find(id);
            if (vIII_courses == null)
            {
                return HttpNotFound();
            }
            return View(vIII_courses);
        }

        // POST: VIII_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VIII_courses vIII_courses = db.VIII_courses.Find(id);
            db.VIII_courses.Remove(vIII_courses);
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
