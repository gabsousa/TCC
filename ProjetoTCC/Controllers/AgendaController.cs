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
        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult ListaAgenda(int id)
        {
            Models.Data.AgendaData td = new Models.Data.AgendaData();

            return View(td.ListaAgenda());
        }

        // GET: Agenda/Create
        public ActionResult CadastrarAgenda()
        {
            return View();
        }

        // POST: Agenda/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Models.Agenda collection)
        {
            Models.Data.AgendaData agendaData = new Models.Data.AgendaData();
            agendaData.CadastrarAgenda(collection);

            return RedirectToAction(nameof(ListaAgenda));
        }

        // GET: Agenda/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Agenda/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Agenda/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Agenda/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}