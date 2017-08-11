using MaromFit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MaromFit.Models.ViewModel;

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

        [HttpPost]
        public ActionResult Delete(Client client)
        {
            if (client == null)
                return HttpNotFound();

            var clientDel = _context.Client.Find(client.Id);

            if (clientDel == null)
                return HttpNotFound();

            _context.Client.Remove(clientDel);
            _context.SaveChanges();

            return RedirectToAction("Index", "Client");
        }

        public ActionResult Delete(int id)
        {
            var client = _context.Client.Find(id);
            if (client == null)
                return HttpNotFound();

            return View(client);
        }

        public ActionResult New()
        {
            List<Plan> plans = new List<Plan>();
            plans = _context.Plan.ToList();

            UserPlanViewModel viewModel = new UserPlanViewModel
            {
                Client = new Client(),
                Plans = plans
            };

            ViewBag.Acao = "Novo Usuário";

            return View("ClientForm",viewModel);
        }

        public ActionResult Edit(int id)
        {
            var client = _context.Client.Find(id);

            if (client == null)
                return HttpNotFound();

            List<Plan> plans = new List<Plan>();
            plans = _context.Plan.ToList();

            var viewModel = new UserPlanViewModel
            {
                Plans = plans,
                Client = client
            };
            ViewBag.Acao = "Editar Usuário";
            return View("ClientForm",viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Client Client)
        {

            if(!ModelState.IsValid)
            {
                var viewModel = new UserPlanViewModel
                {
                    Plans = _context.Plan.ToList(),
                    Client = Client
                };
                ViewBag.Acao = "Novo Usuário";

                return View("ClientForm", viewModel);
            }

            if(Client.Id == 0)
            {
                Client.SubscribeDate = DateTime.Now;
                _context.Client.Add(Client);
            }
            else
            {
                var clientInDb = _context.Client.Single(s => s.Id == Client.Id);

                clientInDb.Mail = Client.Mail;
                clientInDb.Name = Client.Name;
                clientInDb.PlanId = Client.PlanId;
                clientInDb.SubscribeDate = Client.SubscribeDate;
                clientInDb.IsSubscribedToNews = Client.IsSubscribedToNews;
            }

            _context.SaveChanges();
            return RedirectToAction("Index","Client");
        }

    }
}