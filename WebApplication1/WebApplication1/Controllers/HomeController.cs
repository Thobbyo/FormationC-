using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Presentation()
        {
            ViewBag.Title = "PRESENTATION";
            return View();
        }

        [HttpPost]
        public ActionResult Affichage(Message msg)
        {
            return View(msg);
        }

        [HttpPost]
        public ActionResult AffichageStrList(List<string> vals)
        {
            return View(vals);
        }

        [HttpPost]
        public ActionResult AffichageMsgList(List<Message> msg)
        {
            return View(msg);
        }

        public ActionResult AffichageGetMsg(string emeteur, string contenue, DateTime date)
        {
            Message msg = new Message();
            msg.Contenu = contenue;
            msg.Emetteur = emeteur;
            msg.Date = date;
            return View(msg);
        }
    }
}