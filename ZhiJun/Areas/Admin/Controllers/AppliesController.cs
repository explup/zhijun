using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ZhiJun.Models;

namespace ZhiJun.Areas.Admin.Controllers
{
    public class AppliesController : Controller
    {
        private ZhiJunModel db = new ZhiJunModel();

        // GET: Admin/Applies
        public ActionResult Index()
        {
            return View(db.Applies.ToList());
        }

        // GET: Admin/Applies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return HttpNotFound();
            }
            return View(apply);
        }

        // GET: Admin/Applies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Applies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Gender,Birthday,Address,Phone,Email,UniverstiyName,ProgrammeName")] Apply apply)
        {
            if (ModelState.IsValid)
            {
                db.Applies.Add(apply);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(apply);
        }

        // GET: Admin/Applies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return HttpNotFound();
            }
            return View(apply);
        }

        // POST: Admin/Applies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Gender,Birthday,Address,Phone,Email,UniverstiyName,ProgrammeName")] Apply apply)
        {
            if (ModelState.IsValid)
            {
                db.Entry(apply).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(apply);
        }

        // GET: Admin/Applies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Apply apply = db.Applies.Find(id);
            if (apply == null)
            {
                return HttpNotFound();
            }
            return View(apply);
        }

        // POST: Admin/Applies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Apply apply = db.Applies.Find(id);
            db.Applies.Remove(apply);
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
