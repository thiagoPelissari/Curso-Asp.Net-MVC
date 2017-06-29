using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace MaromFit.Controllers
{
    public class ClientController : Controller
    {
        ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            List<Client> clientes = _context.Client.Include(c => c.Plan).ToList();
            return View(clientes);
        }
    }
}