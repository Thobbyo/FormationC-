using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASPAuth.Models;
using Microsoft.AspNet.Identity;

namespace WikyASPAuth.Controllers
{
    public class ArticleController : Controller
    {
        private wikyEntities context = new wikyEntities();

        // GET: Article
        [Authorize]
        public ActionResult AddArticle()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult AddArticle([Bind(Include = "auteur, contenue, theme")]ARTICLE art)
        {
            art.date = DateTime.Now;
            art.utilisateur = User.Identity.GetUserId();
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

        [Authorize]
        [FiltreVerificationUser]
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

        [Authorize]
        [FiltreVerificationUser]
        public ActionResult DisplayModifierArticle(int art)
        {
            var article = (from m in context.ARTICLE where m.id == art select m).FirstOrDefault();
            return View(article);
        }
        
        [HttpPost]
        [Authorize]
        [FiltreVerificationUser]
        [ValidateAntiForgeryToken]
        public ActionResult ModifierArticle([Bind(Include = "auteur, contenue, article, theme, id, utilisateur")]ARTICLE art)
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