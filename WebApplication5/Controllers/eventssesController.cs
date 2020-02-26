using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class eventssesController : Controller
    {
        private smssystemEntities1 db = new smssystemEntities1();

        // GET: eventsses
        public ActionResult Index(string search)
        {
            int id = Convert.ToInt32(search);

            if (search == null)
            {
                return View(db.eventsses.ToList());
            }
            else
            {
                return View(db.eventsses.Where(item => item.enents_id == id).ToList());
            }


        }

        // GET: eventsses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eventss eventss = db.eventsses.Find(id);
            if (eventss == null)
            {
                return HttpNotFound();
            }
            return View(eventss);
        }

        // GET: eventsses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: eventsses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "enents_id,events_name,event_date,event_time,event_day")] eventss eventss)
        {
            if (ModelState.IsValid)
            {
                db.eventsses.Add(eventss);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventss);
        }

        // GET: eventsses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eventss eventss = db.eventsses.Find(id);
            if (eventss == null)
            {
                return HttpNotFound();
            }
            return View(eventss);
        }

        // POST: eventsses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "enents_id,events_name,event_date,event_time,event_day")] eventss eventss)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventss).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventss);
        }

        // GET: eventsses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            eventss eventss = db.eventsses.Find(id);
            if (eventss == null)
            {
                return HttpNotFound();
            }
            return View(eventss);
        }

        // POST: eventsses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            eventss eventss = db.eventsses.Find(id);
            db.eventsses.Remove(eventss);
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
