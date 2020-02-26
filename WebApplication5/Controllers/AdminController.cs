using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class AdminController : Controller
    {
        smssystemEntities1 db = new smssystemEntities1();
        // GET: Admin
        public ActionResult login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult login(adminviewmodel avm)
        {
            tbl_admin t = db.tbl_admin.Where(x => x.Ad_name == avm.Ad_name && x.Ad_password == avm.Ad_password).SingleOrDefault();
            if (t !=null)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {

                return View("login");
            }
            return View();
        }
    }
}