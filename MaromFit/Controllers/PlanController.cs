using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MaromFit.Controllers
{
    public class PlanController : Controller
    {
        ApplicationDbContext _context;

        public PlanController()
        {
            _context = new ApplicationDbContext();
        }
        
        public ActionResult Index()
        {
            List<Plan> planos = _context.Plan.ToList();

            return View(planos);
        }

        [Route("editarPlanos/{planoId:regex(\\d{2}):range(1,10)}/{name}")]
        public ActionResult Edit(int planoId, string name)
        {
            return Content("planoId=" + planoId + "Nome: " + name);
        }

    }
}