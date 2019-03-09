using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikyASPAuth.Models;
using Microsoft.AspNet.Identity;
using System.Web.Routing;

public class FiltreVerificationUser : ActionFilterAttribute
{
    // Avant :
    public override void OnActionExecuting(ActionExecutingContext filterContext)
    {
        wikyEntities context = new wikyEntities();
        int idArticle;
        bool isId = int.TryParse(filterContext.HttpContext.Request.Params["id"], out idArticle);
        if(!isId)
        {
            idArticle = int.Parse(filterContext.HttpContext.Request.Params["art"]);
        }
        var idUser = (from art in context.ARTICLE where idArticle == art.id select art.utilisateur).First();
        if (idUser != filterContext.HttpContext.User.Identity.GetUserId())
        {
            filterContext.Result = new RedirectToRouteResult( 
                new RouteValueDictionary {
                    { "controller", "Article" },
                    { "action", "DisplayArticle" },
                    { "art", idArticle }
                });
        }
    }

    // Après :
    public override void OnActionExecuted(ActionExecutedContext filterContext)
    {
        // Log("OnActionExecuted", filterContext.RouteData);
    }
}