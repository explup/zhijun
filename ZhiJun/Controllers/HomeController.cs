using System;
using System.Collections.Generic;
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

        public ActionResult ChengRenGaoKao()
        {
            return View();
        }
        public ActionResult ChengKaoZhuanYe()
        {
            return View();
        }

        public ActionResult Apply()
        {
            return View();
        }
        public ActionResult ProfessionList()
        {
            return View();
        }
        public ActionResult DaXueJieShao()
        {
            return View(db.Universities.Where(u=>u.Type=="成人高考").ToList());
        }
    }
}