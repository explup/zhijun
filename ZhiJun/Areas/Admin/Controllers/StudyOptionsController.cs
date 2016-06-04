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
    public class StudyOptionsController : Controller
    {
        private ZhiJunModel db = new ZhiJunModel();

        // GET: Admin/StudyOptions
        public ActionResult Index()
        {
            return View(db.StudyOptions.ToList());
        }

        // GET: Admin/StudyOptions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyOption studyOption = db.StudyOptions.Find(id);
            if (studyOption == null)
            {
                return HttpNotFound();
            }
            return View(studyOption);
        }

        // GET: Admin/StudyOptions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/StudyOptions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudyName")] StudyOption studyOption)
        {
            if (ModelState.IsValid)
            {
                db.StudyOptions.Add(studyOption);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studyOption);
        }

        // GET: Admin/StudyOptions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyOption studyOption = db.StudyOptions.Find(id);
            if (studyOption == null)
            {
                return HttpNotFound();
            }
            return View(studyOption);
        }

        // POST: Admin/StudyOptions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudyName")] StudyOption studyOption)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studyOption).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studyOption);
        }

        // GET: Admin/StudyOptions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudyOption studyOption = db.StudyOptions.Find(id);
            if (studyOption == null)
            {
                return HttpNotFound();
            }
            return View(studyOption);
        }

        // POST: Admin/StudyOptions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudyOption studyOption = db.StudyOptions.Find(id);
            db.StudyOptions.Remove(studyOption);
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
