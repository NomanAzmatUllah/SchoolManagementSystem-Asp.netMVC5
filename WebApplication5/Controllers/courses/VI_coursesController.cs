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
    public class VI_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: VI_courses
        public ActionResult Index()
        {
            return View(db.VI_courses.ToList());
        }

        // GET: VI_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VI_courses vI_courses = db.VI_courses.Find(id);
            if (vI_courses == null)
            {
                return HttpNotFound();
            }
            return View(vI_courses);
        }

        // GET: VI_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VI_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] VI_courses vI_courses)
        {
            if (ModelState.IsValid)
            {
                db.VI_courses.Add(vI_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vI_courses);
        }

        // GET: VI_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VI_courses vI_courses = db.VI_courses.Find(id);
            if (vI_courses == null)
            {
                return HttpNotFound();
            }
            return View(vI_courses);
        }

        // POST: VI_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] VI_courses vI_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vI_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vI_courses);
        }

        // GET: VI_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VI_courses vI_courses = db.VI_courses.Find(id);
            if (vI_courses == null)
            {
                return HttpNotFound();
            }
            return View(vI_courses);
        }

        // POST: VI_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            VI_courses vI_courses = db.VI_courses.Find(id);
            db.VI_courses.Remove(vI_courses);
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
