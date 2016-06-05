﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZhiJun.Models;

namespace Songhong.Controllers
{
    public class HomeController : Controller
    {
        private ZhiJunModel db = new ZhiJunModel();
        public ActionResult Index()
        {

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        // POST: Admin/Messages/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult About([Bind(Include = "MessageBody,SenderEmail,SenderName")] Message message)
        {
            message.SenderDate = System.DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Messages.Add(message);
                db.SaveChanges();
                return RedirectToAction("SendSuccessful");
            }

            return View(message);
        }

        public ActionResult SendSuccessful()
        {
            return View();
        }

        public ActionResult ChengRenGaoKao()
        {
            return View();
        }
        public ActionResult ChengKaoZhuanYe()
        {
            var programmes = db.Programmes.Include(p => p.Institute)
                .Include(p => p.Level)
                .Include(p => p.StudyOption)
                .Include(p => p.University)
                .Where(p=>p.University.Type== "成人高考")
                .OrderBy(p=>p.Id);
            return View(programmes.ToList());
        }
        public ActionResult ChengKaoDaXueJieShao()
        {
            return View(db.Universities.Where(u => u.Type == "成人高考").ToList());
        }

        public ActionResult ZiKao()
        {
            return View();
        }

        public ActionResult ZiKaoZhuanYe()
        {
            var programmes = db.Programmes.Include(p => p.Institute)
                .Include(p => p.Level)
                .Include(p => p.StudyOption)
                .Include(p => p.University)
                .Where(p => p.University.Type == "自考")
                .OrderBy(p => p.Id);
            return View(programmes.ToList());
        }
        public ActionResult ZiKaoDaXueJieShao()
        {
            return View(db.Universities.Where(u => u.Type == "自考").ToList());
        }

        public ActionResult DianDa()
        {
            return View();
        }

        public ActionResult DianDaZhuanYe()
        {
            var programmes = db.Programmes.Include(p => p.Institute)
                .Include(p => p.Level)
                .Include(p => p.StudyOption)
                .Include(p => p.University)
                .Where(p => p.University.Type == "网络教育")
                .OrderBy(p => p.Id);
            return View(programmes.ToList());
        }
        public ActionResult DianDaDaXueJieShao()
        {
            return View(db.Universities.Where(u => u.Type == "网络教育").ToList());
        }

        public ActionResult KaiFangDaXue()
        {
            return View();
        }

        public ActionResult KaiFangDaXueZhuanYe()
        {
            var programmes = db.Programmes.Include(p => p.Institute)
                .Include(p => p.Level)
                .Include(p => p.StudyOption)
                .Include(p => p.University)
                .Where(p => p.University.Type == "开放大学")
                .OrderBy(p => p.Id);
            return View(programmes.ToList());
        }
        public ActionResult KaiFangDaXueJieShao()
        {
            return View(db.Universities.Where(u => u.Type == "开放大学").ToList());
        }

        public ActionResult Apply()
        {

            ViewBag.Gender = new SelectList(new List<string>() {"请选择","男","女" });

            return View();
        }


        // POST: Admin/Applies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Apply([Bind(Include = "Name,Gender,Birthday,Address,Phone,Email,UniverstiyName,ProgrammeName")] Apply apply)
        {
            if (ModelState.IsValid)
            {
                db.Applies.Add(apply);
                db.SaveChanges();
                return RedirectToAction("ApplySuccessful");
            }
            ViewBag.Gender = new SelectList(new List<string>() { "请选择","男", "女" });

            return View(apply);
        }
        public ActionResult ApplySuccessful()
        {
            return View();
        }
    }
}