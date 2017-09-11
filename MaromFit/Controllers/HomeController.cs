using MaromFit.Models;
using MaromFit.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaromFit.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        [OutputCache(Duration = 10)]
        public ActionResult Index()
        {
            Client usuario = new Client()
            {
                Id = 1,
                Name = "Thiago"
            };

            //var lstPlanos = new List<Plan>()
            //{
            //    new Models.Plan() {Id=1, Name="Plano 1", Value = 100 },
            //    new Models.Plan() {Id=2, Name="Plano 2", Value = 200 }
            //};

            if(HttpContext.Cache["Planos"] == null)
            {
                HttpContext.Cache["Planos"] = _context.Plan.ToList();
            }

            var lstPlanos = (List<Plan>)HttpContext.Cache["Planos"];

            //HttpContext.Cache.Remove("Planos");

            UserPlanViewModel model = new UserPlanViewModel();
            model.Client = usuario;
            model.Plans = lstPlanos;


            return View(model);
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