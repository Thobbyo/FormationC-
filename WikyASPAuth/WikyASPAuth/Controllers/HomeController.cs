using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASPAuth.Models;

namespace WikyASPAuth.Controllers
{
    public class HomeController : Controller
    {
        private wikyEntities context = new wikyEntities();

        public ActionResult Index()
        {
            var art = (from m in context.ARTICLE orderby m.id descending select m).FirstOrDefault();
            return View(art);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}