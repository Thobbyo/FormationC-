using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASP.Models;

namespace WikyASP.Controllers
{
    public class ArticleController : Controller
    {
        private wikyEntities context = new wikyEntities();
        
        // GET: Article
        public ActionResult AddArticle()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddArticle(ARTICLE art)
        {
            art.date = DateTime.Now;
            context.ARTICLE.Add(art);
            context.SaveChanges();
            TempData["article"] = art;
            return RedirectToAction("DisplayArticle");
        }

        public ActionResult DisplayArticle(int? art)
        {
            if (art.HasValue)
            {
                var article = (from m in context.ARTICLE where m.id == art select m).FirstOrDefault();
                return View(article);
            }
            else
            {
                return View(TempData["article"]);
            }
        }

        public ActionResult DisplayListArticle()
        {
            List<ARTICLE> lArticle = (from m in context.ARTICLE select m).ToList();
            return View(lArticle);
        }

        public ActionResult SupprimerArticle(int art)
        {
            context.ARTICLE.Remove(context.ARTICLE.Find(art));
            var linqCommL = from comm in context.COMMENTAIRE where comm.article == art select comm;
            foreach(var coment in linqCommL)
            {
                context.COMMENTAIRE.Remove(coment);
            }
            context.SaveChanges();
            return RedirectToAction("DisplayListArticle");
        }

        public ActionResult DisplayModifierArticle(int art)
        {
            var article = (from m in context.ARTICLE where m.id == art select m).FirstOrDefault();
            return View(article);
        }

        // Il y a un pb
        public ActionResult ModifierArticle(ARTICLE art)
        {
            ARTICLE article = context.ARTICLE.Find(art.id);
            article.auteur = art.auteur;
            article.contenue = art.contenue;
            article.theme = art.theme;
            context.SaveChanges();
            TempData["article"] = article;
            return RedirectToAction("DisplayArticle");
        }
    }
}