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
    [Authorize]
    public class InstitutesController : Controller
    {
        private ZhiJunModel db = new ZhiJunModel();

        // GET: Admin/Institutes
        public ActionResult Index()
        {
            var institutes = db.Institutes.Include(i => i.University);
            return View(institutes.ToList());
        }

        // GET: Admin/Institutes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Institute institute = db.Institutes.Find(id);
            if (institute == null)
            {
                return HttpNotFound();
            }
            return View(institute);
        }

        // GET: Admin/Institutes/Create
        public ActionResult Create()
        {
            ViewBag.University_Id = new SelectList(db.Universities, "Id", "Name");
            return View();
        }

        // POST: Admin/Institutes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,University_Id")] Institute institute)
        {
            if (ModelState.IsValid)
            {
                db.Institutes.Add(institute);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.University_Id = new SelectList(db.Universities, "Id", "Name", institute.University_Id);
            return View(institute);
        }

        // GET: Admin/Institutes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Institute institute = db.Institutes.Find(id);
            if (institute == null)
            {
                return HttpNotFound();
            }
            ViewBag.University_Id = new SelectList(db.Universities, "Id", "Name", institute.University_Id);
            return View(institute);
        }

        // POST: Admin/Institutes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,University_Id")] Institute institute)
        {
            if (ModelState.IsValid)
            {
                db.Entry(institute).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.University_Id = new SelectList(db.Universities, "Id", "Name", institute.University_Id);
            return View(institute);
        }

        // GET: Admin/Institutes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Institute institute = db.Institutes.Find(id);
            if (institute == null)
            {
                return HttpNotFound();
            }
            return View(institute);
        }

        // POST: Admin/Institutes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Institute institute = db.Institutes.Find(id);
            db.Institutes.Remove(institute);
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
