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
    public class ProgrammesController : Controller
    {
        private ZhiJunModel db = new ZhiJunModel();

        // GET: Admin/Programmes
        public ActionResult Index()
        {
            var programmes = db.Programmes.Include(p => p.Institute).Include(p => p.Level).Include(p => p.StudyOption);
            return View(programmes.ToList());
        }

        // GET: Admin/Programmes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programme programme = db.Programmes.Find(id);
            if (programme == null)
            {
                return HttpNotFound();
            }
            return View(programme);
        }

        // GET: Admin/Programmes/Create
        public ActionResult Create()
        {
            ViewBag.Institute_Id = new SelectList(db.Institutes, "Id", "Name");
            ViewBag.Level_Id = new SelectList(db.Levels, "Id", "LevelName");
            ViewBag.StudyOption_Id = new SelectList(db.StudyOptions, "Id", "StudyName");
            return View();
        }

        // POST: Admin/Programmes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Detail,StudyOption_Id,Lengh,Location,Requirement,Level_Id,ClientNumber,Institute_Id,Fee,EaxmStyle,Range")] Programme programme)
        {
            if (ModelState.IsValid)
            {
                db.Programmes.Add(programme);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Institute_Id = new SelectList(db.Institutes, "Id", "Name", programme.Institute_Id);
            ViewBag.Level_Id = new SelectList(db.Levels, "Id", "LevelName", programme.Level_Id);
            ViewBag.StudyOption_Id = new SelectList(db.StudyOptions, "Id", "StudyName", programme.StudyOption_Id);
            return View(programme);
        }

        // GET: Admin/Programmes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programme programme = db.Programmes.Find(id);
            if (programme == null)
            {
                return HttpNotFound();
            }
            ViewBag.Institute_Id = new SelectList(db.Institutes, "Id", "Name", programme.Institute_Id);
            ViewBag.Level_Id = new SelectList(db.Levels, "Id", "LevelName", programme.Level_Id);
            ViewBag.StudyOption_Id = new SelectList(db.StudyOptions, "Id", "StudyName", programme.StudyOption_Id);
            return View(programme);
        }

        // POST: Admin/Programmes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Detail,StudyOption_Id,Lengh,Location,Requirement,Level_Id,ClientNumber,Institute_Id,Fee,EaxmStyle,Range")] Programme programme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(programme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Institute_Id = new SelectList(db.Institutes, "Id", "Name", programme.Institute_Id);
            ViewBag.Level_Id = new SelectList(db.Levels, "Id", "LevelName", programme.Level_Id);
            ViewBag.StudyOption_Id = new SelectList(db.StudyOptions, "Id", "StudyName", programme.StudyOption_Id);
            return View(programme);
        }

        // GET: Admin/Programmes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Programme programme = db.Programmes.Find(id);
            if (programme == null)
            {
                return HttpNotFound();
            }
            return View(programme);
        }

        // POST: Admin/Programmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Programme programme = db.Programmes.Find(id);
            db.Programmes.Remove(programme);
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
