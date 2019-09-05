using DatabaseFIrstMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseFIrstMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MaromfitEntities db = new MaromfitEntities();
            var clients = db.Clients.ToList();

            return View(clients);
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
    }
}