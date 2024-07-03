using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LtkdK22CNT3Lesson10.Models;

namespace LtkdK22CNT3Lesson10.Controllers
{
    public class LtkdHomeController : Controller
    {
        public ActionResult LtkdIndex()
        {
            //Kiem Tra Du Lieu Trong Sesson
            if (Session["LtkdAccount"] != null)
            {
                var ltkdAccount = Session["LtkdAccount"] as LtkdAccount;
                ViewBag.FullName = ltkdAccount.LtkdFullName;
                
            }
            return View();
        }

        public ActionResult LtkdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult LtkdContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}