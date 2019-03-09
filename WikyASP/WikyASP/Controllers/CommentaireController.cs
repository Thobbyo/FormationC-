using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASP.Models;

namespace WikyASP.Controllers
{
    public class CommentaireController : Controller
    {
        private wikyEntities context = new wikyEntities();

        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult ajouterCommentaire(COMMENTAIRE comm)
        {
            comm.date = DateTime.Now;
            context.COMMENTAIRE.Add(comm);
            var commentaires = from com in context.COMMENTAIRE where com.article == comm.article select com;
            context.SaveChanges();
            return PartialView("_commentaireList", commentaires.ToList());
        }
    }
}
