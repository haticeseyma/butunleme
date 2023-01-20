using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace büt.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            ViewBag.Title = "BEU|Blog";
            return View();
        }
        public ActionResult Category()
        {
            ViewBag.Title = "BEU|Blog";
            return View();
        }
        public ActionResult Populer()
        {
            ViewBag.Title = "BEU|Blog";
            return View();
        }
        public ActionResult Tag()
        {
            ViewBag.Title = "BEU|Blog";
            return View();
        }
        public ActionResult Detail()
        {
            ViewBag.Title = "BEU|Blog";
            return View();
        }
    }
}