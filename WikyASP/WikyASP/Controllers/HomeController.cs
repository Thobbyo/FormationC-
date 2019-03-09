using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASP.Models;

namespace WikyASP.Controllers
{
    public class HomeController : Controller
    {
        private wikyEntities context = new wikyEntities();

        public ActionResult Index()
        {
            var art = (from m in context.ARTICLE orderby m.id descending select m).FirstOrDefault();
            return View(art);
        }
    }
}