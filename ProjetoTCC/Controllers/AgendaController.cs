using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoTCC.Controllers
{
    public class AgendaController : Controller
    {
        // GET: Agenda
        public ActionResult Index()
        {
            return View();
        }

        // GET: Agenda/Details/5
        public ActionResult DetalhesAgenda(int id)
        {
            Models.Data.AgendaData ad = new Models.Data.AgendaData();

            return View(ad.DetalhesAgenda(id));
        }

        public ActionResult ListaAgenda()
        {
            Models.Data.AgendaData ad = new Models.Data.AgendaData();

            return View(ad.ListaAgenda());
        }

        // GET: Agenda/Create
        public ActionResult CadastrarAgenda()
        {
            return View();
        }

        // POST: Agenda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CadastrarAgenda(Models.Agenda collection)
        {
            Models.Data.AgendaData ad = new Models.Data.AgendaData();
            ad.CadastrarAgenda(collection);

            return RedirectToAction(nameof(ListaAgenda));
        }

        // GET: Agenda/Edit/5
        public ActionResult EditarAgenda(int id)
        {
            Models.Data.AgendaData ad = new Models.Data.AgendaData();

            return View(ad.DetalhesAgenda(id));
        }

        // POST: Agenda/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditarAgenda(Models.Agenda collection)
        {
            Models.Data.AgendaData ad = new Models.Data.AgendaData();
            ad.EditarAgenda(collection);

            return RedirectToAction(nameof(EditarAgenda));
        }

        // GET: Agenda/Delete/5
        public ActionResult DeletarAgenda(int id)
        {
            Models.Data.AgendaData ad = new Models.Data.AgendaData();

            return View(ad.DetalhesAgenda(id));
        }

        // POST: Agenda/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeletarAgenda(int id, IFormCollection collection)
        {
            Models.Data.AgendaData fd = new Models.Data.AgendaData();
            fd.DeletarAgenda(id);

            return RedirectToAction(nameof(ListaAgenda));
        }
    }
}