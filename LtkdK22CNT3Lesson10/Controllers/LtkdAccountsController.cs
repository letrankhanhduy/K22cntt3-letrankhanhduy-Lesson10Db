using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LtkdK22CNT3Lesson10.Models;

namespace LtkdK22CNT3Lesson10.Controllers
{
    public class LtkdAccountsController : Controller
    {
        private LtkdK22CNT3Lesson10DbEntities db = new LtkdK22CNT3Lesson10DbEntities();

        // GET: LtkdAccounts
        public ActionResult Index()
        {
            return View(db.LtkdAccount.ToList());
        }

        // GET: LtkdAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkdAccount ltkdAccount = db.LtkdAccount.Find(id);
            if (ltkdAccount == null)
            {
                return HttpNotFound();
            }
            return View(ltkdAccount);
        }

        // GET: LtkdAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LtkdAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "LtkdID,LtkdUserName,LtkdPassword,LtkdFullName,LtkdEmail,LtkdPhone,LtkdActive")] LtkdAccount ltkdAccount)
        {
            if (ModelState.IsValid)
            {
                db.LtkdAccount.Add(ltkdAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ltkdAccount);
        }

        // GET: LtkdAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkdAccount ltkdAccount = db.LtkdAccount.Find(id);
            if (ltkdAccount == null)
            {
                return HttpNotFound();
            }
            return View(ltkdAccount);
        }

        // POST: LtkdAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "LtkdID,LtkdUserName,LtkdPassword,LtkdFullName,LtkdEmail,LtkdPhone,LtkdActive")] LtkdAccount ltkdAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ltkdAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ltkdAccount);
        }

        // GET: LtkdAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LtkdAccount ltkdAccount = db.LtkdAccount.Find(id);
            if (ltkdAccount == null)
            {
                return HttpNotFound();
            }
            return View(ltkdAccount);
        }

        // POST: LtkdAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            LtkdAccount ltkdAccount = db.LtkdAccount.Find(id);
            db.LtkdAccount.Remove(ltkdAccount);
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

        // Login
        public ActionResult LtkdLogin()
        {
            var LtkdModel = new LtkdAccount();
            return View();
        }
        [HttpPost]
        public ActionResult LtkdLogin(LtkdAccount ltkdAccount)
        {
            var ltkdCheck = db.LtkdAccount.Where(x => x.LtkdUserName.Equals(ltkdAccount.LtkdUserName) && x.LtkdPassword.Equals(ltkdAccount.LtkdPassword)).FirstOrDefault();
            if(ltkdCheck != null)
            {
                // Luu sesson
                Session["LtkdAccount"] = ltkdCheck;
                return Redirect("/");
            }
            return View(ltkdAccount);
        }
    }
}
