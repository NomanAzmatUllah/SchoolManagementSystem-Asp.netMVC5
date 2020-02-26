﻿using System;
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
    public class IX_coursesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: IX_courses
        public ActionResult Index()
        {
            return View(db.IX_courses.ToList());
        }

        // GET: IX_courses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IX_courses iX_courses = db.IX_courses.Find(id);
            if (iX_courses == null)
            {
                return HttpNotFound();
            }
            return View(iX_courses);
        }

        // GET: IX_courses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IX_courses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "cous_id,cous_name")] IX_courses iX_courses)
        {
            if (ModelState.IsValid)
            {
                db.IX_courses.Add(iX_courses);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(iX_courses);
        }

        // GET: IX_courses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IX_courses iX_courses = db.IX_courses.Find(id);
            if (iX_courses == null)
            {
                return HttpNotFound();
            }
            return View(iX_courses);
        }

        // POST: IX_courses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "cous_id,cous_name")] IX_courses iX_courses)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iX_courses).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(iX_courses);
        }

        // GET: IX_courses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IX_courses iX_courses = db.IX_courses.Find(id);
            if (iX_courses == null)
            {
                return HttpNotFound();
            }
            return View(iX_courses);
        }

        // POST: IX_courses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IX_courses iX_courses = db.IX_courses.Find(id);
            db.IX_courses.Remove(iX_courses);
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
