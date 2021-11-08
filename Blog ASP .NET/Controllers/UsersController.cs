using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blog_ASP.NET.Models;

namespace Blog_ASP.NET.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListUsers()
        {
            List<UsersModel> users = new List<UsersModel>();
            users.Add(new UsersModel("Bob", "Marley", 25, false));
            users.Add(new UsersModel("John", "Sina", 30, false));
            users.Add(new UsersModel("Igor", "Over", 40, true));
            users.Add(new UsersModel("Ziggy", "Marley", 20, false));

            return View(users);
        }
    }
}