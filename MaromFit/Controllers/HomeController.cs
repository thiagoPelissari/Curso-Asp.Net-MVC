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
        public ActionResult Index()
        {
            Client usuario = new Client()
            {
                Id = 1,
                Name = "Thiago"
            };

            var lstPlanos = new List<Plan>()
            {
                new Models.Plan() {Id=1, Name="Plano 1", Value = 100 },
                new Models.Plan() {Id=2, Name="Plano 2", Value = 200 }
            };

            PlanoUsuarioViewModel model = new PlanoUsuarioViewModel();
            model.Usuario = usuario;
            model.Planos = lstPlanos;


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