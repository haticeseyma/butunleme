using büt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace büt.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        BeuDBEntities db=  new BeuDBEntities();    
        public ActionResult Index()
        {
            var model = db.Author.ToList();
            return View();
        }
    }
}