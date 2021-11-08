using Blog_ASP.NET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_ASP.NET.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
            List<ArticlesModel> articles = new List<ArticlesModel>();
            articles.Add(new ArticlesModel("Новости Google", "Гугл погряз в коррупции, виной тому послужило советское прошлое Сергея Брина", "Владимир Соловьев"));
            articles.Add(new ArticlesModel("Новости Google", "Гугл погряз в коррупции, виной тому послужило советское прошлое Сергея Брина", "Владимир Соловьев"));
            articles.Add(new ArticlesModel("Новости Google", "Гугл погряз в коррупции, виной тому послужило советское прошлое Сергея Брина", "Владимир Соловьев"));
            return View(articles);
        }
    }
}