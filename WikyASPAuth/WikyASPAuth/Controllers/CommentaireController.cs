using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASPAuth.Models;
using Microsoft.AspNet.Identity;

namespace WikyASPAuth.Controllers
{
    public class CommentaireController : Controller
    {
        private wikyEntities context = new wikyEntities();

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult ajouterCommentaire([Bind(Include = "auteur, contenue, article")]COMMENTAIRE comm)
        {
            comm.date = DateTime.Now;
            comm.utilisateur = User.Identity.GetUserId();
            context.COMMENTAIRE.Add(comm);
            var commentaires = from com in context.COMMENTAIRE where com.article == comm.article select com;
            context.SaveChanges();
            return PartialView("_commentaireList", commentaires.ToList());
        }
    }
}
