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
    public class playgroup_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: playgroup_courses
        public ActionResult Index()
        {
            return View(db.playgroup_courses.ToList());
        }

        // GET: playgroup_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            playgroup_courses playgroup_courses = db.playgroup_courses.Find(id);
            if (playgroup_courses == null)
            {
                return HttpNotFound();
            }
            return View(playgroup_courses);
        }

        // GET: playgroup_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: playgroup_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] playgroup_courses playgroup_courses)
        {
            if (ModelState.IsValid)
            {
                db.playgroup_courses.Add(playgroup_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(playgroup_courses);
        }

        // GET: playgroup_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            playgroup_courses playgroup_courses = db.playgroup_courses.Find(id);
            if (playgroup_courses == null)
            {
                return HttpNotFound();
            }
            return View(playgroup_courses);
        }

        // POST: playgroup_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] playgroup_courses playgroup_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(playgroup_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(playgroup_courses);
        }

        // GET: playgroup_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            playgroup_courses playgroup_courses = db.playgroup_courses.Find(id);
            if (playgroup_courses == null)
            {
                return HttpNotFound();
            }
            return View(playgroup_courses);
        }

        // POST: playgroup_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            playgroup_courses playgroup_courses = db.playgroup_courses.Find(id);
            db.playgroup_courses.Remove(playgroup_courses);
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
